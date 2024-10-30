using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoCaracteristicaViviendaFinabeceData : ITipoCaracteristicaViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoCaracteristicaViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoCaracteristicaViviendaFinabece> Listado()
        {

            return _appDbContext.TipoCaracteristicaViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoCaracteristicaViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoCaracteristicaViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoCaracteristicaViviendaFinabece ObtenerId(int IdTipoCaracteristicaViviendarFinabece)
        {
            return _appDbContext.TipoCaracteristicaViviendaFinabeces.Where(p => p.IdtipoCaracteristicaVivienda == IdTipoCaracteristicaViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoCaracteristicaViviendaFinabece TipoCaracteristicaViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoCaracteristicaViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoCaracteristicaViviendarFinabece.IdtipoCaracteristicaVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoCaracteristicaViviendaFinabece TipoCaracteristicaViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoCaracteristicaViviendaFinabece newReg = _appDbContext.TipoCaracteristicaViviendaFinabeces.Where(p => p.IdtipoCaracteristicaVivienda == TipoCaracteristicaViviendarFinabece.IdtipoCaracteristicaVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoCaracteristicaViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoCaracteristicaViviendaFinabece newReg = _appDbContext.TipoCaracteristicaViviendaFinabeces.Where(p => p.IdtipoCaracteristicaVivienda == IdTipoCaracteristicaViviendarFinabece).First();
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
