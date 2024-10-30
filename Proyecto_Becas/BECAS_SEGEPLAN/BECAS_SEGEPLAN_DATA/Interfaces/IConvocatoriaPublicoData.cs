using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaPublicoData
    {
        IEnumerable<ConvocatoriaPublico> Listado();

        IEnumerable<Publico> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaPublico> ListadoPublicoAsociadoConvocatoria(int IdConvocatoria);

        ConvocatoriaPublico ObtenerId(int IdConvocatoriaPublico);

        RespuestaCRUD Insertar(ConvocatoriaPublico ConvocatoriaPublico);
        RespuestaCRUD Update(ConvocatoriaPublico ConvocatoriaPublico);
        RespuestaCRUD Delete(decimal IdConvocatoriaPublico, short IdUsuario);
    }
}
