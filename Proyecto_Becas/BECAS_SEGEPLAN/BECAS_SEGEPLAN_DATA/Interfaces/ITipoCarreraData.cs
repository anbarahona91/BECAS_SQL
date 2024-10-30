using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoCarreraData
    {
        IEnumerable<TipoCarrera> Listado();
        TipoCarrera ObtenerId(int Id);
    }
}
