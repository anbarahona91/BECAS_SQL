using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoParedViviendaFinabeceApiController : Controller
    {
        private readonly ITipoParedViviendaFinabeceData _Repositorio;

        public TipoParedViviendaFinabeceApiController(ITipoParedViviendaFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoParedViviendaFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoParedViviendaFinabece>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
