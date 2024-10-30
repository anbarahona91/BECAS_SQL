using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaBeneficioData : IConvocatoriaBeneficioData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaBeneficioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Beneficio> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.Beneficios
                         join vc in _appDbContext.ConvocatoriaBeneficios on a.Idbeneficio equals vc.Idbeneficio
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaBeneficio> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaBeneficios
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaBeneficio ObtenerId(int IdConvocatoriaBeneficios)
        {
            return _appDbContext.ConvocatoriaBeneficios.Where(p => p.IdconvocatoriaBeneficio == IdConvocatoriaBeneficios).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaBeneficio ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaBeneficio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaBeneficio ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaBeneficio newReg = _appDbContext.ConvocatoriaBeneficios.Where(p => p.IdconvocatoriaBeneficio == ConvocartoriaPais.IdconvocatoriaBeneficio).First();
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
                ConvocatoriaBeneficio newReg = _appDbContext.ConvocatoriaBeneficios.Where(p => p.IdconvocatoriaBeneficio == IdConvocartoriaPais).First();
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
