using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaIdiomaRequeridoData
    {
        IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria(int IdConvocatoria);

        IEnumerable<ConvocatoriaIdiomaRequerido> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaIdiomaRequerido ObtenerId(int IdConvocatoriaIdiomaRequeridos);
        RespuestaCRUD Insertar(ConvocatoriaIdiomaRequerido areaestudio);
        RespuestaCRUD Update(ConvocatoriaIdiomaRequerido areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaIdiomaRequeridos, short IdUsuario);
    }
}
