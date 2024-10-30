using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaIdiomaData: IConvocatoriaIdiomaData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaIdiomaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.IdiomaProgramas
                         join vc in _appDbContext.ConvocatoriaIdiomas on a.IdidiomaPrograma equals vc.IdIdiomaPrograma
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaIdioma> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaIdiomas
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaIdioma ObtenerId(int IdConvocatoriaIdiomas)
        {
            return _appDbContext.ConvocatoriaIdiomas.Where(p => p.IdconvocatoriaIdioma == IdConvocatoriaIdiomas).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaIdioma ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaIdioma;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaIdioma ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaIdioma newReg = _appDbContext.ConvocatoriaIdiomas.Where(p => p.IdconvocatoriaIdioma == ConvocartoriaPais.IdconvocatoriaIdioma).First();
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
                ConvocatoriaIdioma newReg = _appDbContext.ConvocatoriaIdiomas.Where(p => p.IdconvocatoriaIdioma == IdConvocartoriaPais).First();
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
