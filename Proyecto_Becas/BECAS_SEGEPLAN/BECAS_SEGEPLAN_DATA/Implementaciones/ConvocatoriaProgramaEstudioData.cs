using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaProgramaEstudioData : IConvocatoriaProgramaEstudioData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaProgramaEstudioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        

        public IEnumerable<ConvocatoriaProgramaEstudio> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaProgramaEstudios
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaProgramaEstudio ObtenerId(int IdConvocatoriaProgramaEstudios)
        {
            return _appDbContext.ConvocatoriaProgramaEstudios.Where(p => p.IdconvocatoriaProgramaEstudio == IdConvocatoriaProgramaEstudios).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaProgramaEstudio ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaProgramaEstudio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaProgramaEstudio ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaProgramaEstudio newReg = _appDbContext.ConvocatoriaProgramaEstudios.Where(p => p.IdconvocatoriaProgramaEstudio == ConvocartoriaPais.IdconvocatoriaProgramaEstudio).First();
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
                ConvocatoriaProgramaEstudio newReg = _appDbContext.ConvocatoriaProgramaEstudios.Where(p => p.IdconvocatoriaProgramaEstudio == IdConvocartoriaPais).First();
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
