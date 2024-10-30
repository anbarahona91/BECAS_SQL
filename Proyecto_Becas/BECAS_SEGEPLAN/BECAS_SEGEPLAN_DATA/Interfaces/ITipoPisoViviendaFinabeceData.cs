using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;


namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoPisoViviendaFinabeceData
    {
        IEnumerable<TipoPisoViviendaFinabece> Listado();

        IEnumerable<TipoPisoViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoPisoViviendaFinabece ObtenerId(int IdTipoPiso);

        RespuestaCRUD Insertar(TipoPisoViviendaFinabece TipoPiso);
        RespuestaCRUD Update(TipoPisoViviendaFinabece TipoPiso);
        RespuestaCRUD Delete(decimal IdTipoPiso, short IdUsuario);
    }
}
