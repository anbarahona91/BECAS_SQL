using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class IdiomaProgramaData : IIdiomaProgramaData
    {
        private readonly ModelContext _appDbContext;

        public IdiomaProgramaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<IdiomaPrograma> Listado()
        {

            return _appDbContext.IdiomaProgramas.ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.IdiomaProgramas
                         join vc in _appDbContext.VwConvocatoriaFiltros on a.IdidiomaPrograma equals vc.IdIdioma
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public IdiomaPrograma ObtenerId(int IdIdiomaPrograma)
        {
            return _appDbContext.IdiomaProgramas.Where(p => p.IdidiomaPrograma == IdIdiomaPrograma).First();
        }

        public RespuestaCRUD Insertar(IdiomaPrograma IdiomaPrograma)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(IdiomaPrograma);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = IdiomaPrograma.IdidiomaPrograma;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(IdiomaPrograma IdiomaPrograma)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                IdiomaPrograma newReg = _appDbContext.IdiomaProgramas.Where(p => p.IdidiomaPrograma == IdiomaPrograma.IdidiomaPrograma).First();
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
        public RespuestaCRUD Delete(decimal IdIdiomaPrograma, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                IdiomaPrograma newReg = _appDbContext.IdiomaProgramas.Where(p => p.IdidiomaPrograma == IdIdiomaPrograma).First();
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
