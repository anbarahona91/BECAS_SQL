using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoTituloData
    {
        IEnumerable<TipoTitulo> Listado();
        TipoTitulo ObtenerId(int Id);
    }
}
