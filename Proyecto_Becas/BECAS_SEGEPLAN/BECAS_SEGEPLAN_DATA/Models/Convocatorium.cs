using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Convocatorium
    {
        public decimal IdprogramaAcademico { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Dirigido { get; set; }
        public bool AvalSegeplan { get; set; }
        public bool InstitucionProponente { get; set; }
        public DateTime FechaInicioAplicacion { get; set; }
        public DateTime FechaFinAplicacion { get; set; }
        public string? RequisitoEdad { get; set; }
        public decimal IdmodalidadPrograma { get; set; }
        public byte? DuracionAnio { get; set; }
        public byte? DuracionMes { get; set; }
        public byte? DuracionSemana { get; set; }
        public byte? DuracionDia { get; set; }
        public DateTime? FechaInicioPrograma { get; set; }
        public DateTime? FechaFinPrograma { get; set; }
        public string? Observaciones { get; set; }
        public string? InformacionContacto { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal Idconvocatoria { get; set; }
        public decimal? IdtipoBeca { get; set; }
        public decimal? Idcooperante { get; set; }
        public bool Contraparte { get; set; }
        public bool? Publica { get; set; }
        public string? CorreoElectronicoContacto { get; set; }
        public string? Nacionalidad { get; set; }
        public string? OtrosBeneficios { get; set; }
        public bool? Finabece { get; set; }
    }
}
