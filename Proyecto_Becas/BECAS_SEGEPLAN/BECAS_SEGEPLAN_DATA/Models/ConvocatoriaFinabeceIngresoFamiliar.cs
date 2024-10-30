using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaFinabeceIngresoFamiliar
    {
        public decimal IdconvocatoriaFinabeceIngresoFamiliar { get; set; }
        public string? NombreCompleto { get; set; }
        public decimal? IdtipoParentesco { get; set; }
        public byte? Edad { get; set; }
        public decimal? Ingreso { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal? Idconvocatoria { get; set; }
        public decimal? Idparticipante { get; set; }
    }
}
