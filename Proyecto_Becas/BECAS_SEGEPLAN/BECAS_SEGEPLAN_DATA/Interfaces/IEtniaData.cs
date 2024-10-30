using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IEtniaData
    {
        IEnumerable<Etnium> Listado();
        Etnium ObtenerId(int IdMunicipio);
    }
}
