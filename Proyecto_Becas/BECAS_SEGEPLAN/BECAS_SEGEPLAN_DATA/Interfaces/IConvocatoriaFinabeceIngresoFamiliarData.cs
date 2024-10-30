using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IConvocatoriaFinabeceIngresoFamiliarData
    {
        IEnumerable<ConvocatoriaFinabeceIngresoFamiliar> Listado();

        IEnumerable<ConvocatoriaFinabeceIngresoFamiliar> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria);

        bool ExisteConvocatoriaFinabeceIngresoFamiliar(decimal IdParticipante, decimal IdConvocatoria);

        decimal ObtenerIdConvocatoriaFinabeceIngresoFamiliar(decimal IdParticipante, decimal IdConvocatoria);

        decimal ObtenerTotalIngresoFamiliar(decimal IdParticipante,decimal IdConvocatoria);
        ConvocatoriaFinabeceIngresoFamiliar ObtenerId(decimal IdAreaEstudio);
        ConvocatoriaFinabeceIngresoFamiliar ObtenerId(decimal IdParticipante, decimal IdConvocatoria);

        
        RespuestaCRUD Insertar(ConvocatoriaFinabeceIngresoFamiliar ingreso);
        RespuestaCRUD Update(ConvocatoriaFinabeceIngresoFamiliar ingreso);
        RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario);
    }
}
