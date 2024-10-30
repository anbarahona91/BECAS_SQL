using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaFinabeceTipoGastoEstudioData
    {
        IEnumerable<ConvocatoriaFinabeceTipoGastoEstudio> Listado();

        IEnumerable<ConvocatoriaFinabeceTipoGastoEstudio> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria);

        bool ExisteConvocatoriaFinabeceTipoGastoEstudio(decimal IdParticipante, decimal IdConvocatoria);

        decimal ObtenerTotalGastoEstudio(decimal IdParticipante, decimal IdConvocatoria);
        decimal ObtenerIdConvocatoriaFinabeceTipoGastoEstudio(decimal IdParticipante, decimal IdConvocatoria);
        ConvocatoriaFinabeceTipoGastoEstudio ObtenerId(decimal IdAreaEstudio);
        ConvocatoriaFinabeceTipoGastoEstudio ObtenerId(decimal IdParticipante, decimal IdConvocatoria);

        RespuestaCRUD CompletarTipoGasto(decimal IdParticipante, decimal IdConvocatoria);
        RespuestaCRUD Insertar(ConvocatoriaFinabeceTipoGastoEstudio areaestudio);
        RespuestaCRUD Update(ConvocatoriaFinabeceTipoGastoEstudio areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario);
    }
}
