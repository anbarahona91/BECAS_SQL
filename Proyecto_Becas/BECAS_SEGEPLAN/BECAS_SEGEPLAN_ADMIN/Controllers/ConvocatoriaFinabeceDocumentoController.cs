using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaFinabeceDocumentoController : Controller
    {

        private readonly IConvocatoriaFinabeceDocumentoData _DocumentoData;

        public ConvocatoriaFinabeceDocumentoController(IConvocatoriaFinabeceDocumentoData data)
        {
            _DocumentoData = data;
        }

        public IActionResult Index(decimal id, decimal idconv)
        {
            ViewBag.IdParticipante = id.ToString();
            ViewBag.IdConvocatoria = idconv.ToString();
            ViewBag.PathFoto = _DocumentoData.ObtenerFotografiaVigente(idconv, id);
            ViewBag.Imagen = "lamisma";
            return View();
            
        }
    }
}
