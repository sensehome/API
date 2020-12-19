using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SenseHome.DataTransferObjects.Authentication;
using SenseHome.Services.Authentication;

namespace SenseHome.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : SenseHomeBaseController
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        [HttpPost, Route("login")]
        public async Task<ActionResult<String>> LoginAsync([FromBody] UserLoginDto userLogin)
        {
                var user = await authenticationService.Authenticate(userLogin.Name, userLogin.Password);
                if (user == null)
                {
                    return Unauthorized("Invalid credential");
                }
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:44333",
                    audience: "https://localhost:44333",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signingCredentials
                    );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }
        }
    }
