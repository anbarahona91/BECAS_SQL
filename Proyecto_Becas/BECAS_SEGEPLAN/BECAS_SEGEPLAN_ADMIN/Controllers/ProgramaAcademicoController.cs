using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ProgramaAcademicoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Programas Académicos";
            return View();
        }
    }
}
