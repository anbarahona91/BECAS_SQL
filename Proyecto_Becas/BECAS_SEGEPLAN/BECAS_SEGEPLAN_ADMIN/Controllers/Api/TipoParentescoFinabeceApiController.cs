using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoParentescoFinabeceApiController : Controller
    {
        private readonly ITipoParentescoFinabeceData _Repositorio;

        public TipoParentescoFinabeceApiController(ITipoParentescoFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoParentestoFinabece>> Get()
        {
            return _Repositorio.Listado().ToList();
        }
    }
}
