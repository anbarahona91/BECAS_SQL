using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IParticipanteData
    {
        IEnumerable<Participante> Listado();

        IEnumerable<Participante> ListadoAsociadoConvocatoria();
        Participante ObtenerId(decimal IdParticipante);
        Participante ObtenerCUI(string CUI);
        RespuestaCRUD Insertar(Participante Participante);
        RespuestaCRUD Update(Participante Participante);
        RespuestaCRUD Delete(decimal IdParticipante, short IdUsuario);
    }
}
