using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoTechoViviendaFinabeceData : ITipoTechoViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoTechoViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoTechoViviendaFinabece> Listado()
        {

            return _appDbContext.TipoTechoViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoTechoViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoTechoViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoTechoViviendaFinabece ObtenerId(int IdTipoTechoViviendarFinabece)
        {
            return _appDbContext.TipoTechoViviendaFinabeces.Where(p => p.IdtipoTechoVivienda == IdTipoTechoViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoTechoViviendaFinabece TipoTechoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoTechoViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoTechoViviendarFinabece.IdtipoTechoVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoTechoViviendaFinabece TipoTechoViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoTechoViviendaFinabece newReg = _appDbContext.TipoTechoViviendaFinabeces.Where(p => p.IdtipoTechoVivienda == TipoTechoViviendarFinabece.IdtipoTechoVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoTechoViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoTechoViviendaFinabece newReg = _appDbContext.TipoTechoViviendaFinabeces.Where(p => p.IdtipoTechoVivienda == IdTipoTechoViviendarFinabece).First();
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
