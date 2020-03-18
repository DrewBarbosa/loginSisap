using System.Threading.Tasks;

namespace loginSisap.Models
{
    public interface ILoginManager
    {
        Task<object> Entrar(Login entrar);
        Task<object> NovoUsuario(Login novoUsuario);
    }
}