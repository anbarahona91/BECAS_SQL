using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaFinabeceGastoFamiliarData : IConvocatoriaFinabeceGastoFamiliarData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaFinabeceGastoFamiliarData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaFinabeceGastoFamiliar> Listado()
        {

            return _appDbContext.ConvocatoriaFinabeceGastoFamiliars.ToList();

        }

        public IEnumerable<ConvocatoriaFinabeceGastoFamiliar> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeceGastoFamiliars
                         where a.Idparticipante == IdParticipante
                         && a.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaFinabeceGastoFamiliar ObtenerId(decimal IdConvocatoriaFinabeceGastoFamiliar)
        {
            return _appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.IdconvocatoriaFinabeceGastoFamiliar == IdConvocatoriaFinabeceGastoFamiliar).First();
        }

        public ConvocatoriaFinabeceGastoFamiliar ObtenerId(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.Idconvocatoria == IdConvocatoria && p.Idparticipante == IdParticipante).FirstOrDefault();
        }

        public bool ExisteConvocatoriaFinabeceGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from c in _appDbContext.ConvocatoriaFinabeceGastoFamiliars
                         where c.Idconvocatoria == IdConvocatoria
                         && c.Idparticipante == IdParticipante
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

        public decimal ObtenerIdConvocatoriaFinabeceGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria).Select(p => p.IdconvocatoriaFinabeceGastoFamiliar).FirstOrDefault();
        }

        public decimal ObtenerTotalGastoFamiliar(decimal IdParticipante, decimal IdConvocatoria)
        {
            return (decimal)_appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria).Select(p => p.Gasto ?? 0).Sum();
        }
        public RespuestaCRUD CompletarTipoGasto(decimal IdParticipante, decimal IdConvocatoria)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            var query = (from t in _appDbContext.TipoGastoFamiliaFinabeces
                         where t.Vigente == true
                         select t);

            foreach (TipoGastoFamiliaFinabece gasto in query)
            {
                ConvocatoriaFinabeceGastoFamiliar nuevo = new ConvocatoriaFinabeceGastoFamiliar();
                nuevo.Idconvocatoria = IdConvocatoria;
                nuevo.Idparticipante = IdParticipante;
                nuevo.IdtipoGastoFamilia = gasto.IdtipoGastoFamilia;
                nuevo.Gasto = null;
                Insertar(nuevo);
            }

            crud.Resultado = true;

            return crud;

        }

        public RespuestaCRUD Insertar(ConvocatoriaFinabeceGastoFamiliar ConvocatoriaFinabeceGastoFamiliar)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocatoriaFinabeceGastoFamiliar);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocatoriaFinabeceGastoFamiliar.IdconvocatoriaFinabeceGastoFamiliar;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaFinabeceGastoFamiliar ConvocatoriaFinabeceGastoFamiliar)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaFinabeceGastoFamiliar newReg = _appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.IdconvocatoriaFinabeceGastoFamiliar == ConvocatoriaFinabeceGastoFamiliar.IdconvocatoriaFinabeceGastoFamiliar).First();
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
        public RespuestaCRUD Delete(decimal IdConvocatoriaFinabeceGastoFamiliar, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaFinabeceGastoFamiliar newReg = _appDbContext.ConvocatoriaFinabeceGastoFamiliars.Where(p => p.IdconvocatoriaFinabeceGastoFamiliar == IdConvocatoriaFinabeceGastoFamiliar).First();
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
