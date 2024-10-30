using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IVWConvocatoriaFiltroData
    {
        IEnumerable<VwConvocatoriaFiltro> Get(string? PalabraClave, int? NivelAcademico, int? AreaEstudio, int? ModalidadPrograma, int? Pais, int? Idioma);

    }
}
