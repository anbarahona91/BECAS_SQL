using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaDocumentoData
    {
        

        IEnumerable<ConvocatoriaDocumento> ListadoAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaDocumento ObtenerId(int IdConvocatoriaDocumentos);
        RespuestaCRUD Insertar(ConvocatoriaDocumento areaestudio);
        RespuestaCRUD Update(ConvocatoriaDocumento areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaDocumentos, short IdUsuario);
    }
}
