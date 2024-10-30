using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaParticipantePostulante
    {
        public decimal IdconvocatoriaParticipantePostulante { get; set; }
        public string? NombreInstitucionPostulante { get; set; }
        public string? NombreMaximaAutoridad { get; set; }
        public string? CargoMaximaAutoridad { get; set; }
        public string? CargoPostulante { get; set; }
        public decimal? Iddepartamento { get; set; }
        public decimal? Idmunicipio { get; set; }
        public string? CorreoElectronicoInstitucional { get; set; }
        public string? NumeroTelefonoInstitucional { get; set; }
        public decimal? IdtipoSectorLaboral { get; set; }
        public decimal? IdtipoConservaCargo { get; set; }
    }
}
