using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoGastoEstudioFinabeceData
    {
        IEnumerable<TipoGastoEstudioFinabece> Listado();

        IEnumerable<TipoGastoEstudioFinabece> ListadoAsociadoConvocatoria();
        TipoGastoEstudioFinabece ObtenerId(int IdTipoGastoEstudio);

        RespuestaCRUD Insertar(TipoGastoEstudioFinabece TipoGastoEstudio);
        RespuestaCRUD Update(TipoGastoEstudioFinabece TipoGastoEstudio);
        RespuestaCRUD Delete(decimal IdTipoGastoEstudio, short IdUsuario);
    }
}
