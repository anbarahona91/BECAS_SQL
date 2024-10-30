using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoParentestoFinabeceData : ITipoParentescoFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoParentestoFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoParentestoFinabece> Listado()
        {

            return _appDbContext.TipoParentestoFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoParentestoFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoParentestoFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoParentestoFinabece ObtenerId(int IdTipoParentestoFinabece)
        {
            return _appDbContext.TipoParentestoFinabeces.Where(p => p.IdtipoParentesco == IdTipoParentestoFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoParentestoFinabece TipoParentestoFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoParentestoFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoParentestoFinabece.IdtipoParentesco;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoParentestoFinabece TipoParentestoFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoParentestoFinabece newReg = _appDbContext.TipoParentestoFinabeces.Where(p => p.IdtipoParentesco == TipoParentestoFinabece.IdtipoParentesco).First();
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
        public RespuestaCRUD Delete(decimal IdTipoParentestoFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoParentestoFinabece newReg = _appDbContext.TipoParentestoFinabeces.Where(p => p.IdtipoParentesco == IdTipoParentestoFinabece).First();
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
