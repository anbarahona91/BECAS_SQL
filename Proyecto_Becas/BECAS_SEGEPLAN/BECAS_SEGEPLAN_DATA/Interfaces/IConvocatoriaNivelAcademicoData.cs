using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaNivelAcademicoData
    {
      
       IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaNivelAcademico> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaNivelAcademico ObtenerId(int IdConvocatoriaNivelAcademicos);
        RespuestaCRUD Insertar(ConvocatoriaNivelAcademico areaestudio);
        RespuestaCRUD Update(ConvocatoriaNivelAcademico areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaNivelAcademicos, short IdUsuario);

    }
}
