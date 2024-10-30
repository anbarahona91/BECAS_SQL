using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class VWProgramaConvocatoriaData: IVWProgramaConvocatoriaData
    {
        private readonly ModelContext _appDbContext;

        public VWProgramaConvocatoriaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<VwProgramaConvocatorium> Listado()
        {
            return _appDbContext.VwProgramaConvocatoria.ToList().OrderBy(p => p.NombreConvocatoria);
        }
        public VwProgramaConvocatorium ObtenerId(int IdConvocatoria)
        {
            return _appDbContext.VwProgramaConvocatoria.Where(p => p.Idconvocatoria == IdConvocatoria).First();
        }
    }
}
