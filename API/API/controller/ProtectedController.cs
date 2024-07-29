using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.IdentityModel.Tokens; 
using System.IdentityModel.Tokens.Jwt; 
using System.Security.Claims; 
using System.Text;
using LeagueApi; 
using TeamApi;
using UserApi;
 
namespace WebApplicationToken.Controllers { 
    [Route("api/auth")] 
    [ApiController]
    public class ProtectedController : ControllerBase {
        // Chave secreta(_secretKey): é uma chave usada para assinar e verificar tokens JWT (usada para garantir a autenticidade e integridade dos tokens JWT) 
        // No contexto de autenticação com tokens JWT, esta chave é usada para gerar tokens JWT durante o processo de login e verificar a validade dos tokens 
        // recebidos em solicitações futuras. 
        // Esta chave secreta é mantida pelo servidor e não é partilhada com os clientes. 
        private readonly string _secretKey = "SecretKeywqewqeqqqqqqqqqqqweeeeeeeeeeeeeeeeeeeqweqe"; 
        private readonly UserRepository _repository;

        public ProtectedController(UserRepository repository) {
            this._repository = repository;
        }
 
        [HttpPost ("login")]
        public async Task<IActionResult> Login(LoginRequest userRequest) { 
            var user = await _repository.GetUserByName(userRequest.Name);
 
            if (user is not null && user.Password == userRequest.Password) {
                var token = GenerateJwtToken(user.Name, user.Role); 
                return Ok(new { token }); 
            }
            return Unauthorized(); 
        } 

        [HttpPost ("register")]
        public IActionResult Register(User userRequest) { 
            var user = _repository.InsertUserAsync(userRequest);
            
            if (user is not null) {
                return Ok();
            }

            return Unauthorized();
        }
 
        [HttpGet ("classep")]  
        [Authorize]
        public IActionResult Get() { 
            return Ok("Acesso concedido a metodo protegido!");
        } 
 
        [HttpGet ("classep0")] 
        [Authorize(Roles = "Admin")] 
        public IActionResult Get0() { 
            return Ok("Acesso concedido a metodo protegido para perfil Admin!"); 
        }

        private string GenerateJwtToken(string username, string perfil/*, string email*/) { 
            var tokenHandler = new JwtSecurityTokenHandler(); 
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey)); 
 
            var claims = new List<Claim> { 
                new Claim(ClaimTypes.Name, username), 
                //new Claim(ClaimTypes.Email, email), 
                new Claim(ClaimTypes.Role, perfil), 
                // Adicione outras reivindicações conforme necessário
            }; 
 
            var tokenDescriptor = new SecurityTokenDescriptor { 
                Subject = new ClaimsIdentity(claims), 
                Expires = DateTime.UtcNow.AddHours(1), 
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature) 
            }; 
            var token = tokenHandler.CreateToken(tokenDescriptor); 
            return tokenHandler.WriteToken(token);
        } 
    }
}