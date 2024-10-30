using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaProgramaEstudio
    {
        public decimal Idconvocatoria { get; set; }
        public decimal? IdclasificacionEspecialidad { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal IdconvocatoriaProgramaEstudio { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? IdtipoBeca { get; set; }
    }
}
