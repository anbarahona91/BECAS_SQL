using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;

namespace BECAS_SEGEPLAN.Controllers.ApiControllers
{
    public class ConvocatoriaFinabeceDocumentoApiController : Controller
    {
        private readonly IConvocatoriaFinabeceDocumentoData _Repositorio;

        public ConvocatoriaFinabeceDocumentoApiController(IConvocatoriaFinabeceDocumentoData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(decimal IdConvocatoria, decimal IdParticipante, DataSourceLoadOptions loadOptions)
        {

            return DataSourceLoader.Load(_Repositorio.ListadoAsociadoConvocatoriaTipoDocumento(IdConvocatoria,IdParticipante,2), loadOptions);
        }

        
        [HttpPost]
        public IActionResult Delete(int key)
        {
            RespuestaCRUD respuesta = new RespuestaCRUD();

            // Eliminación lógica
            respuesta = _Repositorio.Delete(key, 1);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("AE-DELETE-01", errorMessage: "Error al eliminar el área de estudio: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
