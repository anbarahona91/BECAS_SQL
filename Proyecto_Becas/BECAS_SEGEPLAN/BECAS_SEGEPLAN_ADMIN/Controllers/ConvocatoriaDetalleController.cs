using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaDetalleController : Controller
    {
        private readonly IConvocatoriaData _Repositorio;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConvocatoriaDocumentoData _documento;

        public ConvocatoriaDetalleController(IConvocatoriaData repositorio,IWebHostEnvironment host, IConvocatoriaDocumentoData documento)
        {
            _Repositorio = repositorio;
            _hostingEnvironment = host;
            _documento = documento;
        }



        public IActionResult Index(int Id)
        {
            Convocatorium DataConvocatoria = _Repositorio.ObtenerId(Id);
            ViewBag.TituloConvocatoria = DataConvocatoria.Nombre;
            ViewBag.TituloOpcion = "Administración de Convocatorias";
            ViewBag.IdConvocatoria = Id.ToString();
            HttpContext.Session.SetInt32("IdConvocatoria",Id); 
            return View();
        }

        [HttpPost]
        public IActionResult CargarArchivo(int Id, string NombreArchivo, IFormFile file)
        {
            if(file != null)
            {
                var uniqueFileName = GetUniqueFileName(file.FileName);
                var uploads = Path.Combine(@"C:\inetpub\wwwroot\wwwroot", "Documentos");
                var filePath = Path.Combine(uploads, uniqueFileName);
                using (FileStream fileStream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }

                ConvocatoriaDocumento doc = new ConvocatoriaDocumento();
                doc.Idconvocatoria = Id;
                doc.Nombre = NombreArchivo;
                doc.Documento = uniqueFileName;
                doc.AudIdusuariocreacion = 1;
                doc.AudFechacreacion = DateTime.Today;

                _documento.Insertar(doc);
                
            }


            Convocatorium DataConvocatoria = _Repositorio.ObtenerId(Id);
            ViewBag.TituloConvocatoria = DataConvocatoria.Nombre;
            ViewBag.TituloOpcion = "Administración de Convocatorias";
            ViewBag.IdConvocatoria = Id.ToString();
            HttpContext.Session.SetInt32("IdConvocatoria", Id);
            return RedirectToAction("Index", "ConvocatoriaDetalle", new { id = Id});

        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 8)
                      + Path.GetExtension(fileName);
        }
    }
}
