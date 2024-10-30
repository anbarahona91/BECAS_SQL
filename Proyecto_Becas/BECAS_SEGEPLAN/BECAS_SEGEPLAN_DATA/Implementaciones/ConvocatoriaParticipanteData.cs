using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaParticipanteData :IConvocatoriaParticipanteData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaParticipanteData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public IEnumerable<ConvocatoriaParticipante> ListadoNivelesAsociadoConvocatoria(int IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaParticipantes
                         where a.Idconvocatoria == IdConvocatoria
                         //&& a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public ConvocatoriaParticipante ObtenerId(decimal IdConvocatoriaParticipantes)
        {
            return _appDbContext.ConvocatoriaParticipantes.Where(p => p.IdconvocatoriaParticipante == IdConvocatoriaParticipantes).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaParticipante ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(ConvocartoriaPais);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = ConvocartoriaPais.IdconvocatoriaParticipante;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaParticipante ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaParticipante newReg = _appDbContext.ConvocatoriaParticipantes.Where(p => p.IdconvocatoriaParticipante == ConvocartoriaPais.IdconvocatoriaParticipante).First();
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
                ConvocatoriaParticipante newReg = _appDbContext.ConvocatoriaParticipantes.Where(p => p.IdconvocatoriaParticipante == IdConvocartoriaPais).First();
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
