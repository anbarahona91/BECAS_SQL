using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaFinabeceIngresoFamiliarData : IConvocatoriaFinabeceIngresoFamiliarData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaFinabeceIngresoFamiliarData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaFinabeceIngresoFamiliar> Listado()
        {

            return _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.ToList();

        }

        public IEnumerable<ConvocatoriaFinabeceIngresoFamiliar> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeceIngresoFamiliars
                         where a.Idparticipante == IdParticipante
                         && a.Idconvocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaFinabeceIngresoFamiliar ObtenerId(decimal IdConvocatoriaFinabeceIngresoFamiliar)
        {
            return _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.IdconvocatoriaFinabeceIngresoFamiliar == IdConvocatoriaFinabeceIngresoFamiliar).First();
        }

        public ConvocatoriaFinabeceIngresoFamiliar ObtenerId(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.Idconvocatoria == IdConvocatoria && p.Idparticipante == IdParticipante && p.AudEliminado == false).FirstOrDefault();
        }

        public bool ExisteConvocatoriaFinabeceIngresoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from c in _appDbContext.ConvocatoriaFinabeceIngresoFamiliars
                         where c.Idconvocatoria == IdConvocatoria
                         && c.Idparticipante == IdParticipante
                         && c.AudEliminado == false
                         select c);

            if (query.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal ObtenerIdConvocatoriaFinabeceIngresoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria && p.AudEliminado == false).Select(p=> p.IdconvocatoriaFinabeceIngresoFamiliar).FirstOrDefault();
        }

        public decimal ObtenerTotalIngresoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            return (decimal)_appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria && p.AudEliminado == false).Select(p => p.Ingreso ?? 0).Sum();
        }

        public RespuestaCRUD Insertar(ConvocatoriaFinabeceIngresoFamiliar ConvocatoriaFinabeceIngresoFamiliar)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocatoriaFinabeceIngresoFamiliar);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocatoriaFinabeceIngresoFamiliar.IdconvocatoriaFinabeceIngresoFamiliar;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaFinabeceIngresoFamiliar ConvocatoriaFinabeceIngresoFamiliar)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaFinabeceIngresoFamiliar newReg = _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.IdconvocatoriaFinabeceIngresoFamiliar == ConvocatoriaFinabeceIngresoFamiliar.IdconvocatoriaFinabeceIngresoFamiliar).First();
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
        public RespuestaCRUD Delete(decimal IdConvocatoriaFinabeceIngresoFamiliar, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaFinabeceIngresoFamiliar newReg = _appDbContext.ConvocatoriaFinabeceIngresoFamiliars.Where(p => p.IdconvocatoriaFinabeceIngresoFamiliar == IdConvocatoriaFinabeceIngresoFamiliar).First();
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
