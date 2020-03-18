using System.Threading.Tasks;
using loginSisap.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace loginSisap.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly Models.LoginSisapContext _banco;
        private readonly ILoginManager _loginManager;

        public LoginController([FromServices] ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }
        public async Task<ActionResult> Registrar(Login newUsuario)
        {
            if (string.IsNullOrEmpty(newUsuario.Usuario) && string.IsNullOrEmpty(newUsuario.Senha))
                return BadRequest(new { message = "Sem dados." });
            var retornoManager = await _loginManager.NovoUsuario(newUsuario);
            return new JsonResult(retornoManager);
        }

        public async Task<ActionResult> Login([FromBody] Login entrar)
        {
            if (string.IsNullOrEmpty(entrar.Usuario) && string.IsNullOrEmpty(entrar.Senha))
                return BadRequest(new { message = "Sem dados." });

            var retornoManager = await _loginManager.Entrar(entrar);
            return new JsonResult(retornoManager);

        }
    }
}