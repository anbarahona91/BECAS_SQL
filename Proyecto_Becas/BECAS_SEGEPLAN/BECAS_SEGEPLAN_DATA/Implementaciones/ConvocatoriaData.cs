using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public  class ConvocatoriaData : IConvocatoriaData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Convocatorium> Listado()
        {

            return _appDbContext.Convocatoria.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Convocatorium> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Convocatoria
                         //where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Convocatorium ObtenerId(decimal IdConvocatoria)
        {
            return _appDbContext.Convocatoria.Where(p => p.Idconvocatoria == IdConvocatoria).First();
        }

        public bool ConvocatoriaFinabece(decimal IdConvocatoria)
        {
            return (bool)_appDbContext.Convocatoria.Where(p => p.Idconvocatoria == IdConvocatoria).Select(p=> p.Finabece).FirstOrDefault();
        }

        public RespuestaCRUD Insertar(Convocatorium Convocatoria)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Convocatoria);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Convocatoria.Idconvocatoria;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(Convocatorium Convocatoria)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Convocatorium newReg = _appDbContext.Convocatoria.Where(p => p.Idconvocatoria == Convocatoria.Idconvocatoria).First();
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
        public RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Convocatorium newReg = _appDbContext.Convocatoria.Where(p => p.Idconvocatoria == IdConvocatoria).First();
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
