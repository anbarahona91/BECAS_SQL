using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoGastoFamiliaFinabeceData: ITipoGastoFamiliaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoGastoFamiliaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoGastoFamiliaFinabece> Listado()
        {

            return _appDbContext.TipoGastoFamiliaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoGastoFamiliaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoGastoFamiliaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoGastoFamiliaFinabece ObtenerId(int IdTipoGastoFamiliarFinabece)
        {
            return _appDbContext.TipoGastoFamiliaFinabeces.Where(p => p.IdtipoGastoFamilia == IdTipoGastoFamiliarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoGastoFamiliaFinabece TipoGastoFamiliarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoGastoFamiliarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoGastoFamiliarFinabece.IdtipoGastoFamilia;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoGastoFamiliaFinabece TipoGastoFamiliarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoGastoFamiliaFinabece newReg = _appDbContext.TipoGastoFamiliaFinabeces.Where(p => p.IdtipoGastoFamilia == TipoGastoFamiliarFinabece.IdtipoGastoFamilia).First();
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
        public RespuestaCRUD Delete(decimal IdTipoGastoFamiliarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoGastoFamiliaFinabece newReg = _appDbContext.TipoGastoFamiliaFinabeces.Where(p => p.IdtipoGastoFamilia == IdTipoGastoFamiliarFinabece).First();
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
