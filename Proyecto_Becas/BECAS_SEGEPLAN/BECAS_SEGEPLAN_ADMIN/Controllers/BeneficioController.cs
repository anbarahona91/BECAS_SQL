using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class BeneficioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Beneficios de Convocatorias";
            return View();
        }
    }
}
