using Microsoft.AspNetCore.Mvc;
using FuncionalidadeTCC.Models;


namespace FuncionalidadeTCC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioControllers : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario() {Cpf = 123456789 , id = 1 , senha = " 123@" , nome = "Fabia", email = "fabia@etec.com" },
            new Usuario() {Cpf = 987654321 , id = 2 , senha = " 321@" , nome = "Allan", email = "Allan@etec.com" },
            new Usuario() {Cpf = 222222222 , id = 3 , senha = " 456." , nome = "Kaleb", email = "Kaleb@etec.com" },
            new Usuario() {Cpf = 435575688 , id = 4 , senha = " 54367@" , nome = "Henrique", email = "Henrique@etec.com" },
            new Usuario() {Cpf = 456789234 , id = 5 , senha = " 25657654!" , nome = "Gumesi", email = "gumesi@etec.com" }
        };
        public IActionResult Get()
        {
            return Ok(usuarios);
        }       

    }
}