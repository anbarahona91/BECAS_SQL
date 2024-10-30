using System;
using System.Collections.Generic;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ConvocatoriaFinabece
    {
        public decimal IdconvocatoriaFinabece { get; set; }
        public decimal Idconvocatoria { get; set; }
        public decimal Idparticipante { get; set; }
        public bool? TieneEmpleo { get; set; }
        public string? LugarEmpleo { get; set; }
        public string? ResidenciaEstudio { get; set; }
        public decimal? IddepartamentoEstudio { get; set; }
        public decimal? IdmunicipioEstudio { get; set; }
        public decimal? IdnivelAcademicoAprobado { get; set; }
        public decimal? IdnivelAcademicoRealizar { get; set; }
        public decimal? IdnivelAcademicoActual { get; set; }
        public decimal? IdclasificacionEspecialidad { get; set; }
        public string? NombreCarreraActual { get; set; }
        public bool? CierraPensumProximoAnio { get; set; }
        public decimal? IdtipoSolicitudBeca { get; set; }
        public decimal? PromedioAplica { get; set; }
        public decimal? IdtipoCicloEstudio { get; set; }
        public decimal? IdtipoPlanEstudio { get; set; }
        public DateTime? FechaInicioEstudio { get; set; }
        public DateTime? FechaFinEstudio { get; set; }
        public bool? PoseeOtraBeca { get; set; }
        public decimal? Iduniversidad { get; set; }
        public string? Sede { get; set; }
        public string? Facultad { get; set; }
        public string? UniversidadDireccion { get; set; }
        public string? UniversidadTelefono { get; set; }
        public decimal? IddepartamentoUniversidad { get; set; }
        public decimal? IdmunicipioUniversidad { get; set; }
        public string? MesesPagoInscripcion { get; set; }
        public string? MesesPagoCuota { get; set; }
        public decimal? IdtipoTenenciaVivienda { get; set; }
        public bool? ViviendaAlquiladaContrato { get; set; }
        public decimal? IdtipoSectorVivienda { get; set; }
        public decimal? IdtipoCaracteristicaVivienda { get; set; }
        public decimal? IdtipoParedesVivienda { get; set; }
        public decimal? IdtipoPisoVivienda { get; set; }
        public decimal? IdtipoTechoVivienda { get; set; }
        public string? IdtipoServiciosVivienda { get; set; }
        public decimal? IdtipoEstadoViasVivienda { get; set; }
        public bool? PostulantePoseeVehiculo { get; set; }
        public bool? FamiliaPoseeVehiculo { get; set; }
        public string? IdtipoServiciosMedicosFamilia { get; set; }
        public bool? PostulantePoseeProblemasSalud { get; set; }
        public bool? MiembroFamiliaPoseeProblemasSalud { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public byte? CantidadMiembrosFamilia { get; set; }
        public decimal? IdestatusPostulacion { get; set; }
    }
}
