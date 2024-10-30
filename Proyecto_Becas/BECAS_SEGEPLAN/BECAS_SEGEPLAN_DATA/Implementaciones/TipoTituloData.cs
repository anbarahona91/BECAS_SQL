using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoTituloData :ITipoTituloData
    {
        private readonly ModelContext _appDbContext;

        public TipoTituloData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoTitulo> Listado()
        {

            return _appDbContext.TipoTitulos.ToList().OrderBy(p => p.Nombre);

        }

        public TipoTitulo ObtenerId(int IdTipoTitulo)
        {
            return _appDbContext.TipoTitulos.Where(p => p.IdtipoTitulo == IdTipoTitulo).First();
        }
    }
}
