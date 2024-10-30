using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoParedViviendaFinabeceData
    {
        IEnumerable<TipoParedViviendaFinabece> Listado();

        IEnumerable<TipoParedViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoParedViviendaFinabece ObtenerId(int IdTipoParentesco);

        RespuestaCRUD Insertar(TipoParedViviendaFinabece TipoParentesco);
        RespuestaCRUD Update(TipoParedViviendaFinabece TipoParentesco);
        RespuestaCRUD Delete(decimal IdTipoParentesco, short IdUsuario);
    }
}
