using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class Evento
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafin { get; set; }
        public string Imagenencabezado { get; set; } = null!;
        public string? Thumbail { get; set; }
        public DateTime AudFechacreacion { get; set; }
        public short? AudIdusuariocreacion { get; set; }
        public DateTime? AudFechamodificacion { get; set; }
        public short? AudIdusuariomodificacion { get; set; }
        public bool? AudEliminado { get; set; }
        public bool? AudLectura { get; set; }
        public bool Requiereregistro { get; set; }
        public decimal Idevento { get; set; }
    }
}
