using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class SubAreaEstudioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Subáreas de Estudio";
            return View();
        }
    }
}
