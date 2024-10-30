using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoPlanEstudioFinabeceData : ITipoPlanEstudioFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoPlanEstudioFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoPlanEstudioFinabece> Listado()
        {

            return _appDbContext.TipoPlanEstudioFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoPlanEstudioFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoPlanEstudioFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoPlanEstudioFinabece ObtenerId(int IdTipoPlanEstudioFinabece)
        {
            return _appDbContext.TipoPlanEstudioFinabeces.Where(p => p.IdtipoPlanEstudio == IdTipoPlanEstudioFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoPlanEstudioFinabece TipoPlanEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoPlanEstudioFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoPlanEstudioFinabece.IdtipoPlanEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoPlanEstudioFinabece TipoPlanEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoPlanEstudioFinabece newReg = _appDbContext.TipoPlanEstudioFinabeces.Where(p => p.IdtipoPlanEstudio == TipoPlanEstudioFinabece.IdtipoPlanEstudio).First();
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
        public RespuestaCRUD Delete(decimal IdTipoPlanEstudioFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoPlanEstudioFinabece newReg = _appDbContext.TipoPlanEstudioFinabeces.Where(p => p.IdtipoPlanEstudio == IdTipoPlanEstudioFinabece).First();
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
