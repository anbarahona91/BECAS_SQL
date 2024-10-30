using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoServicioMedicoViviendaFinabeceData :ITipoServicioMedicoViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoServicioMedicoViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoServicioMedicoViviendaFinabece> Listado()
        {

            return _appDbContext.TipoServicioMedicoViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoServicioMedicoViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoServicioMedicoViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoServicioMedicoViviendaFinabece ObtenerId(int IdTipoServicioMedicoViviendarFinabece)
        {
            return _appDbContext.TipoServicioMedicoViviendaFinabeces.Where(p => p.IdtipoServicioMedicoVivienda == IdTipoServicioMedicoViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoServicioMedicoViviendaFinabece TipoServicioMedicoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoServicioMedicoViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoServicioMedicoViviendarFinabece.IdtipoServicioMedicoVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoServicioMedicoViviendaFinabece TipoServicioMedicoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoServicioMedicoViviendaFinabece newReg = _appDbContext.TipoServicioMedicoViviendaFinabeces.Where(p => p.IdtipoServicioMedicoVivienda == TipoServicioMedicoViviendarFinabece.IdtipoServicioMedicoVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoServicioMedicoViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoServicioMedicoViviendaFinabece newReg = _appDbContext.TipoServicioMedicoViviendaFinabeces.Where(p => p.IdtipoServicioMedicoVivienda == IdTipoServicioMedicoViviendarFinabece).First();
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
