using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoCaracteristicaViviendaFinabeceApiController : Controller
    {
        private readonly ITipoCaracteristicaViviendaFinabeceData _Repositorio;

        public TipoCaracteristicaViviendaFinabeceApiController(ITipoCaracteristicaViviendaFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoCaracteristicaViviendaFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoCaracteristicaViviendaFinabece>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
