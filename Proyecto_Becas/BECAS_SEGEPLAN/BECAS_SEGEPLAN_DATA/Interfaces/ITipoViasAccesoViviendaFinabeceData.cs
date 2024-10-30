using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoViasAccesoViviendaFinabeceData
    {
        IEnumerable<TipoViasAccesoViviendaFinabece> Listado();

        IEnumerable<TipoViasAccesoViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoViasAccesoViviendaFinabece ObtenerId(int IdTipoViasAcceso);

        RespuestaCRUD Insertar(TipoViasAccesoViviendaFinabece TipoViasAcceso);
        RespuestaCRUD Update(TipoViasAccesoViviendaFinabece TipoViasAcceso);
        RespuestaCRUD Delete(decimal IdTipoViasAcceso, short IdUsuario);
    }
}
