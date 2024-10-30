using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class UniversidadData : IUniversidadData
    {
        private readonly ModelContext _appDbContext;

        public UniversidadData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Universidad> Listado()
        {

            return _appDbContext.Universidads.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Universidad> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Universidads
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Universidad ObtenerId(int IdUniversidad)
        {
            return _appDbContext.Universidads.Where(p => p.Iduniversidad == IdUniversidad).First();
        }

        public RespuestaCRUD Insertar(Universidad Universidad)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Universidad);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Universidad.Iduniversidad;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(Universidad Universidad)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Universidad newReg = _appDbContext.Universidads.Where(p => p.Iduniversidad == Universidad.Iduniversidad).First();
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
        public RespuestaCRUD Delete(decimal IdUniversidad, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Universidad newReg = _appDbContext.Universidads.Where(p => p.Iduniversidad == IdUniversidad).First();
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
