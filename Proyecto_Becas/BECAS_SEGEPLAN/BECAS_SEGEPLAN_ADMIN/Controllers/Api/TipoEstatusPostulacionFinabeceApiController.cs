using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class TipoEstatusPostulacionFinabeceApiController : Controller
    {
        private readonly ITipoEstatusPostulacionFinabeceData _Repositorio;

        public TipoEstatusPostulacionFinabeceApiController(ITipoEstatusPostulacionFinabeceData repositorio)
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
