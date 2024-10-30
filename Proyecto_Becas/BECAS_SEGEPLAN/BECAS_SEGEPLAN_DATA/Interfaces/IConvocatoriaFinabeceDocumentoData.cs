using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaFinabeceDocumentoData
    {
        IEnumerable<ConvocatoriaFinabeceDocumento> ListadoAsociadoConvocatoria(decimal IdConvocatoria);

        IEnumerable<ConvocatoriaFinabeceDocumento> ListadoAsociadoConvocatoriaTipoDocumento(decimal IdConvocatoria, decimal IdParticipante ,decimal IdTipoDocumento);

        string ObtenerFotografiaVigente(decimal IdConvocatoria, decimal IdParticipante);
        ConvocatoriaFinabeceDocumento ObtenerId(int IdConvocatoriaFinabeceDocumentos);
        RespuestaCRUD Insertar(ConvocatoriaFinabeceDocumento documento);
        RespuestaCRUD Update(ConvocatoriaFinabeceDocumento documento);
        RespuestaCRUD Delete(decimal IdConvocatoriaFinabeceDocumentos, short IdUsuario);
    }
}
