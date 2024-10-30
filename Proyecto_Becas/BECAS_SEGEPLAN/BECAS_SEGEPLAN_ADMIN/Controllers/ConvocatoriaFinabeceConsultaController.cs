using Microsoft.AspNetCore.Mvc;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaFinabeceConsultaController : Controller
    {
        public IActionResult Index(decimal Id)
        {
            ViewBag.TituloOpcion = "Consulta de postulaciones";
            ViewBag.IdConvocatoria = Id.ToString();
            return View();
        }
    }
}
