using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ParticipanteData :IParticipanteData
    {
        private readonly ModelContext _appDbContext;

        public ParticipanteData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Participante> Listado()
        {

            return _appDbContext.Participantes.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Participante> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Participantes
                             //where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Participante ObtenerId(decimal IdParticipante)
        {
            return _appDbContext.Participantes.Where(p => p.Idparticipante == IdParticipante).FirstOrDefault();
        }

        public Participante ObtenerCUI(string CUI)
        {
            return _appDbContext.Participantes.Where(p => p.CuiDpi == CUI).FirstOrDefault();
        }

        public RespuestaCRUD Insertar(Participante Participante)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Participante);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Participante.Idparticipante;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(Participante Participante)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Participante newReg = _appDbContext.Participantes.Where(p => p.Idparticipante == Participante.Idparticipante).First();
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
        public RespuestaCRUD Delete(decimal IdParticipante, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Participante newReg = _appDbContext.Participantes.Where(p => p.Idparticipante == IdParticipante).First();
                newReg.AudEliminado = true;
                newReg.AudIdusuariofechamodificacion = IdUsuario;
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
