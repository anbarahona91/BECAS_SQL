using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class VWParticipantePostulacionFinabeceApiController : Controller
    {
        private readonly IVWParticipantePostulacionFinabeceData _Repositorio;

        public VWParticipantePostulacionFinabeceApiController(IVWParticipantePostulacionFinabeceData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(decimal IdConvocatoria, DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_Repositorio.Get(IdConvocatoria).ToList(), loadOptions);
            
        }
    }
}
