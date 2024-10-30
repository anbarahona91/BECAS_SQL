using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Objetos;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class ConvocatoriaPublicoApiController : Controller
    {
        private readonly IConvocatoriaPublicoData _Repositorio;

        public ConvocatoriaPublicoApiController(IConvocatoriaPublicoData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(int IdConvocatoria, DataSourceLoadOptions loadOptions)
        {

            return DataSourceLoader.Load(_Repositorio.ListadoPublicoAsociadoConvocatoria(IdConvocatoria), loadOptions);
        }

        [HttpPost]
        public IActionResult Insert(int IdConvocatoria, string values)
        {
            IdConvocatoria = (int)HttpContext.Session.GetInt32("IdConvocatoria");
            ConvocatoriaPublico data = new ConvocatoriaPublico();
            JsonConvert.PopulateObject(values, data);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            data.AudIdusuariocreacion = 1;
            data.Idconvocatoria = IdConvocatoria;
            data.AudFechacreacion = DateTime.Now;

            respuesta = _Repositorio.Insertar(data);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("AE-INSERT-01", errorMessage: "Error al insertar el área de estudio: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Update(int key, string values)
        {
            ConvocatoriaPublico data = _Repositorio.ObtenerId(key);
            JsonConvert.PopulateObject(values, data);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            data.AudIdusuariomodificacion = 1;
            data.AudFechamodificacion = DateTime.Now;

            respuesta = _Repositorio.Update(data);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("AE-UPDATE-01", errorMessage: "Error al actualizar el área de estudio: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();

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
