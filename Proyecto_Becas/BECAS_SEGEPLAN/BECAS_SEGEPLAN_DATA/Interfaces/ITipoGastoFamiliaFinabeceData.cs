using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoGastoFamiliaFinabeceData
    {
        IEnumerable<TipoGastoFamiliaFinabece> Listado();

        IEnumerable<TipoGastoFamiliaFinabece> ListadoAsociadoConvocatoria();
        TipoGastoFamiliaFinabece ObtenerId(int IdTipoParentesco);

        RespuestaCRUD Insertar(TipoGastoFamiliaFinabece TipoParentesco);
        RespuestaCRUD Update(TipoGastoFamiliaFinabece TipoParentesco);
        RespuestaCRUD Delete(decimal IdTipoParentesco, short IdUsuario);
    }
}
