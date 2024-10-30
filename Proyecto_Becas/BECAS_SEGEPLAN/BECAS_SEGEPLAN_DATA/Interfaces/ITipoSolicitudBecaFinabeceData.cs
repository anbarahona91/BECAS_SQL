using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoSolicitudBecaFinabeceData
    {
        IEnumerable<TipoSolicitudBecaFinabece> Listado();

        IEnumerable<TipoSolicitudBecaFinabece> ListadoAsociadoConvocatoria();
        TipoSolicitudBecaFinabece ObtenerId(int IdTipoSolicitudBecaFinabece);

        RespuestaCRUD Insertar(TipoSolicitudBecaFinabece TipoSolicitudBecaFinabece);
        RespuestaCRUD Update(TipoSolicitudBecaFinabece TipoSolicitudBecaFinabece);
        RespuestaCRUD Delete(decimal IdTipoSolicitudBecaFinabece, short IdUsuario);
    }
}
