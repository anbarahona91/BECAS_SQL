using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ModalidadProgramaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TituloOpcion = "Administración de Modalidad de Programas";
            return View();
        }
    }
}
