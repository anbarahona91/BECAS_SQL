using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class VwConvocatoriaFiltro
    {
        public decimal? Id { get; set; }
        public decimal Idconvocatoria { get; set; }
        public decimal IdmodalidadPrograma { get; set; }
        public decimal IdnivelAcademico { get; set; }
        public decimal IdIdioma { get; set; }
        public decimal Idpais { get; set; }
        public decimal IdclasificacionEspecialidad { get; set; }
        public decimal IdareaEstudio { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string NombrePais { get; set; } = null!;
        public string? Bandera { get; set; }
        public string NombreNivelAcademico { get; set; } = null!;
    }
}
