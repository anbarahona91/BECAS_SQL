using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoInstitucionEducativaData :ITipoInstitucionEducativaData
    {
        private readonly ModelContext _appDbContext;

        public TipoInstitucionEducativaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoInstitucionEducativa> Listado()
        {

            return _appDbContext.TipoInstitucionEducativas.ToList().OrderBy(p => p.Nombre);

        }

        public TipoInstitucionEducativa ObtenerId(int IdTipoInstitucionEducativa)
        {
            return _appDbContext.TipoInstitucionEducativas.Where(p => p.IdtipoInstitucionEducativa == IdTipoInstitucionEducativa).First();
        }
    }
}
