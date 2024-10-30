using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaBeneficio
    {
        public decimal IdconvocatoriaBeneficio { get; set; }
        public decimal? Idconvocatoria { get; set; }
        public decimal? Idbeneficio { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
    }
}
