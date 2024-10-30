using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IVWTestimonioData
    {
        IEnumerable<VwTestimonio> Listado();
        VwTestimonio ObtenerId(int IdTestimonio);
    }
}
