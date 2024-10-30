using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaFinabeceData : IConvocatoriaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ConvocatoriaFinabece> Listado()
        {

            return _appDbContext.ConvocatoriaFinabeces.ToList();

        }

        public IEnumerable<ConvocatoriaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeces
                             //where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaFinabece ObtenerId(decimal IdConvocatoriaFinabece)
        {
            return _appDbContext.ConvocatoriaFinabeces.Where(p => p.IdconvocatoriaFinabece == IdConvocatoriaFinabece).FirstOrDefault();
        }

        public ConvocatoriaFinabece ObtenerId(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeces.Where(p => p.Idconvocatoria == IdConvocatoria && p.Idparticipante == IdParticipante).FirstOrDefault();
        }

        public bool ExisteConvocatoriaFinabece(decimal IdParticipante, decimal IdConvocatoria)
        {
            var query = (from c in _appDbContext.ConvocatoriaFinabeces
                         where c.Idconvocatoria == IdConvocatoria
                         && c.Idparticipante == IdParticipante
                         select c);

            if (query.Count()> 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal ObtenerIdConvocatoriaFinabece(decimal IdParticipante, decimal IdConvocatoria)
        {
            return _appDbContext.ConvocatoriaFinabeces.Where(p => p.Idparticipante == IdParticipante && p.Idconvocatoria == IdConvocatoria).Select(p=> p.IdconvocatoriaFinabece).FirstOrDefault();
        }

        public RespuestaCRUD Insertar(ConvocatoriaFinabece ConvocatoriaFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocatoriaFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocatoriaFinabece.IdconvocatoriaFinabece;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaFinabece ConvocatoriaFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaFinabece newReg = _appDbContext.ConvocatoriaFinabeces.Where(p => p.IdconvocatoriaFinabece == ConvocatoriaFinabece.IdconvocatoriaFinabece).First();
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
        public RespuestaCRUD Delete(decimal IdConvocatoriaFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaFinabece newReg = _appDbContext.ConvocatoriaFinabeces.Where(p => p.IdconvocatoriaFinabece == IdConvocatoriaFinabece).First();
                //newReg.AudEliminado = true;
                //newReg.AudIdusuariomodificacion = IdUsuario;
                //newReg.AudFechamodificacion = DateTime.Today;
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
