using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ClasificacionEspecialidad
    {
        public decimal? IdsubareaEstudio { get; set; }
        public string? Nombre { get; set; }
        public bool? Vigente { get; set; }
        public decimal IdclasificacionEspecialidad { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
    }
}
