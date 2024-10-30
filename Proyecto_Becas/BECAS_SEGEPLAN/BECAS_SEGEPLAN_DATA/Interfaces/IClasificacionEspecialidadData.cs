using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IClasificacionEspecialidadData
    {
        IEnumerable<ClasificacionEspecialidad> Listado();

        IEnumerable<ClasificacionEspecialidad> ListadoAsociadoConvocatoria();
        ClasificacionEspecialidad ObtenerId(int IdClasificacionEspecialidad);

        RespuestaCRUD Insertar(ClasificacionEspecialidad ClasificacionEspecialidad);
        RespuestaCRUD Update(ClasificacionEspecialidad ClasificacionEspecialidad);
        RespuestaCRUD Delete(decimal IdClasificacionEspecialidad, short IdUsuario);
    }
}
