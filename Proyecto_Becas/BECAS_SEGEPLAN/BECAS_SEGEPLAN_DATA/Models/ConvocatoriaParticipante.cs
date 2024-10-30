using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaParticipante
    {
        public decimal IdconvocatoriaParticipante { get; set; }
        public decimal Idparticipante { get; set; }
        public string? DireccionResidencia { get; set; }
        public decimal? Iddepartamento { get; set; }
        public decimal? Idmunicipio { get; set; }
        public string? TelefonoCasa { get; set; }
        public string? TelefonoPersonal { get; set; }
        public decimal? IdnivelAcademicoAprobado { get; set; }
        public string? NombreInstitucionAprobado { get; set; }
        public decimal? IdtipoInstitucionEducativa { get; set; }
        public decimal? IdtipoCarrera { get; set; }
        public string? NombreCarrera { get; set; }
        public decimal? IdtipoTitulo { get; set; }
        public short? AnioGraduacion { get; set; }
        public decimal? Promedio { get; set; }
        public decimal? Idconvocatoria { get; set; }
    }
}
