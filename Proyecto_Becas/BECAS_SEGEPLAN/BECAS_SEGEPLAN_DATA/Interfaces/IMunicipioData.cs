using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IMunicipioData
    {
        IEnumerable<Municipio> Listado();
        Municipio ObtenerId(int IdMunicipio);
    }
}
