using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoSectorViviendaFinabeceData
    {
        IEnumerable<TipoSectorViviendaFinabece> Listado();

        IEnumerable<TipoSectorViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoSectorViviendaFinabece ObtenerId(int IdTipoParentesco);

        RespuestaCRUD Insertar(TipoSectorViviendaFinabece TipoParentesco);
        RespuestaCRUD Update(TipoSectorViviendaFinabece TipoParentesco);
        RespuestaCRUD Delete(decimal IdTipoParentesco, short IdUsuario);
    }
}
