using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaParticipanteData
    {
        IEnumerable<ConvocatoriaParticipante> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaParticipante ObtenerId(decimal IdConvocatoriaParticipantes);
        RespuestaCRUD Insertar(ConvocatoriaParticipante areaestudio);
        RespuestaCRUD Update(ConvocatoriaParticipante areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaParticipante, short IdUsuario);
    }
}
