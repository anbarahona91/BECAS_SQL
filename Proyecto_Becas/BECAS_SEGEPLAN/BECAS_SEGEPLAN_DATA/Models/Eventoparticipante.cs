using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class EventoParticipante
    {
        public decimal Idevento { get; set; }
        public decimal Idparticipante { get; set; }
        public decimal? Idmedio { get; set; }
        public decimal? IdnivelAcademicointeres { get; set; }
        public decimal? IdnivelAcademicoactual { get; set; }
        public decimal? Idpais { get; set; }
        public decimal? IdareaEstudio { get; set; }
        public decimal? Iddelegacion { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal IdeventoParticipante { get; set; }
    }
}
