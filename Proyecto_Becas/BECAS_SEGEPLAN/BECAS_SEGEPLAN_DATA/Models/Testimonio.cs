using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Testimonio
    {
        public string Nombre { get; set; } = null!;
        public short Idpais { get; set; }
        public string Programa { get; set; } = null!;
        public string? Fechas { get; set; }
        public short? Idcooperante { get; set; }
        public string Testimonio1 { get; set; } = null!;
        public string? TestimonioResumen { get; set; }
        public string? Imagen { get; set; }
        public string? ImagenThumb { get; set; }
        public byte? Prioridad { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal Idtestimonio { get; set; }
    }
}
