using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class DepartamentoApiController : Controller
    {

        private readonly IDepartamentoData _Repositorio;

        public DepartamentoApiController(IDepartamentoData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Departamento>> Get()
        {
            return _Repositorio.Listado().ToList();
        }
    }
}
