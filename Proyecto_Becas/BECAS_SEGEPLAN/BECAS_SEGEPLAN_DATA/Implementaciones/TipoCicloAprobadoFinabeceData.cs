using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoCicloAprobadoFinabeceData : ITipoCicloAprobadoFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoCicloAprobadoFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoCicloAprobadoFinabece> Listado()
        {

            return _appDbContext.TipoCicloAprobadoFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoCicloAprobadoFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoCicloAprobadoFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoCicloAprobadoFinabece ObtenerId(int IdTipoCicloAprobadoFinabece)
        {
            return _appDbContext.TipoCicloAprobadoFinabeces.Where(p => p.IdtipoCicloAprobado == IdTipoCicloAprobadoFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoCicloAprobadoFinabece TipoCicloAprobadoFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoCicloAprobadoFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoCicloAprobadoFinabece.IdtipoCicloAprobado;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoCicloAprobadoFinabece TipoCicloAprobadoFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoCicloAprobadoFinabece newReg = _appDbContext.TipoCicloAprobadoFinabeces.Where(p => p.IdtipoCicloAprobado == TipoCicloAprobadoFinabece.IdtipoCicloAprobado).First();
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
        public RespuestaCRUD Delete(decimal IdTipoCicloAprobadoFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoCicloAprobadoFinabece newReg = _appDbContext.TipoCicloAprobadoFinabeces.Where(p => p.IdtipoCicloAprobado == IdTipoCicloAprobadoFinabece).First();
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
