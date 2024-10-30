using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaEnlaceData : IConvocatoriaEnlaceData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaEnlaceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaEnlace> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaEnlaces
                         where a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaEnlace ObtenerId(int IdConvocatoriaEnlaces)
        {
            return _appDbContext.ConvocatoriaEnlaces.Where(p => p.IdconvocatoriaEnlaces == IdConvocatoriaEnlaces).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaEnlace ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaEnlaces;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaEnlace ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaEnlace newReg = _appDbContext.ConvocatoriaEnlaces.Where(p => p.IdconvocatoriaEnlaces == ConvocartoriaPais.IdconvocatoriaEnlaces).First();
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
                ConvocatoriaEnlace newReg = _appDbContext.ConvocatoriaEnlaces.Where(p => p.IdconvocatoriaEnlaces == IdConvocartoriaPais).First();
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
