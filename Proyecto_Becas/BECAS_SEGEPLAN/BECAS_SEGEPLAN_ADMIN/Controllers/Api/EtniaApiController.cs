using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class EtniaApiController : Controller
    {
        private readonly IEtniaData _Repositorio;

        public EtniaApiController(IEtniaData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Etnium>> Get()
        {
            return _Repositorio.Listado().ToList();
        }
    }
}
