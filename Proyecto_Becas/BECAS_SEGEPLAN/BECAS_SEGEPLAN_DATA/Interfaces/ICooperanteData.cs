using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ICooperanteData
    {
        IEnumerable<Cooperante> Listado();
        Cooperante ObtenerId(int IdCooperante);

        RespuestaCRUD Insertar(Cooperante cooperante);
        RespuestaCRUD Update(Cooperante cooperante);
        RespuestaCRUD Delete(decimal IdCooperante,short IdUsuario);

    }
}
