using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class MunicipioApiController : Controller
    {
        private readonly IMunicipioData _Repositorio;

        public MunicipioApiController(IMunicipioData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Municipio>> Get()
        {
            return _Repositorio.Listado().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Municipio>> GetD(int iddepartamento)
        {
            return _Repositorio.Listado().Where(p=> p.IdDepartamento == iddepartamento).ToList();
        }
    }
}
