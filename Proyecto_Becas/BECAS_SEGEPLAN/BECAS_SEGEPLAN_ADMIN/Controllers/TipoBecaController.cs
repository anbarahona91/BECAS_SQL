using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class TipoBecaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Tipos de Becas";
            return View();
        }
    }
}
