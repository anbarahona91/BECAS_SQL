using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoPisoViviendaFinabeceData :ITipoPisoViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoPisoViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoPisoViviendaFinabece> Listado()
        {

            return _appDbContext.TipoPisoViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoPisoViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoPisoViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoPisoViviendaFinabece ObtenerId(int IdTipoPisoViviendarFinabece)
        {
            return _appDbContext.TipoPisoViviendaFinabeces.Where(p => p.IdtipoPisoVivienda == IdTipoPisoViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoPisoViviendaFinabece TipoPisoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoPisoViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoPisoViviendarFinabece.IdtipoPisoVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoPisoViviendaFinabece TipoPisoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoPisoViviendaFinabece newReg = _appDbContext.TipoPisoViviendaFinabeces.Where(p => p.IdtipoPisoVivienda == TipoPisoViviendarFinabece.IdtipoPisoVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoPisoViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoPisoViviendaFinabece newReg = _appDbContext.TipoPisoViviendaFinabeces.Where(p => p.IdtipoPisoVivienda == IdTipoPisoViviendarFinabece).First();
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
