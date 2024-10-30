using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class VwTestimonio
    {
        public decimal Idtestimonio { get; set; }
        public string NombreTestimonio { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public string? Bandera { get; set; }
        public string Programa { get; set; } = null!;
        public string? Fechas { get; set; }
        public string Nombre { get; set; } = null!;
        public string Testimonio { get; set; } = null!;
        public string? TestimonioResumen { get; set; }
        public string? Imagen { get; set; }
        public string? ImagenThumb { get; set; }
    }
}
