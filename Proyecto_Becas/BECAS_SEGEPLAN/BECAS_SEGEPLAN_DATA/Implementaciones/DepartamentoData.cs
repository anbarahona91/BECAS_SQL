using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class DepartamentoData : IDepartamentoData
    {
        private readonly ModelContext _appDbContext;

        public DepartamentoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Departamento> Listado()
        {
            
                return _appDbContext.Departamentos.ToList().OrderBy(p=> p.Nombre);
            
        }

        public Departamento ObtenerId(int IdDepartamento)
        {
            return _appDbContext.Departamentos.Where(p => p.Iddepartamento == IdDepartamento).First();
        }

    }
}
