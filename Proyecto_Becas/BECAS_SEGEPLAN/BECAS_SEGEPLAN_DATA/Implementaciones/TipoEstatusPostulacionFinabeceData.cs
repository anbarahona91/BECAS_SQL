using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoEstatusPostulacionFinabeceData : ITipoEstatusPostulacionFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoEstatusPostulacionFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoEstatusPostulacionFinabece> Listado()
        {

            return _appDbContext.TipoEstatusPostulacionFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoEstatusPostulacionFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoEstatusPostulacionFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoEstatusPostulacionFinabece ObtenerId(int IdTipoEstatusPostulacionFinabece)
        {
            return _appDbContext.TipoEstatusPostulacionFinabeces.Where(p => p.IdtipoEstatusPostulacion == IdTipoEstatusPostulacionFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoEstatusPostulacionFinabece TipoEstatusPostulacionFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoEstatusPostulacionFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoEstatusPostulacionFinabece.IdtipoEstatusPostulacion;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoEstatusPostulacionFinabece TipoEstatusPostulacionFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoEstatusPostulacionFinabece newReg = _appDbContext.TipoEstatusPostulacionFinabeces.Where(p => p.IdtipoEstatusPostulacion == TipoEstatusPostulacionFinabece.IdtipoEstatusPostulacion).First();
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
        public RespuestaCRUD Delete(decimal IdTipoEstatusPostulacionFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoEstatusPostulacionFinabece newReg = _appDbContext.TipoEstatusPostulacionFinabeces.Where(p => p.IdtipoEstatusPostulacion == IdTipoEstatusPostulacionFinabece).First();
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
