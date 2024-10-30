using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class SubareaEstudioData : ISubareaEstudioData
    {
        private readonly ModelContext _appDbContext;

        public SubareaEstudioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SubareaEstudio> Listado()
        {

            return _appDbContext.SubareaEstudios.Where(p=>p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<SubareaEstudio> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.SubareaEstudios
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public SubareaEstudio ObtenerId(int IdSubareaEstudio)
        {
            return _appDbContext.SubareaEstudios.Where(p => p.IdsubareaEstudio == IdSubareaEstudio).First();
        }

        public RespuestaCRUD Insertar(SubareaEstudio Subareaestudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Subareaestudio);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Subareaestudio.IdsubareaEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(SubareaEstudio Subareaestudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                SubareaEstudio newReg = _appDbContext.SubareaEstudios.Where(p => p.IdsubareaEstudio == Subareaestudio.IdsubareaEstudio).First();
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
        public RespuestaCRUD Delete(decimal IdSubareaEstudio, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                SubareaEstudio newReg = _appDbContext.SubareaEstudios.Where(p => p.IdsubareaEstudio == IdSubareaEstudio).First();
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
