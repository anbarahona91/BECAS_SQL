using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoBecaData
    {
        IEnumerable<TipoBeca> Listado();

        IEnumerable<TipoBeca> ListadoAsociadoConvocatoria();
        TipoBeca ObtenerId(int IdTipoBeca);

        RespuestaCRUD Insertar(TipoBeca TipoBeca);
        RespuestaCRUD Update(TipoBeca TipoBeca);
        RespuestaCRUD Delete(decimal IdTipoBeca, short IdUsuario);
    }
}
