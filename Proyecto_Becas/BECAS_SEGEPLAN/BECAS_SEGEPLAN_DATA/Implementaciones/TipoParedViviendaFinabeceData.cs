﻿using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;
using System.Data.Entity.Validation;

namespace BECAS_SEGEPLAN_DATA.Implementaciones
{
    public class TipoParedViviendaFinabeceData :ITipoParedViviendaFinabeceData
    {
        private readonly ModelContext _appDbContext;

        public TipoParedViviendaFinabeceData(ModelContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TipoParedViviendaFinabece> Listado()
        {

            return _appDbContext.TipoParedViviendaFinabeces.Where(p => p.AudEliminado == false).ToList().OrderBy(p => p.Nombre);

        }

        public IEnumerable<TipoParedViviendaFinabece> ListadoAsociadoConvocatoria()
        {
            var query = (from a in _appDbContext.TipoParedViviendaFinabeces
                         where a.Vigente == true
                         select a).Distinct();

            return query.ToList();
        }

        public TipoParedViviendaFinabece ObtenerId(int IdTipoParedViviendarFinabece)
        {
            return _appDbContext.TipoParedViviendaFinabeces.Where(p => p.IdtipoParedVivienda == IdTipoParedViviendarFinabece).First();
        }

        public RespuestaCRUD Insertar(TipoParedViviendaFinabece TipoParedViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                _appDbContext.Add(TipoParedViviendarFinabece);
                _appDbContext.SaveChanges();
                crud.Resultado = true;
                crud.IdNew = TipoParedViviendarFinabece.IdtipoParedVivienda;
            }
            catch (DbEntityValidationException ex)
            {
                crud.Resultado = false;
                crud.Mensaje = crud.ErrorDB(ex);
            }

            return crud;

        }
        public RespuestaCRUD Update(TipoParedViviendaFinabece TipoParedViviendarFinabece)
        {
            RespuestaCRUD crud = new RespuestaCRUD();

            try
            {
                TipoParedViviendaFinabece newReg = _appDbContext.TipoParedViviendaFinabeces.Where(p => p.IdtipoParedVivienda == TipoParedViviendarFinabece.IdtipoParedVivienda).First();
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
        public RespuestaCRUD Delete(decimal IdTipoParedViviendarFinabece, short IdUsuario)
        {
            RespuestaCRUD crud = new RespuestaCRUD();
            try
            {
                TipoParedViviendaFinabece newReg = _appDbContext.TipoParedViviendaFinabeces.Where(p => p.IdtipoParedVivienda == IdTipoParedViviendarFinabece).First();
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
