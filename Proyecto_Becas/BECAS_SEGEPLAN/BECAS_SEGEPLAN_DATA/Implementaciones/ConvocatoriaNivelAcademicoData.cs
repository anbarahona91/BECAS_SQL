
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaNivelAcademicoData :IConvocatoriaNivelAcademicoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaNivelAcademicoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.NivelAcademicos
                         join vc in _appDbContext.ConvocatoriaNivelAcademicos on a.IdnivelAcademico equals vc.IdnivelAcademico
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         && vc.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaNivelAcademico> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaNivelAcademicos
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaNivelAcademico ObtenerId(int IdConvocatoriaNivelAcademicos)
        {
            return _appDbContext.ConvocatoriaNivelAcademicos.Where(p => p.IdconvocatoriaNivelAcademico == IdConvocatoriaNivelAcademicos).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaNivelAcademico ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaNivelAcademico;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaNivelAcademico ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaNivelAcademico newReg = _appDbContext.ConvocatoriaNivelAcademicos.Where(p => p.IdconvocatoriaNivelAcademico == ConvocartoriaPais.IdconvocatoriaNivelAcademico).First();
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
        public RespuestaCRUD Delete(decimal IdConvocartoriaPais, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaNivelAcademico newReg = _appDbContext.ConvocatoriaNivelAcademicos.Where(p => p.IdconvocatoriaNivelAcademico == IdConvocartoriaPais).First();
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
