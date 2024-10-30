using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class BeneficioData : IBeneficioData
    {
        private readonly ModelContext _appDbContext;

        public BeneficioData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Beneficio> Listado()
        {

            return _appDbContext.Beneficios.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<Beneficio> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.Beneficios
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public Beneficio ObtenerId(int IdBeneficio)
        {
            return _appDbContext.Beneficios.Where(p => p.Idbeneficio == IdBeneficio).First();
        }

        public RespuestaCRUD Insertar(Beneficio Beneficio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(Beneficio);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Beneficio.Idbeneficio;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(Beneficio Beneficio)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Beneficio newReg = _appDbContext.Beneficios.Where(p => p.Idbeneficio == Beneficio.Idbeneficio).First();
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
        public RespuestaCRUD Delete(decimal IdBeneficio, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Beneficio newReg = _appDbContext.Beneficios.Where(p => p.Idbeneficio == IdBeneficio).First();
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
