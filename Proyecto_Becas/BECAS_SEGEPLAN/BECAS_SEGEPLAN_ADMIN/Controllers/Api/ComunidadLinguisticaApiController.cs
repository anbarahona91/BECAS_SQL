using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class ComunidadLinguisticaApiController : Controller
    {
        private readonly IComunidadLinguisticaData _Repositorio;

        public ComunidadLinguisticaApiController(IComunidadLinguisticaData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ComunidadLinguistica>> Get()
        {
            return _Repositorio.Listado().ToList();
        }
    }
}
