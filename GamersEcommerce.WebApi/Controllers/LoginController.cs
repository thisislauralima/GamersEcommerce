using GamersEcommerce.Service;
using GamersEcommerce.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamersEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] ApplicationAccess applicationAccess)
        {
            var token = TokenService.GenerateToken(_configuration, applicationAccess);
            var refreshToken = TokenService.GenerateRefreshToken();
            TokenService.SaveRefreshToken(applicationAccess.Name, refreshToken);

            return new
            {
                token = token,
                refreshToken = refreshToken,
            };
        }
    }
}
