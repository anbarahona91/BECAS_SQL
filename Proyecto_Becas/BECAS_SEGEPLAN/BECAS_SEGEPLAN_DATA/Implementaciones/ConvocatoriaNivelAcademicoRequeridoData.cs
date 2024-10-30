
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaNivelAcademicoRequeridoData : IConvocatoriaNivelAcademicoRequeridoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaNivelAcademicoRequeridoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.NivelAcademicos
                         join vc in _appDbContext.ConvocatoriaNivelAcademicoRequeridos on a.IdnivelAcademico equals vc.IdnivelAcademico
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }
        public IEnumerable<ConvocatoriaNivelAcademicoRequerido> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaNivelAcademicoRequeridos
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaNivelAcademicoRequerido ObtenerId(int IdConvocatoriaNivelAcademicoRequeridos)
        {
            return _appDbContext.ConvocatoriaNivelAcademicoRequeridos.Where(p => p.IdconvocatoriaNivelAcademicoRequerido == IdConvocatoriaNivelAcademicoRequeridos).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaNivelAcademicoRequerido ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaNivelAcademicoRequerido;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaNivelAcademicoRequerido ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaNivelAcademicoRequerido newReg = _appDbContext.ConvocatoriaNivelAcademicoRequeridos.Where(p => p.IdconvocatoriaNivelAcademicoRequerido == ConvocartoriaPais.IdconvocatoriaNivelAcademicoRequerido).First();
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
                ConvocatoriaNivelAcademicoRequerido newReg = _appDbContext.ConvocatoriaNivelAcademicoRequeridos.Where(p => p.IdconvocatoriaNivelAcademicoRequerido == IdConvocartoriaPais).First();
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
