using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoServicioMedicoViviendaFinabeceData
    {
        IEnumerable<TipoServicioMedicoViviendaFinabece> Listado();

        IEnumerable<TipoServicioMedicoViviendaFinabece> ListadoAsociadoConvocatoria();
        TipoServicioMedicoViviendaFinabece ObtenerId(int IdTipoServicioMedico);

        RespuestaCRUD Insertar(TipoServicioMedicoViviendaFinabece TipoServicioMedico);
        RespuestaCRUD Update(TipoServicioMedicoViviendaFinabece TipoServicioMedico);
        RespuestaCRUD Delete(decimal IdTipoServicioMedico, short IdUsuario);
    }
}
