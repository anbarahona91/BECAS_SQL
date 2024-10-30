using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaPaisData :IConvocatoriaPaisData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaPaisData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pai> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.Pais
                         join vc in _appDbContext.ConvocatoriaPais on a.Idpais equals vc.Idpais
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaPai> ListadoPaisesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in  _appDbContext.ConvocatoriaPais 
                         where  a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaPai ObtenerId(int IdConvocatoriaPais)
        {
            return _appDbContext.ConvocatoriaPais.Where(p => p.IdconvocatoriaPais == IdConvocatoriaPais).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaPai ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaPais;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaPai ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaPai newReg = _appDbContext.ConvocatoriaPais.Where(p => p.IdconvocatoriaPais == ConvocartoriaPais.IdconvocatoriaPais).First();
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
                ConvocatoriaPai newReg = _appDbContext.ConvocatoriaPais.Where(p => p.IdconvocatoriaPais == IdConvocartoriaPais).First();
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
