using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IModalidadProgramaData
    {
        IEnumerable<ModalidadPrograma> Listado();

        IEnumerable<ModalidadPrograma> ListadoAsociadoConvocatoria();
        ModalidadPrograma ObtenerId(int IdModalidadPrograma);

        RespuestaCRUD Insertar(ModalidadPrograma ModalidadPrograma);
        RespuestaCRUD Update(ModalidadPrograma ModalidadPrograma);
        RespuestaCRUD Delete(decimal IdModalidadPrograma, short IdUsuario);
    }
}
