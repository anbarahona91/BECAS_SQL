using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IAreaEstudioData
    {
        IEnumerable<AreaEstudio> Listado();

        IEnumerable<AreaEstudio> ListadoAsociadoConvocatoria();
        AreaEstudio ObtenerId(int IdAreaEstudio);

        RespuestaCRUD Insertar(AreaEstudio areaestudio);
        RespuestaCRUD Update(AreaEstudio areaestudio);
        RespuestaCRUD Delete(decimal IdAreaEstudio, short IdUsuario);
    }
}
