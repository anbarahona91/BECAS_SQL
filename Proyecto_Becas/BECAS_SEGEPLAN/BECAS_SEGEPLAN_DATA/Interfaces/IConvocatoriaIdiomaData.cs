using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaIdiomaData
    {
        IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaIdioma> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaIdioma ObtenerId(int IdConvocatoriaIdiomas);
        RespuestaCRUD Insertar(ConvocatoriaIdioma areaestudio);
        RespuestaCRUD Update(ConvocatoriaIdioma areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaIdiomas, short IdUsuario);
    }
}
