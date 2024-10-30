using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ISubareaEstudioData
    {
        IEnumerable<SubareaEstudio> Listado();

        IEnumerable<SubareaEstudio> ListadoAsociadoConvocatoria();
        SubareaEstudio ObtenerId(int IdSubareaEstudio);

        RespuestaCRUD Insertar(SubareaEstudio Subareaestudio);
        RespuestaCRUD Update(SubareaEstudio Subareaestudio);
        RespuestaCRUD Delete(decimal IdSubareaEstudio, short IdUsuario);
    }
}
