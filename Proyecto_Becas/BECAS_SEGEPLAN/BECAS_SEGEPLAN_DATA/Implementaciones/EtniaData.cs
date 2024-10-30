using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class EtniaData : IEtniaData
    {
        private readonly ModelContext _appDbContext;

        public EtniaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Etnium> Listado()
        {

            return _appDbContext.Etnia.ToList().OrderBy(p => p.Nombre);

        }

        public Etnium ObtenerId(int IdEtnia)
        {
            return _appDbContext.Etnia.Where(p => p.Idetnia == IdEtnia).First();
        }
    }
}
