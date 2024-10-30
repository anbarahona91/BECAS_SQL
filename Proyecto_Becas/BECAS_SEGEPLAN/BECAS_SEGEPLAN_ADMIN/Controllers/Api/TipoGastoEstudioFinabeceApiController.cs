using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoGastoEstudioFinabeceApiController : Controller
    {
        private readonly ITipoGastoEstudioFinabeceData _Repositorio;

        public TipoGastoEstudioFinabeceApiController(ITipoGastoEstudioFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoGastoEstudioFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoGastoEstudioFinabece>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
