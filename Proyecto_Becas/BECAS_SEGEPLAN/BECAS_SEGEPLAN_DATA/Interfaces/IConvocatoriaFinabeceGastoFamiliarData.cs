using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaFinabeceGastoFamiliarData
    {
        IEnumerable<ConvocatoriaFinabeceGastoFamiliar> Listado();

        IEnumerable<ConvocatoriaFinabeceGastoFamiliar> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria);

        bool ExisteConvocatoriaFinabeceGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria);

        decimal ObtenerIdConvocatoriaFinabeceGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria);

        decimal ObtenerTotalGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria);
        ConvocatoriaFinabeceGastoFamiliar ObtenerId(decimal IdAreaEstudio);
        ConvocatoriaFinabeceGastoFamiliar ObtenerId(decimal IdParticipante, decimal IdConvocatoria);

        RespuestaCRUD CompletarTipoGasto(decimal IdParticipante, decimal IdConvocatoria);
        RespuestaCRUD Insertar(ConvocatoriaFinabeceGastoFamiliar Gasto);
        RespuestaCRUD Update(ConvocatoriaFinabeceGastoFamiliar Gasto);
        RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario);
    }
}
