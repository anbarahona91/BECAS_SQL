using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaFinabeceData
    {
        IEnumerable<ConvocatoriaFinabece> Listado();

        IEnumerable<ConvocatoriaFinabece> ListadoAsociadoConvocatoria();

        bool ExisteConvocatoriaFinabece(decimal IdParticipante,decimal IdConvocatoria);

        decimal ObtenerIdConvocatoriaFinabece(decimal IdParticipante, decimal IdConvocatoria);
        ConvocatoriaFinabece ObtenerId(decimal IdAreaEstudio);
        ConvocatoriaFinabece ObtenerId(decimal IdParticipante, decimal IdConvocatoria);

        RespuestaCRUD Insertar(ConvocatoriaFinabece areaestudio);
        RespuestaCRUD Update(ConvocatoriaFinabece areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario);
    }
}
