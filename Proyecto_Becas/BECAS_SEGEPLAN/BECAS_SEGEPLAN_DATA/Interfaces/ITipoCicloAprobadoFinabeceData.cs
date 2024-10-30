using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoCicloAprobadoFinabeceData
    {
        IEnumerable<TipoCicloAprobadoFinabece> Listado();

        IEnumerable<TipoCicloAprobadoFinabece> ListadoAsociadoConvocatoria();
        TipoCicloAprobadoFinabece ObtenerId(int IdTipoCicloAprobadoFinabece);

        RespuestaCRUD Insertar(TipoCicloAprobadoFinabece TipoCicloAprobadoFinabece);
        RespuestaCRUD Update(TipoCicloAprobadoFinabece TipoCicloAprobadoFinabece);
        RespuestaCRUD Delete(decimal IdTipoCicloAprobadoFinabece, short IdUsuario);
    }
}
