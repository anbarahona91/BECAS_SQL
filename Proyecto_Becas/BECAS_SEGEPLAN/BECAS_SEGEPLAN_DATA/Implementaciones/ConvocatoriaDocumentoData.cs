using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaDocumentoData: IConvocatoriaDocumentoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaDocumentoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       

        public IEnumerable<ConvocatoriaDocumento> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaDocumentos
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaDocumento ObtenerId(int IdConvocatoriaDocumentos)
        {
            return _appDbContext.ConvocatoriaDocumentos.Where(p => p.IdconvocatoriaDocumento == IdConvocatoriaDocumentos).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaDocumento ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaDocumento;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaDocumento ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaDocumento newReg = _appDbContext.ConvocatoriaDocumentos.Where(p => p.IdconvocatoriaDocumento == ConvocartoriaPais.IdconvocatoriaDocumento).First();
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
                ConvocatoriaDocumento newReg = _appDbContext.ConvocatoriaDocumentos.Where(p => p.IdconvocatoriaDocumento == IdConvocartoriaPais).First();
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
