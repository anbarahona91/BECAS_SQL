using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IDepartamentoData
    {
        IEnumerable<Departamento> Listado();
        Departamento ObtenerId(int IdDepartamento);
    }
}
