using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaPaisData
    {
        IEnumerable<Pai> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaPai> ListadoPaisesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaPai ObtenerId(int IdConvocatoriaPais);
        RespuestaCRUD Insertar(ConvocatoriaPai areaestudio);
        RespuestaCRUD Update(ConvocatoriaPai areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaPais, short IdUsuario);
    }
}
