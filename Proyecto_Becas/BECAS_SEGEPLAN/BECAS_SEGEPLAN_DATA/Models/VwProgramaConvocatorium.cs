using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class VwProgramaConvocatorium
    {
        public decimal? Id { get; set; }
        public decimal Idconvocatoria { get; set; }
        public decimal IdprogramaAcademico { get; set; }
        public string NombrePrograma { get; set; } = null!;
        public string? DescripcionPrograma { get; set; }
        public string NombreTipoBeca { get; set; } = null!;
        public string NombreCooperante { get; set; } = null!;
        public decimal Idpais { get; set; }
        public string PaisCooperante { get; set; } = null!;
        public string? Bandera { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombreConvocatoria { get; set; } = null!;
        public string? DescripcionConvocatoria { get; set; }
        public string? Dirigido { get; set; }
        public bool AvalSegeplan { get; set; }
        public bool InstitucionProponente { get; set; }
        public DateTime FechaInicioAplicacion { get; set; }
        public DateTime FechaFinAplicacion { get; set; }
        public string? RequisitoEdad { get; set; }
        public string NombreModalidad { get; set; } = null!;
        public byte? DuracionAnio { get; set; }
        public byte? DuracionMes { get; set; }
        public byte? DuracionSemana { get; set; }
        public byte? DuracionDia { get; set; }
        public DateTime? FechaInicioPrograma { get; set; }
        public DateTime? FechaFinPrograma { get; set; }
        public string? Observaciones { get; set; }
        public string? InformacionContacto { get; set; }
        public string? CorreoElectronicoContacto { get; set; }
        public string? Nacionalidad { get; set; }
        public string? OtrosBeneficios { get; set; }
    }
}
