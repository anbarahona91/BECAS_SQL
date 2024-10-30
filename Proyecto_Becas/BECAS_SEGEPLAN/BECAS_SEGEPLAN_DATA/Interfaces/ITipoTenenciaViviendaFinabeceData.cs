using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoTenenciaViviendaFinabeceData
    {
        IEnumerable<TipoTenenciaViviendaFinabece> Listado();

        IEnumerable<TipoTenenciaViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoTenenciaViviendaFinabece ObtenerId(int IdTipoTenencia);

        RespuestaCRUD Insertar(TipoTenenciaViviendaFinabece TipoTenencia);
        RespuestaCRUD Update(TipoTenenciaViviendaFinabece TipoTenencia);
        RespuestaCRUD Delete(decimal IdTipoTenencia, short IdUsuario);
    }
}
