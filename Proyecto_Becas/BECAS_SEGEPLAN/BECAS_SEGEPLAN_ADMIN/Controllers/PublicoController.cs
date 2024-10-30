using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class PublicoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Tipo de Público";
            return View();
        }
    }
}
