using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ClasificacionEspecialidadController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Clasificación de Especialidad";
            return View();
        }
    }
}
