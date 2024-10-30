using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaNivelAcademicoRequeridoData
    {
        IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaNivelAcademicoRequerido> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaNivelAcademicoRequerido ObtenerId(int IdConvocatoriaNivelAcademicoRequerido);
        RespuestaCRUD Insertar(ConvocatoriaNivelAcademicoRequerido areaestudio);
        RespuestaCRUD Update(ConvocatoriaNivelAcademicoRequerido areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaNivelAcademicoRequerido, short IdUsuario);
    }
}
