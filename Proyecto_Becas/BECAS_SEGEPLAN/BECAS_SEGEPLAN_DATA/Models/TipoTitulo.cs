using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class TipoTitulo
    {
        public decimal IdtipoTitulo { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Vigente { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
    }
}
