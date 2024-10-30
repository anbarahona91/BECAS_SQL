using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class CooperanteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de cooperantes";
            return View();
        }
    }
}
