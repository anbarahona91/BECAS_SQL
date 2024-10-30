using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IComunidadLinguisticaData
    {
        IEnumerable<ComunidadLinguistica> Listado();
        ComunidadLinguistica ObtenerId(int Id);
    }
}
