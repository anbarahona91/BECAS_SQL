using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class ConvocatoriaFinabeceDocumentoData : IConvocatoriaFinabeceDocumentoData
    {
        private readonly ModelContext _appDbContext;

        public ConvocatoriaFinabeceDocumentoData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<ConvocatoriaFinabeceDocumento> ListadoAsociadoConvocatoria(decimal IdConvocatoria)
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeceDocumentos
                         where a.Idcovocatoria == IdConvocatoria
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }

        public IEnumerable<ConvocatoriaFinabeceDocumento> ListadoAsociadoConvocatoriaTipoDocumento(decimal IdConvocatoria, decimal IdParticipante, decimal IdTipoDocumento)
        {
            var query = (from a in _appDbContext.ConvocatoriaFinabeceDocumentos
                         where a.Idcovocatoria == IdConvocatoria
                         && a.Idparticipante == IdParticipante
                         && a.IdtipoDocumento == IdTipoDocumento
                         && a.AudEliminado == false
                         select a).Distinct();

            return query.ToList();
        }


        public string ObtenerFotografiaVigente(decimal IdConvocatoria, decimal IdParticipante)
        {
            var query = (from f in _appDbContext.ConvocatoriaFinabeceDocumentos
                         where f.Idcovocatoria == IdConvocatoria
                         && f.Idparticipante == IdParticipante
                         && f.IdtipoDocumento == 1
                         && f.AudEliminado == false
                         select f).FirstOrDefault();
            
            if(query is not null)
            {
                return query.Documento;
            }
            else
            {
                return "";
            }
        }
        public ConvocatoriaFinabeceDocumento ObtenerId(int IdConvocatoriaFinabeceDocumentos)
        {
            return _appDbContext.ConvocatoriaFinabeceDocumentos.Where(p => p.IdconvocatoriaFinabeceDocumento == IdConvocatoriaFinabeceDocumentos).First();
        }

        public RespuestaCRUD Insertar(ConvocatoriaFinabeceDocumento Documento)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                if(Documento.IdtipoDocumento == 1)
                {
                    var query = (from f in _appDbContext.ConvocatoriaFinabeceDocumentos
                                 where f.Idcovocatoria == Documento.Idcovocatoria
                                 && f.Idparticipante == Documento.Idparticipante
                                 && f.AudEliminado == false
                                 select f).FirstOrDefault();

                    if (query is not null)
                    {
                        Delete(query.IdconvocatoriaFinabeceDocumento, 1);
                    }
                }

                _appDbContext.Add(Documento);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = Documento.IdconvocatoriaFinabeceDocumento;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(ConvocatoriaFinabeceDocumento ConvocartoriaPais)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                ConvocatoriaFinabeceDocumento newReg = _appDbContext.ConvocatoriaFinabeceDocumentos.Where(p => p.IdconvocatoriaFinabeceDocumento == ConvocartoriaPais.IdconvocatoriaFinabeceDocumento).First();
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
        public RespuestaCRUD Delete(decimal IdConvocartoriaDocumento, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                ConvocatoriaFinabeceDocumento newReg = _appDbContext.ConvocatoriaFinabeceDocumentos.Where(p => p.IdconvocatoriaFinabeceDocumento == IdConvocartoriaDocumento).First();
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
