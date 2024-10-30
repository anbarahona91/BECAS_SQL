using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ConvocatoriaPublicarController : Controller
    {
        private readonly IConvocatoriaData _Repositorio;
        private readonly IConvocatoriaPaisData _Pais;
        private readonly IConvocatoriaNivelAcademicoData _NivelAcademicoData;
        private readonly IConvocatoriaIdiomaRequeridoData _convocatoriaIdiomaRequeridoData;
        private readonly IConvocatoriaProgramaEstudioData _programa;

        public ConvocatoriaPublicarController(IConvocatoriaData repositorio, IConvocatoriaPaisData pais, IConvocatoriaNivelAcademicoData nivelAcademicoData, IConvocatoriaIdiomaRequeridoData convocatoriaIdiomaRequeridoData , IConvocatoriaProgramaEstudioData programa)
        {
            _Repositorio = repositorio;
            _Pais = pais;
            _NivelAcademicoData = nivelAcademicoData;
            _convocatoriaIdiomaRequeridoData = convocatoriaIdiomaRequeridoData;
            _programa = programa;

        }

        public IActionResult Index(int Id)
        {
            Convocatorium DataConvocatoria = _Repositorio.ObtenerId(Id);
            ViewBag.TituloConvocatoria = DataConvocatoria.Nombre;
            ViewBag.TituloOpcion = "Administración de publicación de Convocatorias";
            ViewBag.Id = Id.ToString();
            ViewBag.Publica = DataConvocatoria.Publica;
            HttpContext.Session.SetInt32("IdConvocatoria", Id);
            
            if(_Pais.ListadoPaisesAsociadoConvocatoria(Id).Count() > 0)
            {
                ViewBag.Pais = true;
            }
            else
            {
                ViewBag.Pais = false;
            }

            if (_NivelAcademicoData.ListadoAsociadoConvocatoria(Id).Count() > 0)
            {
                ViewBag.Nivel = true;
            }
            else
            {
                ViewBag.Nivel = false;
            }

            if (_convocatoriaIdiomaRequeridoData.ListadoAsociadoConvocatoria(Id).Count() > 0)
            {
                ViewBag.Idioma = true;
            }
            else
            {
                ViewBag.Idioma = false;
            }

            if (_programa.ListadoNivelesAsociadoConvocatoria(Id).Count() > 0)
            {
                ViewBag.Oferta = true;
            }
            else
            {
                ViewBag.Oferta = false;
            }

            return View();
            
        }

        public IActionResult Publicar(int Id)
        {
            Convocatorium DataConvocatoria = _Repositorio.ObtenerId(Id);
            DataConvocatoria.Publica = true;
            ViewBag.TituloConvocatoria = DataConvocatoria.Nombre;
            ViewBag.TituloOpcion = "Administración de Convocatorias";
            ViewBag.Id = Id.ToString();
            ViewBag.Publica = DataConvocatoria.Publica;
            _Repositorio.Update(DataConvocatoria);

            return View("Index");
        }

        public IActionResult Ocultar(int Id)
        {
            Convocatorium DataConvocatoria = _Repositorio.ObtenerId(Id);
            DataConvocatoria.Publica = false;
            ViewBag.TituloConvocatoria = DataConvocatoria.Nombre;
            ViewBag.TituloOpcion = "Administración de Convocatorias";
            ViewBag.Id = Id.ToString();
            ViewBag.Publica = DataConvocatoria.Publica;
            _Repositorio.Update(DataConvocatoria);

            return View("Index");
        }
    }
}
