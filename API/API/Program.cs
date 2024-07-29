using LeagueApi; 
using TeamApi;
using UserApi;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Microsoft.AspNetCore.Authentication.JwtBearer; 
using Microsoft.IdentityModel.Tokens; 
using System.Text;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebSocketManager(); // parte 4

builder.Services.AddControllers(); 
builder.Services.AddTransient<UserRepository>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "IS", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() { 
        Name = "Authorization", 
        Type = SecuritySchemeType.ApiKey, 
        Scheme = "Bearer", 
        BearerFormat = "JWT", 
        In = ParameterLocation.Header, 
        Description = "JWT Authorization header using the Bearer scheme.\r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"", 
    }); 

    c.AddSecurityRequirement(new OpenApiSecurityRequirement { { 
        new OpenApiSecurityScheme { 
            Reference = new OpenApiReference { 
                Type = ReferenceType.SecurityScheme, 
                Id = "Bearer" 
            } 
        }, 
        new string[] {} 
    } }); 
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => { 
    options.TokenValidationParameters = new TokenValidationParameters { 
        ValidateIssuer = false, 
        ValidateAudience = false, 
        ValidateLifetime = true, 
        ValidateIssuerSigningKey = true, 
        //ValidIssuer = "your_issuer", 
        //ValidAudience = "your_audience", 
        IssuerSigningKey = new 
        SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecretKeywqewqeqqqqqqqqqqqweeeeeeeeeeeeeeeeeeeqweqe")) 
    }; 
}); 

builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);

var app = builder.Build();

var webSocketPort = builder.Configuration.GetValue<int>("WebSocketServer:Port");  // parte 4

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

// ------------- User ------------- //

app.MapGet("/api/user", async (MySqlDataSource db) => {
    var repository = new UserRepository(db);
    return await repository.GetAllUserAsync();
});

app.MapGet("/api/user/xml", async (MySqlDataSource db) => {
    var repository = new UserRepository(db);
    return await repository.GetAllUserAsync();
});

app.MapPost("/api/user", async ([FromServices] MySqlDataSource db, [FromBody] User body) => { 
    var repository = new UserRepository(db); 
    await repository.InsertUserAsync(body);
    return body; 
});

// . . .

// ------------- League ------------- //

app.MapGet("/api/league", async (MySqlDataSource db) => {
    var repository = new LeagueRepository(db);
    return await repository.GetAllLeagueAsync();
});

app.MapGet("/api/league/xml", async (MySqlDataSource db) => {
    var repository = new LeagueRepository(db);
    return await repository.GetAllLeagueAsync();
});

app.MapPost("/api/league", async ([FromServices] MySqlDataSource db, [FromBody] League body) => { 
    var repository = new LeagueRepository(db); 
    await repository.InsertLeagueAsync(body);
    return body; 
});

app.MapPut("/api/league/{id}", async (int id, [FromServices] MySqlDataSource db, [FromBody] League body) => { 
    var repository = new LeagueRepository(db); 
    var result = await repository.FindOneAsync(id);

    if (result is null) 
        return Results.NotFound();

    result.leagueName = body.leagueName;
    result.leagueCountry = body.leagueCountry;
    result.leagueMaxCap = body.leagueMaxCap;
    await repository.UpdateAsync(result);

    return Results.Ok(result);
});

app.MapDelete("/api/league/{id}", async ([FromServices] MySqlDataSource db, int id) => { 
    var repository = new LeagueRepository(db); 
    var result = await repository.FindOneAsync(id); 

    if (result is null) 
        return Results.NotFound();

    await repository.DeleteAsync(result); 
    return Results.NoContent();
});

// ------------- Team ------------- //

app.MapGet("/api/team", async (MySqlDataSource db) => {
    var repository = new TeamRepository(db);
    return await repository.GetAllTeamAsync();
});

app.MapPost("/api/team", async ([FromServices] MySqlDataSource db, [FromBody] Team body) => { 
    var repository = new TeamRepository(db); 
    await repository.InsertTeamAsync(body);
    return body; 
});

app.MapPut("/api/team/{id}", async (int id, [FromServices] MySqlDataSource db, [FromBody] Team body) => { 
    var repository = new TeamRepository(db); 
    var result = await repository.FindOneAsync(id);

    if (result is null) 
        return Results.NotFound();

    result.teamName = body.teamName;
    result.FkIdLeague = body.FkIdLeague;
    await repository.UpdateAsync(result);

    return Results.Ok(result);
});

app.MapDelete("/api/team/{id}", async ([FromServices] MySqlDataSource db, int id) => { 
    var repository = new TeamRepository(db); 
    var result = await repository.FindOneAsync(id); 

    if (result is null) 
        return Results.NotFound();

    await repository.DeleteAsync(result); 
    return Results.NoContent();
});

app.UseWebSockets();
app.MapWebSocketManager("/ws", new WebSocketHandler());

app.Run($"http://localhost:{webSocketPort}");

// app.Run();