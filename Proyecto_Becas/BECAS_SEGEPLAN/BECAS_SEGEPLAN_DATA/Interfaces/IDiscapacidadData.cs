using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IDiscapacidadData
    {
        IEnumerable<Discapacidad> Listado();
        Discapacidad ObtenerId(int Id);
    }
}
