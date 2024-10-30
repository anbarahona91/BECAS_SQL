using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class PublicoData : IPublicoData
    {
        private readonly ModelContext _appDbContext;

        public PublicoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Publico> Listado()
        {

            return _appDbContext.Publicos.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Publico> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Publicos
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Publico ObtenerId(int IdPublico)
        {
            return _appDbContext.Publicos.Where(p => p.Idpublico == IdPublico).First();
        }

        public RespuestaCRUD Insertar(Publico Publico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Publico);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Publico.Idpublico;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(Publico Publico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Publico newReg = _appDbContext.Publicos.Where(p => p.Idpublico == Publico.Idpublico).First();
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
        public RespuestaCRUD Delete(decimal IdPublico, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Publico newReg = _appDbContext.Publicos.Where(p => p.Idpublico == IdPublico).First();
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
