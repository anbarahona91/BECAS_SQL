using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaProgramaEstudioData
    {
        IEnumerable<ConvocatoriaProgramaEstudio> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaProgramaEstudio ObtenerId(int IdConvocatoriaProgramaEstudios);
        RespuestaCRUD Insertar(ConvocatoriaProgramaEstudio areaestudio);
        RespuestaCRUD Update(ConvocatoriaProgramaEstudio areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaProgramaEstudios, short IdUsuario);
    }
}
