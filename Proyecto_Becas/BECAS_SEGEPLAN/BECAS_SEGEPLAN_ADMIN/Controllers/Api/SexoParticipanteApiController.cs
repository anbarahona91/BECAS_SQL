using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_ADMIN.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class SexoParticipanteApiController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<SexoParticipante>> Get()
        {
            ListadoSexoParticipante lista = new ListadoSexoParticipante();
            lista.GenerarListado();
            return lista.Listado.ToList();
        }
    }
}
