using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class VWParticipantePostulacionFinabeceData : IVWParticipantePostulacionFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public VWParticipantePostulacionFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<VwParticipantePostulacionFinabece> Get(decimal IdConvocatoria)
        {
            var query = (from a in _appDbContext.VwParticipantePostulacionFinabeces
                         where (a.Idconvocatoria == IdConvocatoria)
                         select a);

            return query.ToList();
        }
    }
}
