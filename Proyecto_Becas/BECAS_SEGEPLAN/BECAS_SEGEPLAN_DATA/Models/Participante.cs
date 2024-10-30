using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Participante
    {
        public string CuiDpi { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public byte Sexo { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public decimal? Idetnia { get; set; }
        public decimal? Iddepartamento { get; set; }
        public decimal? IdcomunidadLinguistica { get; set; }
        public decimal? Idtipodiscapacidad { get; set; }
        public DateTime? AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariofechamodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public decimal Idparticipante { get; set; }
        public string? CorreoElectronico { get; set; }
        public decimal? Idmunicipio { get; set; }
        public byte? Edad { get; set; }
    }
}
