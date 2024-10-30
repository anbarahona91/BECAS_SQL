using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaBeneficioData
    {
        IEnumerable<Beneficio> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaBeneficio> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaBeneficio ObtenerId(int IdConvocatoriaBeneficios);
        RespuestaCRUD Insertar(ConvocatoriaBeneficio areaestudio);
        RespuestaCRUD Update(ConvocatoriaBeneficio areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaBeneficios, short IdUsuario);
    }
}
