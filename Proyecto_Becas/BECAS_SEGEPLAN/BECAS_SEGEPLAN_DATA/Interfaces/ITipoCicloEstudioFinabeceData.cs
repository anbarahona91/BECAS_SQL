using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoCicloEstudioFinabeceData
    {
        IEnumerable<TipoCicloEstudioFinabece> Listado();

        IEnumerable<TipoCicloEstudioFinabece> ListadoAsociadoConvocatoria();
        TipoCicloEstudioFinabece ObtenerId(int IdTipoCicloEstudioFinabece);

        RespuestaCRUD Insertar(TipoCicloEstudioFinabece TipoCicloEstudioFinabece);
        RespuestaCRUD Update(TipoCicloEstudioFinabece TipoCicloEstudioFinabece);
        RespuestaCRUD Delete(decimal IdTipoCicloEstudioFinabece, short IdUsuario);
    }
}
