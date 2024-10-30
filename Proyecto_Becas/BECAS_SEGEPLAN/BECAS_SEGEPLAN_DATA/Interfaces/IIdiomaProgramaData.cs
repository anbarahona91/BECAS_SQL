using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IIdiomaProgramaData
    {
        IEnumerable<IdiomaPrograma> Listado();
        IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria();
        IdiomaPrograma ObtenerId(int IdiomaPrograma);

        RespuestaCRUD Insertar(IdiomaPrograma areaestudio);
        RespuestaCRUD Update(IdiomaPrograma areaestudio);
        RespuestaCRUD Delete(decimal IdIdiomaPrograma, short IdUsuario);
    }
}
