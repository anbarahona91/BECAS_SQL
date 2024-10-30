using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoGastoEstudioFinabeceData : ITipoGastoEstudioFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoGastoEstudioFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoGastoEstudioFinabece> Listado()
        {

            return _appDbContext.TipoGastoEstudioFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoGastoEstudioFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoGastoEstudioFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoGastoEstudioFinabece ObtenerId(int IdTipoGastoEstudioFinabece)
        {
            return _appDbContext.TipoGastoEstudioFinabeces.Where(p => p.IdtipoGastoEstudio == IdTipoGastoEstudioFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoGastoEstudioFinabece TipoGastoEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoGastoEstudioFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoGastoEstudioFinabece.IdtipoGastoEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoGastoEstudioFinabece TipoGastoEstudioFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoGastoEstudioFinabece newReg = _appDbContext.TipoGastoEstudioFinabeces.Where(p => p.IdtipoGastoEstudio == TipoGastoEstudioFinabece.IdtipoGastoEstudio).First();
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
        public RespuestaCRUD Delete(decimal IdTipoGastoEstudioFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoGastoEstudioFinabece newReg = _appDbContext.TipoGastoEstudioFinabeces.Where(p => p.IdtipoGastoEstudio == IdTipoGastoEstudioFinabece).First();
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
