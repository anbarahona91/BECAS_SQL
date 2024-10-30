using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Convocatorias";
            return View();
        }
    }
}
