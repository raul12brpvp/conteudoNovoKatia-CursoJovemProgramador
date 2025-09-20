using Microsoft.AspNetCore.Mvc;
using tentativa_2.Data.Repositorio.Interfaces;
using tentativa_2.Models;

namespace tentativa_2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {

                var retorno = _usuarioRepositorio.ValidarUsuario(usuario);

                if (retorno != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Usuario ou senha incorretos! Tente novamente...";
                }
            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Erro ao buscar dados do usuário";
            }

            return View("Index");
        }

        public IActionResult Cadastro(Usuario usuario)
        {
            return View();
        }

        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.CadastrarUsuario(usuario);
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao cadastrar usuário";
            }
                
            return View("Index");
        }
    }
}
