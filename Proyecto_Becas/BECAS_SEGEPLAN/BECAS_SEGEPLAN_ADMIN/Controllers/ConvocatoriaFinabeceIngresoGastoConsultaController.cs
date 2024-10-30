using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaFinabeceIngresoGastoConsultaController : Controller
    {
        private readonly IParticipanteData _Repositorio;

        public ConvocatoriaFinabeceIngresoGastoConsultaController(IParticipanteData repositorio)
        {
            _Repositorio = repositorio;
        }

        public IActionResult Index(decimal id, decimal idconv)
        {
            Participante data = _Repositorio.ObtenerId(id);

            ViewBag.IdConvocatoria = idconv.ToString();
            ViewBag.IdParticipante = id.ToString();
            ViewBag.Nombre = data.Nombre + " " + data.Apellidos + " - CUI:" + data.CuiDpi;
            @ViewBag.TituloOpcion = "Gasto de estudios, Ingreso y Gasto familiar FINABECE";

            HttpContext.Session.SetString("IdParticipante", id.ToString());
            HttpContext.Session.SetString("IdConvocatoria", idconv.ToString());

            return View();
        }
    }
}
