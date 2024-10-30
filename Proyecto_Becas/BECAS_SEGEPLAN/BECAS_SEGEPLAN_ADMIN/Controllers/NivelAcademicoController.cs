using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class NivelAcademicoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Niveles Académicos";
            return View();
        }
    }
}
