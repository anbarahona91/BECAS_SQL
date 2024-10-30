using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface INivelAcademicoData
    {
        IEnumerable<NivelAcademico> Listado();

        IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria();
        NivelAcademico ObtenerId(int IdNivelAcademico);

        RespuestaCRUD Insertar(NivelAcademico areaestudio);
        RespuestaCRUD Update(NivelAcademico areaestudio);
        RespuestaCRUD Delete(decimal IdNivelAcademico, short IdUsuario);
    }
}
