using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class CooperanteData :ICooperanteData
    {
        private readonly ModelContext _appDbContext;

        public CooperanteData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Cooperante> Listado()
        {
            return _appDbContext.Cooperantes.Where(p=> p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);
        }
        public Cooperante ObtenerId(int IdCooperante)
        {
            Cooperante? cooperante = _appDbContext.Cooperantes.Where(p => p.Idcooperante == IdCooperante).FirstOrDefault();
            return cooperante;
        }
        public RespuestaCRUD Insertar(Cooperante cooperante)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(cooperante);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = cooperante.Idcooperante;
            }
            catch(DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }
            
            return crud;

        }
        public RespuestaCRUD Update(Cooperante cooperante)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                Cooperante newReg = _appDbContext.Cooperantes.Where(p => p.Idcooperante == cooperante.Idcooperante).First();
                _appDbContext.SaveChanges();
                crud.Resultado = true;
            }
            catch(DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;
        }
        public RespuestaCRUD Delete(decimal IdCooperante,short IdUsuario )
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                Cooperante newReg = _appDbContext.Cooperantes.Where(p => p.Idcooperante == IdCooperante).First();
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
