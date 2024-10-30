using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaIdiomaRequeridoData : IConvocatoriaIdiomaRequeridoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaIdiomaRequeridoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<IdiomaPrograma> ListadoAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.IdiomaProgramas
                         join vc in _appDbContext.ConvocatoriaIdiomaRequeridos on a.IdidiomaPrograma equals vc.IdIdioma
                         where a.Vigente == true
                         && vc.Idconvocatoria == IdConvocatoria
                         && vc.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaIdiomaRequerido> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaIdiomaRequeridos
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaIdiomaRequerido ObtenerId(int IdConvocatoriaIdiomaRequeridos)
        {
            return _appDbContext.ConvocatoriaIdiomaRequeridos.Where(p => p.IdconvocatoriaIdiomaRequerido == IdConvocatoriaIdiomaRequeridos).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaIdiomaRequerido ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaIdiomaRequerido;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaIdiomaRequerido ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaIdiomaRequerido newReg = _appDbContext.ConvocatoriaIdiomaRequeridos.Where(p => p.IdconvocatoriaIdiomaRequerido == ConvocartoriaPais.IdconvocatoriaIdiomaRequerido).First();
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
                ConvocatoriaIdiomaRequerido newReg = _appDbContext.ConvocatoriaIdiomaRequeridos.Where(p => p.IdconvocatoriaIdiomaRequerido == IdConvocartoriaPais).First();
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
