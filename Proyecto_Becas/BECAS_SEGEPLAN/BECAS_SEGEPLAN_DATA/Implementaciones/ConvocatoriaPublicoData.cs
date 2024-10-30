using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaPublicoData : IConvocatoriaPublicoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaPublicoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaPublico> Listado()
        {

            return _appDbContext.ConvocatoriaPublicos.Where(p => p.AudEliminado == false).ToList();

        }

        public IEnumerable<Publico> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaPublicos
                         join p in _appDbContext.Publicos on a.Idpublico equals p.Idpublico 
                         where a.AudEliminado == false
                         && a.Idconvocatoria == IdConvocatoria
                         select p).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaPublico> ListadoPublicoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaPublicos
                         join p in _appDbContext.Publicos on a.Idpublico equals p.Idpublico
                         where a.AudEliminado == false
                         && a.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaPublico ObtenerId(int IdConvocatoriaPublico)
        {
            return _appDbContext.ConvocatoriaPublicos.Where(p => p.IdconocatoriaPublico == IdConvocatoriaPublico).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaPublico ConvocatoriaPublico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocatoriaPublico);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocatoriaPublico.IdconocatoriaPublico;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaPublico ConvocatoriaPublico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaPublico newReg = _appDbContext.ConvocatoriaPublicos.Where(p => p.IdconocatoriaPublico == ConvocatoriaPublico.IdconocatoriaPublico).First();
                _appDbContext.SaveChanges();
                crud.Resultado = true;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;
        }
        public RespuestaCRUD Delete(decimal IdConvocatoriaPublico, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaPublico newReg = _appDbContext.ConvocatoriaPublicos.Where(p => p.IdconocatoriaPublico == IdConvocatoriaPublico).First();
                newReg.AudEliminado = true;
                newReg.AudIdusuariomodificacion = IdUsuario;
                newReg.AudFechamodificacion = DateTime.Today;
                _appDbContext.SaveChanges();
                crud.Resultado = true;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }
            return crud;
        }
    }
}
