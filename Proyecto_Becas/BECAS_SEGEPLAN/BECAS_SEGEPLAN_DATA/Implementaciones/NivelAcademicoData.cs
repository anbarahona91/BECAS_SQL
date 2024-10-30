using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class NivelAcademicoData : INivelAcademicoData
    {
        private readonly ModelContext _appDbContext;

        public NivelAcademicoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<NivelAcademico> Listado()
        {

            return _appDbContext.NivelAcademicos.ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<NivelAcademico> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.NivelAcademicos
                         join vc in _appDbContext.VwConvocatoriaFiltros on a.IdnivelAcademico equals vc.IdnivelAcademico
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public NivelAcademico ObtenerId(int IdNivelAcademico)
        {
            return _appDbContext.NivelAcademicos.Where(p => p.IdnivelAcademico == IdNivelAcademico).First();
        }

        public RespuestaCRUD Insertar(NivelAcademico NivelAcademico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(NivelAcademico);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = NivelAcademico.IdnivelAcademico;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(NivelAcademico NivelAcademico)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                NivelAcademico newReg = _appDbContext.NivelAcademicos.Where(p => p.IdnivelAcademico == NivelAcademico.IdnivelAcademico).First();
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
        public RespuestaCRUD Delete(decimal IdNivelAcademico, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                NivelAcademico newReg = _appDbContext.NivelAcademicos.Where(p => p.IdnivelAcademico == IdNivelAcademico).First();
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
