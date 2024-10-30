using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoEstatusPostulacionFinabeceData
    {
        IEnumerable<TipoEstatusPostulacionFinabece> Listado();

        IEnumerable<TipoEstatusPostulacionFinabece> ListadoAsociadoConvocatoria();
        TipoEstatusPostulacionFinabece ObtenerId(int IdTipoEstatusPostulacionFinabece);

        RespuestaCRUD Insertar(TipoEstatusPostulacionFinabece TipoEstatusPostulacionFinabece);
        RespuestaCRUD Update(TipoEstatusPostulacionFinabece TipoEstatusPostulacionFinabece);
        RespuestaCRUD Delete(decimal IdTipoEstatusPostulacionFinabece, short IdUsuario);
    }
}
