using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoCarreraData :ITipoCarreraData
    {
        private readonly ModelContext _appDbContext;

        public TipoCarreraData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoCarrera> Listado()
        {

            return _appDbContext.TipoCarreras.ToList().OrderBy(p => p.Nombre);

        }

        public TipoCarrera ObtenerId(int IdTipoCarrera)
        {
            return _appDbContext.TipoCarreras.Where(p => p.IdtipoCarrera == IdTipoCarrera).First();
        }
    }
}
