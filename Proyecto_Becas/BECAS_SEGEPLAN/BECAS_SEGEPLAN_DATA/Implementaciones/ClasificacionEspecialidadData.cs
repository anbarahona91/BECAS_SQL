using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ClasificacionEspecialidadData : IClasificacionEspecialidadData
    {
        private readonly ModelContext _appDbContext;

        public ClasificacionEspecialidadData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ClasificacionEspecialidad> Listado()
        {

            return _appDbContext.ClasificacionEspecialidads.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<ClasificacionEspecialidad> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.ClasificacionEspecialidads
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public ClasificacionEspecialidad ObtenerId(int IdClasificacionEspecialidad)
        {
            return _appDbContext.ClasificacionEspecialidads.Where(p => p.IdclasificacionEspecialidad == IdClasificacionEspecialidad).First();
        }

        public RespuestaCRUD Insertar(ClasificacionEspecialidad ClasificacionEspecialidad)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ClasificacionEspecialidad);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ClasificacionEspecialidad.IdclasificacionEspecialidad;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ClasificacionEspecialidad ClasificacionEspecialidad)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ClasificacionEspecialidad newReg = _appDbContext.ClasificacionEspecialidads.Where(p => p.IdclasificacionEspecialidad == ClasificacionEspecialidad.IdclasificacionEspecialidad).First();
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
        public RespuestaCRUD Delete(decimal IdClasificacionEspecialidad, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ClasificacionEspecialidad newReg = _appDbContext.ClasificacionEspecialidads.Where(p => p.IdclasificacionEspecialidad == IdClasificacionEspecialidad).First();
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
