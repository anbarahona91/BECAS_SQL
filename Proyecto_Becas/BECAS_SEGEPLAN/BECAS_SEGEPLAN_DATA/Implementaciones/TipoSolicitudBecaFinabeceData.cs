using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoSolicitudBecaFinabeceData :ITipoSolicitudBecaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoSolicitudBecaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoSolicitudBecaFinabece> Listado()
        {

            return _appDbContext.TipoSolicitudBecaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoSolicitudBecaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoSolicitudBecaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoSolicitudBecaFinabece ObtenerId(int IdTipoSolicitudBecaFinabece)
        {
            return _appDbContext.TipoSolicitudBecaFinabeces.Where(p => p.IdtipoSolicitudBeca == IdTipoSolicitudBecaFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoSolicitudBecaFinabece TipoSolicitudBecaFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoSolicitudBecaFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoSolicitudBecaFinabece.IdtipoSolicitudBeca;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoSolicitudBecaFinabece TipoSolicitudBecaFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoSolicitudBecaFinabece newReg = _appDbContext.TipoSolicitudBecaFinabeces.Where(p => p.IdtipoSolicitudBeca == TipoSolicitudBecaFinabece.IdtipoSolicitudBeca).First();
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
        public RespuestaCRUD Delete(decimal IdTipoSolicitudBecaFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoSolicitudBecaFinabece newReg = _appDbContext.TipoSolicitudBecaFinabeces.Where(p => p.IdtipoSolicitudBeca == IdTipoSolicitudBecaFinabece).First();
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
