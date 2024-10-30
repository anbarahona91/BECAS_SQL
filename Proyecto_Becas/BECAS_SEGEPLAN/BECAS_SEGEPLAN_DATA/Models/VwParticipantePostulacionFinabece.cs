using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class VwParticipantePostulacionFinabece
    {
        public decimal? Id { get; set; }
        public decimal IdconvocatoriaFinabece { get; set; }
        public decimal Idconvocatoria { get; set; }
        public decimal Idparticipante { get; set; }
        public string CuiDpi { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public byte Sexo { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public bool? CierraPensumProximoAnio { get; set; }
        public decimal? PromedioAplica { get; set; }
        public decimal? IdestatusPostulacion { get; set; }
    }
}
