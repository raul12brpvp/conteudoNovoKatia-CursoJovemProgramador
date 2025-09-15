using Microsoft.AspNetCore.Mvc;
using tentativa_2.Models;

namespace tentativa_2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.Email == "Raul@gmail" && usuario.Senha == "RR123")
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
    }
}
