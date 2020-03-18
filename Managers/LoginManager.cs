using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace loginSisap.Models
{
    public class LoginManager : ILoginManager
    {
        private readonly Models.LoginSisapContext _banco;

        public LoginManager([FromServices] Models.LoginSisapContext banco)
        {
            _banco = banco;

        }

        public async Task<object> Entrar(Login login)
        {

            return login;
        }

        public async Task<object> NovoUsuario(Login novoUsuario)
        {

            return novoUsuario;
        }
    }
}