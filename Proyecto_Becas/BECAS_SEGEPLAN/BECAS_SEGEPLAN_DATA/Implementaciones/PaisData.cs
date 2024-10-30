using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class PaisData : IPaisData
    {
        private readonly ModelContext _appDbContext;

        public PaisData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pai> Listado()
        {

            return _appDbContext.Pais.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Pai> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Pais
                         join vc in _appDbContext.VwConvocatoriaFiltros on a.Idpais equals vc.Idpais
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Pai ObtenerId(int IdPais)
        {
            return _appDbContext.Pais.Where(p => p.Idpais == IdPais).First();
        }
    }
}
