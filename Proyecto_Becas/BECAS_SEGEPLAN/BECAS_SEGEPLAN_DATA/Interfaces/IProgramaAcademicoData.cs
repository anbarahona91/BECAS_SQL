using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IProgramaAcademicoData
    {
        IEnumerable<ProgramaAcademico> Listado();

        IEnumerable<ProgramaAcademico> ListadoAsociadoConvocatoria();
        ProgramaAcademico ObtenerId(int IdProgramaAcademico);

        RespuestaCRUD Insertar(ProgramaAcademico ProgramaAcademico);
        RespuestaCRUD Update(ProgramaAcademico ProgramaAcademico);
        RespuestaCRUD Delete(decimal IdProgramaAcademico, short IdUsuario);
    }
}
