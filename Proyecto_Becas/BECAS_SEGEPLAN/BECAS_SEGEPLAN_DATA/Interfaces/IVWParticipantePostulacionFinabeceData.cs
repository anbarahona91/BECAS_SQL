using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IVWParticipantePostulacionFinabeceData
    {
        IEnumerable<VwParticipantePostulacionFinabece> Get(decimal IdConvocatoria);

    }
}
