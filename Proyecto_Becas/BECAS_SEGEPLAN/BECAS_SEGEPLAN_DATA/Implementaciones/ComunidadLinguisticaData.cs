using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ComunidadLinguisticaData :IComunidadLinguisticaData
    {
        private readonly ModelContext _appDbContext;

        public ComunidadLinguisticaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ComunidadLinguistica> Listado()
        {

            return _appDbContext.ComunidadLinguisticas.ToList().OrderBy(p => p.Nombre);

        }

        public ComunidadLinguistica ObtenerId(int IdComunidadLinguistica)
        {
            return _appDbContext.ComunidadLinguisticas.Where(p => p.IdcomunidadLinguistica == IdComunidadLinguistica).First();
        }
    }
}
