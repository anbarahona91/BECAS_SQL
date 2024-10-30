using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoViasAccesoViviendaFinabeceData : ITipoViasAccesoViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoViasAccesoViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoViasAccesoViviendaFinabece> Listado()
        {

            return _appDbContext.TipoViasAccesoViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoViasAccesoViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoViasAccesoViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoViasAccesoViviendaFinabece ObtenerId(int IdTipoViasAccesoViviendarFinabece)
        {
            return _appDbContext.TipoViasAccesoViviendaFinabeces.Where(p => p.IdtipoViasAccesoVivienda == IdTipoViasAccesoViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoViasAccesoViviendaFinabece TipoViasAccesoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoViasAccesoViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoViasAccesoViviendarFinabece.IdtipoViasAccesoVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoViasAccesoViviendaFinabece TipoViasAccesoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoViasAccesoViviendaFinabece newReg = _appDbContext.TipoViasAccesoViviendaFinabeces.Where(p => p.IdtipoViasAccesoVivienda == TipoViasAccesoViviendarFinabece.IdtipoViasAccesoVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoViasAccesoViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoViasAccesoViviendaFinabece newReg = _appDbContext.TipoViasAccesoViviendaFinabeces.Where(p => p.IdtipoViasAccesoVivienda == IdTipoViasAccesoViviendarFinabece).First();
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
