using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class MunicipioData : IMunicipioData
    {
        private readonly ModelContext _appDbContext;

        public MunicipioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Municipio> Listado()
        {

            return _appDbContext.Municipios.ToList().OrderBy(p => p.Nombre);

        }

        public Municipio ObtenerId(int IdMunicipio)
        {
            return _appDbContext.Municipios.Where(p => p.Idmunicipio == IdMunicipio).First();
        }
    }
}
