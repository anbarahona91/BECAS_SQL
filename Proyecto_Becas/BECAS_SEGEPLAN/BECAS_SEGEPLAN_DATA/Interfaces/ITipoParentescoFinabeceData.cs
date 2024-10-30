using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoParentescoFinabeceData
    {
        IEnumerable<TipoParentestoFinabece> Listado();

        IEnumerable<TipoParentestoFinabece> ListadoAsociadoConvocatoria();
        TipoParentestoFinabece ObtenerId(int IdTipoParentesco);

        RespuestaCRUD Insertar(TipoParentestoFinabece TipoParentesco);
        RespuestaCRUD Update(TipoParentestoFinabece TipoParentesco);
        RespuestaCRUD Delete(decimal IdTipoParentesco, short IdUsuario);
    }
}
