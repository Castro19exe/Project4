public static class WebSocketExtensions { 
    public static IServiceCollection AddWebSocketManager(this IServiceCollection services) { 
        services.AddTransient<WebSocketHandler>(); 
        return services;
    }
    
    public static IApplicationBuilder MapWebSocketManager(this IApplicationBuilder app, PathString path, WebSocketHandler handler) { 
        return app.Map(path, (x) => x.UseMiddleware<WebSocketManagerMiddleware>(handler)); 
    }
}