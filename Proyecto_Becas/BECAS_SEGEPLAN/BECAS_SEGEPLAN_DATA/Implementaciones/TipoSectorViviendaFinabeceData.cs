using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoSectorViviendaFinabeceData : ITipoSectorViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoSectorViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoSectorViviendaFinabece> Listado()
        {

            return _appDbContext.TipoSectorViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoSectorViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoSectorViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoSectorViviendaFinabece ObtenerId(int IdTipoSectorViviendarFinabece)
        {
            return _appDbContext.TipoSectorViviendaFinabeces.Where(p => p.IdtipoSectorVivienda == IdTipoSectorViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoSectorViviendaFinabece TipoSectorViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoSectorViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoSectorViviendarFinabece.IdtipoSectorVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoSectorViviendaFinabece TipoSectorViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoSectorViviendaFinabece newReg = _appDbContext.TipoSectorViviendaFinabeces.Where(p => p.IdtipoSectorVivienda == TipoSectorViviendarFinabece.IdtipoSectorVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoSectorViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoSectorViviendaFinabece newReg = _appDbContext.TipoSectorViviendaFinabeces.Where(p => p.IdtipoSectorVivienda == IdTipoSectorViviendarFinabece).First();
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
