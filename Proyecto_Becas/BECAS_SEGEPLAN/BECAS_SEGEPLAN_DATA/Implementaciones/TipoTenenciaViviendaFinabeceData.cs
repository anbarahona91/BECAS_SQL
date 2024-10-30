using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoTenenciaViviendaFinabeceData :ITipoTenenciaViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoTenenciaViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoTenenciaViviendaFinabece> Listado()
        {

            return _appDbContext.TipoTenenciaViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoTenenciaViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoTenenciaViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoTenenciaViviendaFinabece ObtenerId(int IdTipoTenenciaViviendarFinabece)
        {
            return _appDbContext.TipoTenenciaViviendaFinabeces.Where(p => p.IdtipoTenenciaVivienda == IdTipoTenenciaViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoTenenciaViviendaFinabece TipoTenenciaViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoTenenciaViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoTenenciaViviendarFinabece.IdtipoTenenciaVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoTenenciaViviendaFinabece TipoTenenciaViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoTenenciaViviendaFinabece newReg = _appDbContext.TipoTenenciaViviendaFinabeces.Where(p => p.IdtipoTenenciaVivienda == TipoTenenciaViviendarFinabece.IdtipoTenenciaVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoTenenciaViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoTenenciaViviendaFinabece newReg = _appDbContext.TipoTenenciaViviendaFinabeces.Where(p => p.IdtipoTenenciaVivienda == IdTipoTenenciaViviendarFinabece).First();
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
