using System.Threading.Tasks;
using NSE.WebApp.MVC.Models;
using UsuarioLogin = NSE.WebApp.MVC.Models.UsuarioLogin;
using UsuarioRegistro = NSE.WebApp.MVC.Models.UsuarioRegistro;

namespace NSE.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
    }
}