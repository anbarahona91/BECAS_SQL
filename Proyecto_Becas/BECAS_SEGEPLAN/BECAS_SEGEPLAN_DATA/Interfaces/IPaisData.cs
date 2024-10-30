using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IPaisData
    {
        IEnumerable<Pai> Listado();

        IEnumerable<Pai> ListadoAsociadoConvocatoria();
        Pai ObtenerId(int IdPais);
    }
}
