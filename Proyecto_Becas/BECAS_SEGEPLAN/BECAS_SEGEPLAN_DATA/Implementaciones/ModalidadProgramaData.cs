using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ModalidadProgramaData : IModalidadProgramaData
    {
        private readonly ModelContext _appDbContext;

        public ModalidadProgramaData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ModalidadPrograma> Listado()
        {

            return _appDbContext.ModalidadProgramas.ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<ModalidadPrograma> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.ModalidadProgramas
                         join vc in _appDbContext.VwConvocatoriaFiltros on a.IdmodalidadPrograma equals vc.IdmodalidadPrograma
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public ModalidadPrograma ObtenerId(int IdModalidadPrograma)
        {
            return _appDbContext.ModalidadProgramas.Where(p => p.IdmodalidadPrograma == IdModalidadPrograma).First();
        }

        public RespuestaCRUD Insertar(ModalidadPrograma modalidadprograma)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(modalidadprograma);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = modalidadprograma.IdmodalidadPrograma;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ModalidadPrograma modalidadprograma)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ModalidadPrograma newReg = _appDbContext.ModalidadProgramas.Where(p => p.IdmodalidadPrograma == modalidadprograma.IdmodalidadPrograma).First();
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
        public RespuestaCRUD Delete(decimal IdModalidadPrograma, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ModalidadPrograma newReg = _appDbContext.ModalidadProgramas.Where(p => p.IdmodalidadPrograma == IdModalidadPrograma).First();
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
