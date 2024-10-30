using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IEventoData
    {
        IEnumerable<Evento> ListadoEvento();
        Evento ObtenerEventoId(int IdEvento);
    }
}
