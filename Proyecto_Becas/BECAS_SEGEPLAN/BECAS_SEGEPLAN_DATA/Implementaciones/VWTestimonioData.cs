using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using System.IO;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class VWTestimonioData: IVWTestimonioData 
    {
        private readonly ModelContext _appDbContext;

        public VWTestimonioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<VwTestimonio> Listado()
        {
            try
            {
                return _appDbContext.VwTestimonios.ToList().OrderBy(p => p.Nombre);
            }
            catch (Exception ex) 
            {
                File.WriteAllText(@"C:\temp\a.txt", ex.Message.ToString());
                return Enumerable.Empty<VwTestimonio>().ToList();
                
            }
            

        }

        public VwTestimonio ObtenerId(int IdTestimonio)
        {
            return _appDbContext.VwTestimonios.Where(p => p.Idtestimonio == IdTestimonio).First();
        }
    }
}
