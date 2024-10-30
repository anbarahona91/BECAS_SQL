using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoTechoViviendaFinabeceData
    {
        IEnumerable<TipoTechoViviendaFinabece> Listado();

        IEnumerable<TipoTechoViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoTechoViviendaFinabece ObtenerId(int IdTipoTecho);

        RespuestaCRUD Insertar(TipoTechoViviendaFinabece TipoTecho);
        RespuestaCRUD Update(TipoTechoViviendaFinabece TipoTecho);
        RespuestaCRUD Delete(decimal IdTipoTecho, short IdUsuario);
    }
}
