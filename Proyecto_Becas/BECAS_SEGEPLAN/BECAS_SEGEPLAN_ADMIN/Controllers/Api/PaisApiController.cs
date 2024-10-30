using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using Newtonsoft.Json;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class PaisApiController : Controller
    {
        private readonly IPaisData _Repositorio;

        public PaisApiController(IPaisData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_Repositorio.Listado(), loadOptions);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pai>> GetAsociadoConvocatoria()
        {
            return _Repositorio.ListadoAsociadoConvocatoria().ToList();
        }
    }
}
