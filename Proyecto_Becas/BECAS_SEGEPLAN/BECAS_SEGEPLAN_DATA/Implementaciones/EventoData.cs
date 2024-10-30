using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class EventoData : IEventoData
    {
        private readonly ModelContext _modelDbContext;

        public EventoData(ModelContext appDbContext)
        {
            _modelDbContext = appDbContext;
        }

        public IEnumerable<Evento> ListadoEvento()
        {
            try
            {
                return _modelDbContext.Eventos.Where(p => p.Fechafin >= DateTime.Today).ToList();
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\temp\a.txt", ex.Message.ToString());
                return Enumerable.Empty<Evento>().ToList();

            }
            

        }

        public Evento ObtenerEventoId(int IdEvento)
        {
            return _modelDbContext.Eventos.Where(p => p.Idevento == IdEvento).First();
        }
    }
}
