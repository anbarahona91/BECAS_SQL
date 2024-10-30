using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class AreaEstudioData : IAreaEstudioData
    {
        private readonly ModelContext _appDbContext;

        public AreaEstudioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<AreaEstudio> Listado()
        {

            return _appDbContext.AreaEstudios.Where(p=>p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<AreaEstudio> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.AreaEstudios
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();  
        }

        public AreaEstudio ObtenerId(int IdAreaEstudio)
        {
            return _appDbContext.AreaEstudios.Where(p => p.IdareaEstudio == IdAreaEstudio).First();
        }

        public RespuestaCRUD Insertar(AreaEstudio areaestudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(areaestudio);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = areaestudio.IdareaEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(AreaEstudio areaestudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                AreaEstudio newReg = _appDbContext.AreaEstudios.Where(p => p.IdareaEstudio == areaestudio.IdareaEstudio).First();
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
        public RespuestaCRUD Delete(decimal IdAreaEstudio, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                AreaEstudio newReg = _appDbContext.AreaEstudios.Where(p => p.IdareaEstudio == IdAreaEstudio).First();
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
