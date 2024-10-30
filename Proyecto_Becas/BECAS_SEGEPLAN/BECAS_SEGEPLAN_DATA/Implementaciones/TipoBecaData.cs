using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoBecaData : ITipoBecaData
    {
        private readonly ModelContext _appDbContext;

        public TipoBecaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoBeca> Listado()
        {

            return _appDbContext.TipoBecas.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoBeca> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoBecas
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoBeca ObtenerId(int IdTipoBeca)
        {
            return _appDbContext.TipoBecas.Where(p => p.IdtipoBeca == IdTipoBeca).First();
        }

        public RespuestaCRUD Insertar(TipoBeca TipoBeca)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoBeca);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoBeca.IdtipoBeca;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoBeca TipoBeca)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoBeca newReg = _appDbContext.TipoBecas.Where(p => p.IdtipoBeca == TipoBeca.IdtipoBeca).First();
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
        public RespuestaCRUD Delete(decimal IdTipoBeca, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoBeca newReg = _appDbContext.TipoBecas.Where(p => p.IdtipoBeca == IdTipoBeca).First();
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
