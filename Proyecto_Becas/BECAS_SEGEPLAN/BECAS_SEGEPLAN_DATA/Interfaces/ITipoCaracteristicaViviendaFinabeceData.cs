using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoCaracteristicaViviendaFinabeceData
    {
        IEnumerable<TipoCaracteristicaViviendaFinabece> Listado();

        IEnumerable<TipoCaracteristicaViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoCaracteristicaViviendaFinabece ObtenerId(int IdTipoParentesco);

        RespuestaCRUD Insertar(TipoCaracteristicaViviendaFinabece TipoParentesco);
        RespuestaCRUD Update(TipoCaracteristicaViviendaFinabece TipoParentesco);
        RespuestaCRUD Delete(decimal IdTipoParentesco, short IdUsuario);
    }
}
