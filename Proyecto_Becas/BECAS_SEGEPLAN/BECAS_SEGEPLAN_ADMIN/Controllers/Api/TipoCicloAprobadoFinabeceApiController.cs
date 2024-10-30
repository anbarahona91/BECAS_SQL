using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class TipoCicloAprobadoFinabeceApiController : Controller
    {
        private readonly ITipoCicloAprobadoFinabeceData _Repositorio;

        public TipoCicloAprobadoFinabeceApiController(ITipoCicloAprobadoFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_Repositorio.Listado(), loadOptions);
        }
    }
}
