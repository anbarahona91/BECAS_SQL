using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Objetos;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace BECAS_SEGEPLAN_ADMIN.Controllers.Api
{
    public class CooperatenApiController : Controller
    {
        private readonly ICooperanteData _Repositorio;

        public CooperatenApiController(ICooperanteData repositorio)
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
            Cooperante cooperante = new Cooperante();
            JsonConvert.PopulateObject(values, cooperante);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            cooperante.AudIdusuariocreacion = 1;
            cooperante.AudFechacreacion = DateTime.Now;

            respuesta = _Repositorio.Insertar(cooperante);
            
            if(!respuesta.Resultado)
            {
                ModelState.AddModelError("COO-INSERT-01",  errorMessage: "Error al insertar cooperante: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }


        [HttpPost]
        public IActionResult Update(int key, string values)
        {
            Cooperante cooperante = _Repositorio.ObtenerId(key);
            JsonConvert.PopulateObject(values, cooperante);
            RespuestaCRUD respuesta = new RespuestaCRUD();

            cooperante.AudIdusuariomodificacion = 1;
            cooperante.AudFechamodificacion = DateTime.Now;

            respuesta = _Repositorio.Update(cooperante);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("COO-UPDATE-01", errorMessage: "Error al actualizar cooperante: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();

        }

        
        [HttpPost]
        public IActionResult Delete(int key)
        {
            RespuestaCRUD respuesta = new RespuestaCRUD();
            Cooperante cooperante = _Repositorio.ObtenerId(key);

            // Eliminación lógica
            respuesta = _Repositorio.Delete(key, 1);

            if (!respuesta.Resultado)
            {
                ModelState.AddModelError("COO-DELETE-01", errorMessage: "Error al eliminar cooperante: " + respuesta.Mensaje);
                return BadRequest(ModelState);
            }

            return Ok();
        }

    }   
}
