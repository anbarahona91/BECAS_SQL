using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IPublicoData
    {
        IEnumerable<Publico> Listado();

        IEnumerable<Publico> ListadoAsociadoConvocatoria();
        Publico ObtenerId(int IdPublico);

        RespuestaCRUD Insertar(Publico Publico);
        RespuestaCRUD Update(Publico Publico);
        RespuestaCRUD Delete(decimal IdPublico, short IdUsuario);
    }
}
