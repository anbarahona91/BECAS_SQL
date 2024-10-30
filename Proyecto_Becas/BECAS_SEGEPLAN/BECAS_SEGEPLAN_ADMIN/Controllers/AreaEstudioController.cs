using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class AreaEstudioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Áreas de Estudio";
            return View();
        }
    }
}
