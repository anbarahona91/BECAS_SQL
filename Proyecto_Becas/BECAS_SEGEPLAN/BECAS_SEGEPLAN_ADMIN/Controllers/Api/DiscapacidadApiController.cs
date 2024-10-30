using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class DiscapacidadApiController : Controller
    {
        private readonly IDiscapacidadData _Repositorio;

        public DiscapacidadApiController(IDiscapacidadData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Discapacidad>> Get()
        {
            return _Repositorio.Listado().ToList();
        }
    }
}
