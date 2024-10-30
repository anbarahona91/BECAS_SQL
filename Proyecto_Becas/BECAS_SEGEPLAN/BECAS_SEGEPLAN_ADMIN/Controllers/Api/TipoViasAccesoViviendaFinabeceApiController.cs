using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoViasAccesoViviendaFinabeceApiController : Controller
    {
        private readonly ITipoViasAccesoViviendaFinabeceData _Repositorio;

        public TipoViasAccesoViviendaFinabeceApiController(ITipoViasAccesoViviendaFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoViasAccesoViviendaFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoViasAccesoViviendaFinabece>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
