using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaFinabeceDocumento
    {
        public decimal IdconvocatoriaFinabeceDocumento { get; set; }
        public decimal? Idcovocatoria { get; set; }
        public decimal? Idparticipante { get; set; }
        public decimal? IdtipoDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Documento { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
    }
}
