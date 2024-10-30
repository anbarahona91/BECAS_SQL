using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoServicioViviendaFinabeceData
    {
        IEnumerable<TipoServicioViviendaFinabece> Listado();

        IEnumerable<TipoServicioViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoServicioViviendaFinabece ObtenerId(int IdTipoServicio);

        RespuestaCRUD Insertar(TipoServicioViviendaFinabece TipoServicio);
        RespuestaCRUD Update(TipoServicioViviendaFinabece TipoServicio);
        RespuestaCRUD Delete(decimal IdTipoServicio, short IdUsuario);
    }
}
