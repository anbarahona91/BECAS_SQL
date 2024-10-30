using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoPlanEstudioFinabeceData
    {
        IEnumerable<TipoPlanEstudioFinabece> Listado();

        IEnumerable<TipoPlanEstudioFinabece> ListadoAsociadoConvocatoria();
        TipoPlanEstudioFinabece ObtenerId(int IdTipoPlanEstudioFinabece);

        RespuestaCRUD Insertar(TipoPlanEstudioFinabece TipoPlanEstudioFinabece);
        RespuestaCRUD Update(TipoPlanEstudioFinabece TipoPlanEstudioFinabece);
        RespuestaCRUD Delete(decimal IdTipoPlanEstudioFinabece, short IdUsuario);
    }
}
