using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Objetos;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class NivelAcademicoApiController : Controller
    {
        private readonly INivelAcademicoData _Repositorio;

        public NivelAcademicoApiController(INivelAcademicoData repositorio)
        {
            _Repositorio = repositorio;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_Repositorio.Listado(), loadOptions);
        }

        [HttpPost]
        public IActionResult Insert(string values)
        {
            NivelAcademico data = new NivelAcademico();
            JsonConvert.PopulateObject(values, data);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            data.AudIdusuariocreacion = 1;
            data.AudFechacreacion = DateTime.Now;

            respuesta = _Repositorio.Insertar(data);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("IP-INSERT-01", errorMessage: "Error al insertar el nivel académico: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Update(int key, string values)
        {
            NivelAcademico data = _Repositorio.ObtenerId(key);
            JsonConvert.PopulateObject(values, data);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            data.AudIdusuariomodificacion = 1;
            data.AudFechamodificacion = DateTime.Now;

            respuesta = _Repositorio.Update(data);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("IP-UPDATE-01", errorMessage: "Error al actualizar el nivel académico: " + respuesta.Mensaje);
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
                ModelState.AddModelError("IP-DELETE-01", errorMessage: "Error al eliminar el nivel académico: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}
