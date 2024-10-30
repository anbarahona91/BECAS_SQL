using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaEnlace
    {
        public decimal Idconvocatoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Enlace { get; set; } = null!;
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal IdconvocatoriaEnlaces { get; set; }
    }
}
