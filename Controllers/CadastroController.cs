using Microsoft.AspNetCore.Mvc;

namespace Instadev.Controllers
{
        [Route("Cadastro")]
    public class CadastroController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }
    }
}