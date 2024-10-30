using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class DiscapacidadData :IDiscapacidadData
    {
        private readonly ModelContext _appDbContext;

        public DiscapacidadData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Discapacidad> Listado()
        {

            return _appDbContext.Discapacidads.ToList().OrderBy(p => p.Nombre);

        }

        public Discapacidad ObtenerId(int IdDiscapacidad)
        {
            return _appDbContext.Discapacidads.Where(p => p.Iddiscapacidad == IdDiscapacidad).First();
        }
    }
}
