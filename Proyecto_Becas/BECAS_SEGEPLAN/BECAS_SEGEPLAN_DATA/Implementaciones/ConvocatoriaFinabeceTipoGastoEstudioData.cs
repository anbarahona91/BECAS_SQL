using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaFinabeceTipoGastoEstudioData : IConvocatoriaFinabeceTipoGastoEstudioData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaFinabeceTipoGastoEstudioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaFinabeceTipoGastoEstudio> Listado()
        {

            return _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.ToList();

        }

        public IEnumerable<ConvocatoriaFinabeceTipoGastoEstudio> ListadoAsociadoConvocatoria(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios
                         where a.Idparticipante == IdParticipante
                         && a.Idconvocatoria == IdConvocatoria
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaFinabeceTipoGastoEstudio ObtenerId(decimal IdConvocatoriaFinabeceTipoGastoEstudio)
        {
            return _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.IdconvocatoriaFinabeceTipoGasto == IdConvocatoriaFinabeceTipoGastoEstudio).First();
        }

        public ConvocatoriaFinabeceTipoGastoEstudio ObtenerId(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.Idconvocatoria == IdConvocatoria && p.Idparticipante == IdParticipante).FirstOrDefault();
        }

        public bool ExisteConvocatoriaFinabeceTipoGastoEstudio(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from c in _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios
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

        public decimal ObtenerTotalGastoEstudio(decimal IdParticipante, decimal IdConvocatoria)
        {
            return (decimal)_appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria).Select(p => p.Gasto ?? 0).Sum();
        }
        public decimal ObtenerIdConvocatoriaFinabeceTipoGastoEstudio(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria).Select(p=>p.IdconvocatoriaFinabeceTipoGasto).First();
        }


        public RespuestaCRUD CompletarTipoGasto(decimal IdParticipante, decimal IdConvocatoria)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            var query = (from t in _appDbContext.TipoGastoEstudioFinabeces
                         where t.Vigente == true
                         select t);

            foreach (TipoGastoEstudioFinabece gasto in query)
            {
                ConvocatoriaFinabeceTipoGastoEstudio nuevo = new ConvocatoriaFinabeceTipoGastoEstudio();
                nuevo.Idconvocatoria = IdConvocatoria;
                nuevo.Idparticipante = IdParticipante;
                nuevo.IdtipoGastoEstuio = gasto.IdtipoGastoEstudio;
                nuevo.Gasto = 0;
                Insertar(nuevo);
            }

            crud.Resultado = true;

            return crud;

        }

        public RespuestaCRUD Insertar(ConvocatoriaFinabeceTipoGastoEstudio ConvocatoriaFinabeceTipoGastoEstudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocatoriaFinabeceTipoGastoEstudio);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocatoriaFinabeceTipoGastoEstudio.IdconvocatoriaFinabeceTipoGasto;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaFinabeceTipoGastoEstudio ConvocatoriaFinabeceTipoGastoEstudio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaFinabeceTipoGastoEstudio newReg = _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.IdconvocatoriaFinabeceTipoGasto == ConvocatoriaFinabeceTipoGastoEstudio.IdconvocatoriaFinabeceTipoGasto).First();
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
        public RespuestaCRUD Delete(decimal IdConvocatoriaFinabeceTipoGastoEstudio, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaFinabeceTipoGastoEstudio newReg = _appDbContext.ConvocatoriaFinabeceTipoGastoEstudios.Where(p => p.IdconvocatoriaFinabeceTipoGasto == IdConvocatoriaFinabeceTipoGastoEstudio).First();
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
