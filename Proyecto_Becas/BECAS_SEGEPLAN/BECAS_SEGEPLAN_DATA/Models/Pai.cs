using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Pai
    {
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Bandera { get; set; }
        public bool? Vigente { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal Idpais { get; set; }
    }
}
