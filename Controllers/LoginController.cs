using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaAPI.Models;
using AcademiaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace AcademiaAPI.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private IConfiguration _config;

        public LoginController([FromServices] IConfiguration config, [FromServices] IUsuarioService usuarioService)
        {
            _config = config;
            _usuarioService = usuarioService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Usuario usuario)
        {
            var result = await _usuarioService.GetUsuario();
            if (result.Senha == usuario.Senha && result.NomeDeUsuario == usuario.NomeDeUsuario)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    null,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);

                var token =  new JwtSecurityTokenHandler().WriteToken(Sectoken);
    
                return Ok(token);
            }
            return BadRequest("Errou dnv");
        }

    }
}