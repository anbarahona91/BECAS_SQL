using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoServicioViviendaFinabeceApiController : Controller
    {
        private readonly ITipoServicioViviendaFinabeceData _Repositorio;

        public TipoServicioViviendaFinabeceApiController(ITipoServicioViviendaFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoServicioViviendaFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoServicioViviendaFinabece>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
