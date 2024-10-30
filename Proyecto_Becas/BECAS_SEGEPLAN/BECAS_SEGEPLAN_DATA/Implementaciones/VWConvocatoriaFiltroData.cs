using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class VWConvocatoriaFiltroData : IVWConvocatoriaFiltroData
    {
        private readonly ModelContext _appDbContext;

        public VWConvocatoriaFiltroData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<VwConvocatoriaFiltro> Get(string? PalabraClave, int? NivelAcademico, int? AreaEstudio, int? ModalidadPrograma, int? Pais, int? Idioma)
        {
            var query = (from a in _appDbContext.VwConvocatoriaFiltros
                         where (NivelAcademico == null || a.IdnivelAcademico == NivelAcademico)
                         && (AreaEstudio == null || a.IdareaEstudio == AreaEstudio)
                         && (ModalidadPrograma == null || a.IdmodalidadPrograma == ModalidadPrograma)
                         && (Pais == null || a.Idpais == Pais)
                         && (Idioma == null || a.IdIdioma == Idioma)
                         && (PalabraClave == null || a.Nombre.Contains(PalabraClave) || a.Descripcion.Contains(PalabraClave))
                         select a);

            return query.ToList();
        }
    }
}
