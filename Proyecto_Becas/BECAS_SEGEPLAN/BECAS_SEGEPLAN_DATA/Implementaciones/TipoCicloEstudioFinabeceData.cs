using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoCicloEstudioFinabeceData : ITipoCicloEstudioFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoCicloEstudioFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoCicloEstudioFinabece> Listado()
        {

            return _appDbContext.TipoCicloEstudioFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoCicloEstudioFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoCicloEstudioFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoCicloEstudioFinabece ObtenerId(int IdTipoCicloEstudioFinabece)
        {
            return _appDbContext.TipoCicloEstudioFinabeces.Where(p => p.IdtipoCicloEstudio == IdTipoCicloEstudioFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoCicloEstudioFinabece TipoCicloEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoCicloEstudioFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoCicloEstudioFinabece.IdtipoCicloEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoCicloEstudioFinabece TipoCicloEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoCicloEstudioFinabece newReg = _appDbContext.TipoCicloEstudioFinabeces.Where(p => p.IdtipoCicloEstudio == TipoCicloEstudioFinabece.IdtipoCicloEstudio).First();
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
        public RespuestaCRUD Delete(decimal IdTipoCicloEstudioFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoCicloEstudioFinabece newReg = _appDbContext.TipoCicloEstudioFinabeces.Where(p => p.IdtipoCicloEstudio == IdTipoCicloEstudioFinabece).First();
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
