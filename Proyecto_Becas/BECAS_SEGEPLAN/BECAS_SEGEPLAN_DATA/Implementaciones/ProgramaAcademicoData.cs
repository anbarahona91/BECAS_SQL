using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ProgramaAcademicoData : IProgramaAcademicoData
    {
        private readonly ModelContext _appDbContext;

        public ProgramaAcademicoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ProgramaAcademico> Listado()
        {

            return _appDbContext.ProgramaAcademicos.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<ProgramaAcademico> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.ProgramaAcademicos
                         //where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public ProgramaAcademico ObtenerId(int IdProgramaAcademico)
        {
            return _appDbContext.ProgramaAcademicos.Where(p => p.IdprogramaAcademico == IdProgramaAcademico).First();
        }

        public RespuestaCRUD Insertar(ProgramaAcademico ProgramaAcademico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ProgramaAcademico);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ProgramaAcademico.IdprogramaAcademico;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ProgramaAcademico ProgramaAcademico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ProgramaAcademico newReg = _appDbContext.ProgramaAcademicos.Where(p => p.IdprogramaAcademico == ProgramaAcademico.IdprogramaAcademico).First();
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
        public RespuestaCRUD Delete(decimal IdProgramaAcademico, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ProgramaAcademico newReg = _appDbContext.ProgramaAcademicos.Where(p => p.IdprogramaAcademico == IdProgramaAcademico).First();
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
