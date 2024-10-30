using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaEnlaceData
    {
        IEnumerable<ConvocatoriaEnlace> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria);
        ConvocatoriaEnlace ObtenerId(int IdConvocatoriaEnlaces);
        RespuestaCRUD Insertar(ConvocatoriaEnlace areaestudio);
        RespuestaCRUD Update(ConvocatoriaEnlace areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoriaEnlaces, short IdUsuario);
    }
}
