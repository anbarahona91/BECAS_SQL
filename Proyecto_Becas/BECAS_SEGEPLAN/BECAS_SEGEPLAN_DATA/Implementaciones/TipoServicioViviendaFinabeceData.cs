using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoServicioViviendaFinabeceData :ITipoServicioViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoServicioViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoServicioViviendaFinabece> Listado()
        {

            return _appDbContext.TipoServicioViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoServicioViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoServicioViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoServicioViviendaFinabece ObtenerId(int IdTipoServicioViviendarFinabece)
        {
            return _appDbContext.TipoServicioViviendaFinabeces.Where(p => p.IdtipoServicioVivienda == IdTipoServicioViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoServicioViviendaFinabece TipoServicioViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoServicioViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoServicioViviendarFinabece.IdtipoServicioVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoServicioViviendaFinabece TipoServicioViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoServicioViviendaFinabece newReg = _appDbContext.TipoServicioViviendaFinabeces.Where(p => p.IdtipoServicioVivienda == TipoServicioViviendarFinabece.IdtipoServicioVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoServicioViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoServicioViviendaFinabece newReg = _appDbContext.TipoServicioViviendaFinabeces.Where(p => p.IdtipoServicioVivienda == IdTipoServicioViviendarFinabece).First();
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
