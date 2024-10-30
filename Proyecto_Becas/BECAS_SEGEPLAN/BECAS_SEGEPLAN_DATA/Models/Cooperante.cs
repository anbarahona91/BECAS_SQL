using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Cooperante
    {
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Idpais { get; set; }
        public string? Logo { get; set; }
        public string? Sitioweb { get; set; }
        public string? Contacto { get; set; }
        public decimal Idcooperante { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
    }
}
