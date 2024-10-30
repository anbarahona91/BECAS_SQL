using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IUniversidadData
    {
        IEnumerable<Universidad> Listado();

        IEnumerable<Universidad> ListadoAsociadoConvocatoria();
        Universidad ObtenerId(int IdUniversidad);

        RespuestaCRUD Insertar(Universidad Universidad);
        RespuestaCRUD Update(Universidad Universidad);
        RespuestaCRUD Delete(decimal IdUniversidad, short IdUsuario);
    }
}
