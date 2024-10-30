using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IVWProgramaConvocatoriaData
    {
        IEnumerable<VwProgramaConvocatorium> Listado();
        VwProgramaConvocatorium ObtenerId(int IdConvocatoria);
    }
}
