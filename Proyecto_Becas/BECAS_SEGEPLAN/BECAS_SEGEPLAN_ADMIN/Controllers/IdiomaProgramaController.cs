using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class IdiomaProgramaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Idiomas para los Programas Académicos";
            return View();
        }
    }
}
