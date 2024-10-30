using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BECAS_SEGEPLAN_DATA.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaEstudio> AreaEstudios { get; set; } = null!;
        public virtual DbSet<Beneficio> Beneficios { get; set; } = null!;
        public virtual DbSet<ClasificacionEspecialidad> ClasificacionEspecialidads { get; set; } = null!;
        public virtual DbSet<ComunidadLinguistica> ComunidadLinguisticas { get; set; } = null!;
        public virtual DbSet<ConvocatoriaBeneficio> ConvocatoriaBeneficios { get; set; } = null!;
        public virtual DbSet<ConvocatoriaDocumento> ConvocatoriaDocumentos { get; set; } = null!;
        public virtual DbSet<ConvocatoriaEnlace> ConvocatoriaEnlaces { get; set; } = null!;
        public virtual DbSet<ConvocatoriaFinabece> ConvocatoriaFinabeces { get; set; } = null!;
        public virtual DbSet<ConvocatoriaFinabeceDocumento> ConvocatoriaFinabeceDocumentos { get; set; } = null!;
        public virtual DbSet<ConvocatoriaFinabeceGastoFamiliar> ConvocatoriaFinabeceGastoFamiliars { get; set; } = null!;
        public virtual DbSet<ConvocatoriaFinabeceIngresoFamiliar> ConvocatoriaFinabeceIngresoFamiliars { get; set; } = null!;
        public virtual DbSet<ConvocatoriaFinabeceTipoGastoEstudio> ConvocatoriaFinabeceTipoGastoEstudios { get; set; } = null!;
        public virtual DbSet<ConvocatoriaIdioma> ConvocatoriaIdiomas { get; set; } = null!;
        public virtual DbSet<ConvocatoriaIdiomaRequerido> ConvocatoriaIdiomaRequeridos { get; set; } = null!;
        public virtual DbSet<ConvocatoriaNivelAcademico> ConvocatoriaNivelAcademicos { get; set; } = null!;
        public virtual DbSet<ConvocatoriaNivelAcademicoRequerido> ConvocatoriaNivelAcademicoRequeridos { get; set; } = null!;
        public virtual DbSet<ConvocatoriaPai> ConvocatoriaPais { get; set; } = null!;
        public virtual DbSet<ConvocatoriaParticipante> ConvocatoriaParticipantes { get; set; } = null!;
        public virtual DbSet<ConvocatoriaParticipantePostulante> ConvocatoriaParticipantePostulantes { get; set; } = null!;
        public virtual DbSet<ConvocatoriaProgramaEstudio> ConvocatoriaProgramaEstudios { get; set; } = null!;
        public virtual DbSet<ConvocatoriaPublico> ConvocatoriaPublicos { get; set; } = null!;
        public virtual DbSet<Convocatorium> Convocatoria { get; set; } = null!;
        public virtual DbSet<Cooperante> Cooperantes { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Discapacidad> Discapacidads { get; set; } = null!;
        public virtual DbSet<Etnium> Etnia { get; set; } = null!;
        public virtual DbSet<Evento> Eventos { get; set; } = null!;
        public virtual DbSet<EventoParticipante> EventoParticipantes { get; set; } = null!;
        public virtual DbSet<IdiomaPrograma> IdiomaProgramas { get; set; } = null!;
        public virtual DbSet<Medio> Medios { get; set; } = null!;
        public virtual DbSet<ModalidadPrograma> ModalidadProgramas { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<NivelAcademico> NivelAcademicos { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<Participante> Participantes { get; set; } = null!;
        public virtual DbSet<ProgramaAcademico> ProgramaAcademicos { get; set; } = null!;
        public virtual DbSet<ProgramaAcademicoDocumento> ProgramaAcademicoDocumentos { get; set; } = null!;
        public virtual DbSet<Publico> Publicos { get; set; } = null!;
        public virtual DbSet<SubareaEstudio> SubareaEstudios { get; set; } = null!;
        public virtual DbSet<Testimonio> Testimonios { get; set; } = null!;
        public virtual DbSet<TipoBeca> TipoBecas { get; set; } = null!;
        public virtual DbSet<TipoCaracteristicaViviendaFinabece> TipoCaracteristicaViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoCarrera> TipoCarreras { get; set; } = null!;
        public virtual DbSet<TipoCicloAprobadoFinabece> TipoCicloAprobadoFinabeces { get; set; } = null!;
        public virtual DbSet<TipoCicloEstudioFinabece> TipoCicloEstudioFinabeces { get; set; } = null!;
        public virtual DbSet<TipoConservaCargo> TipoConservaCargos { get; set; } = null!;
        public virtual DbSet<TipoEstatusPostulacionFinabece> TipoEstatusPostulacionFinabeces { get; set; } = null!;
        public virtual DbSet<TipoGastoEstudioFinabece> TipoGastoEstudioFinabeces { get; set; } = null!;
        public virtual DbSet<TipoGastoFamiliaFinabece> TipoGastoFamiliaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoInstitucionEducativa> TipoInstitucionEducativas { get; set; } = null!;
        public virtual DbSet<TipoParedViviendaFinabece> TipoParedViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoParentestoFinabece> TipoParentestoFinabeces { get; set; } = null!;
        public virtual DbSet<TipoPisoViviendaFinabece> TipoPisoViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoPlanEstudioFinabece> TipoPlanEstudioFinabeces { get; set; } = null!;
        public virtual DbSet<TipoSectorLaboral> TipoSectorLaborals { get; set; } = null!;
        public virtual DbSet<TipoSectorViviendaFinabece> TipoSectorViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoServicioMedicoViviendaFinabece> TipoServicioMedicoViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoServicioViviendaFinabece> TipoServicioViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoSolicitudBecaFinabece> TipoSolicitudBecaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoTechoViviendaFinabece> TipoTechoViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoTenenciaViviendaFinabece> TipoTenenciaViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<TipoTitulo> TipoTitulos { get; set; } = null!;
        public virtual DbSet<TipoViasAccesoViviendaFinabece> TipoViasAccesoViviendaFinabeces { get; set; } = null!;
        public virtual DbSet<Universidad> Universidads { get; set; } = null!;
        public virtual DbSet<VwConvocatoriaFiltro> VwConvocatoriaFiltros { get; set; } = null!;
        public virtual DbSet<VwParticipantePostulacionFinabece> VwParticipantePostulacionFinabeces { get; set; } = null!;
        public virtual DbSet<VwProgramaConvocatorium> VwProgramaConvocatoria { get; set; } = null!;
        public virtual DbSet<VwTestimonio> VwTestimonios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=becas;Password=segeplan;Data Source=localhost:1521/xe;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("BECAS")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<AreaEstudio>(entity =>
            {
                entity.HasKey(e => e.IdareaEstudio)
                    .HasName("AREA_ESTUDIO_PK");

                entity.ToTable("AREA_ESTUDIO");

                entity.Property(e => e.IdareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDAREA_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Beneficio>(entity =>
            {
                entity.HasKey(e => e.Idbeneficio)
                    .HasName("BENEFICIO_PK");

                entity.ToTable("BENEFICIO");

                entity.Property(e => e.Idbeneficio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDBENEFICIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<ClasificacionEspecialidad>(entity =>
            {
                entity.HasKey(e => e.IdclasificacionEspecialidad)
                    .HasName("CLASIFICACION_ESPECIALIDAD_PK");

                entity.ToTable("CLASIFICACION_ESPECIALIDAD");

                entity.Property(e => e.IdclasificacionEspecialidad)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCLASIFICACION_ESPECIALIDAD");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdsubareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDSUBAREA_ESTUDIO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<ComunidadLinguistica>(entity =>
            {
                entity.HasKey(e => e.IdcomunidadLinguistica)
                    .HasName("COMUNIDAD_LINGUISTICA_PK");

                entity.ToTable("COMUNIDAD_LINGUISTICA");

                entity.Property(e => e.IdcomunidadLinguistica)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCOMUNIDAD_LINGUISTICA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<ConvocatoriaBeneficio>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaBeneficio)
                    .HasName("CONVOCATORIA_BENEFICIO_PK");

                entity.ToTable("CONVOCATORIA_BENEFICIO");

                entity.Property(e => e.IdconvocatoriaBeneficio)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_BENEFICIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idbeneficio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDBENEFICIO");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");
            });

            modelBuilder.Entity<ConvocatoriaDocumento>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaDocumento)
                    .HasName("CONVOCATORIA_DOCUMENTO_PK");

                entity.ToTable("CONVOCATORIA_DOCUMENTO");

                entity.Property(e => e.IdconvocatoriaDocumento)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_DOCUMENTO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Documento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTO");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ConvocatoriaEnlace>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaEnlaces)
                    .HasName("CONVOCATORIA_ENLACES_PK");

                entity.ToTable("CONVOCATORIA_ENLACES");

                entity.Property(e => e.IdconvocatoriaEnlaces)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_ENLACES");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Enlace)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ENLACE");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ConvocatoriaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaFinabece)
                    .HasName("CONVOCATORIA_FINABECE_PK");

                entity.ToTable("CONVOCATORIA_FINABECE");

                entity.Property(e => e.IdconvocatoriaFinabece)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_FINABECE");

                entity.Property(e => e.CantidadMiembrosFamilia)
                    .HasPrecision(2)
                    .HasColumnName("CANTIDAD_MIEMBROS_FAMILIA");

                entity.Property(e => e.CierraPensumProximoAnio)
                    .HasPrecision(1)
                    .HasColumnName("CIERRA_PENSUM_PROXIMO_ANIO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Facultad)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FACULTAD");

                entity.Property(e => e.FamiliaPoseeVehiculo)
                    .HasPrecision(1)
                    .HasColumnName("FAMILIA_POSEE_VEHICULO");

                entity.Property(e => e.FechaFinEstudio)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN_ESTUDIO");

                entity.Property(e => e.FechaInicioEstudio)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO_ESTUDIO");

                entity.Property(e => e.IdclasificacionEspecialidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCLASIFICACION_ESPECIALIDAD");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IddepartamentoEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDEPARTAMENTO_ESTUDIO");

                entity.Property(e => e.IddepartamentoUniversidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDEPARTAMENTO_UNIVERSIDAD");

                entity.Property(e => e.IdestatusPostulacion)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDESTATUS_POSTULACION");

                entity.Property(e => e.IdmunicipioEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMUNICIPIO_ESTUDIO");

                entity.Property(e => e.IdmunicipioUniversidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMUNICIPIO_UNIVERSIDAD");

                entity.Property(e => e.IdnivelAcademicoActual)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO_ACTUAL");

                entity.Property(e => e.IdnivelAcademicoAprobado)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO_APROBADO");

                entity.Property(e => e.IdnivelAcademicoRealizar)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO_REALIZAR");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoCaracteristicaVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_CARACTERISTICA_VIVIENDA");

                entity.Property(e => e.IdtipoCicloEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_CICLO_ESTUDIO");

                entity.Property(e => e.IdtipoEstadoViasVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_ESTADO_VIAS_VIVIENDA");

                entity.Property(e => e.IdtipoParedesVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_PAREDES_VIVIENDA");

                entity.Property(e => e.IdtipoPisoVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_PISO_VIVIENDA");

                entity.Property(e => e.IdtipoPlanEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_PLAN_ESTUDIO");

                entity.Property(e => e.IdtipoSectorVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_SECTOR_VIVIENDA");

                entity.Property(e => e.IdtipoServiciosMedicosFamilia)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IDTIPO_SERVICIOS_MEDICOS_FAMILIA");

                entity.Property(e => e.IdtipoServiciosVivienda)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IDTIPO_SERVICIOS_VIVIENDA");

                entity.Property(e => e.IdtipoSolicitudBeca)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_SOLICITUD_BECA");

                entity.Property(e => e.IdtipoTechoVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_TECHO_VIVIENDA");

                entity.Property(e => e.IdtipoTenenciaVivienda)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_TENENCIA_VIVIENDA");

                entity.Property(e => e.Iduniversidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDUNIVERSIDAD");

                entity.Property(e => e.LugarEmpleo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_EMPLEO");

                entity.Property(e => e.MesesPagoCuota)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("MESES_PAGO_CUOTA");

                entity.Property(e => e.MesesPagoInscripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("MESES_PAGO_INSCRIPCION");

                entity.Property(e => e.MiembroFamiliaPoseeProblemasSalud)
                    .HasPrecision(1)
                    .HasColumnName("MIEMBRO_FAMILIA_POSEE_PROBLEMAS_SALUD");

                entity.Property(e => e.NombreCarreraActual)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CARRERA_ACTUAL");

                entity.Property(e => e.PoseeOtraBeca)
                    .HasPrecision(1)
                    .HasColumnName("POSEE_OTRA_BECA");

                entity.Property(e => e.PostulantePoseeProblemasSalud)
                    .HasPrecision(1)
                    .HasColumnName("POSTULANTE_POSEE_PROBLEMAS_SALUD");

                entity.Property(e => e.PostulantePoseeVehiculo)
                    .HasPrecision(1)
                    .HasColumnName("POSTULANTE_POSEE_VEHICULO");

                entity.Property(e => e.PromedioAplica)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROMEDIO_APLICA");

                entity.Property(e => e.ResidenciaEstudio)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENCIA_ESTUDIO");

                entity.Property(e => e.Sede)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("SEDE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.TieneEmpleo)
                    .HasPrecision(1)
                    .HasColumnName("TIENE_EMPLEO");

                entity.Property(e => e.UniversidadDireccion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("UNIVERSIDAD_DIRECCION");

                entity.Property(e => e.UniversidadTelefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UNIVERSIDAD_TELEFONO");

                entity.Property(e => e.ViviendaAlquiladaContrato)
                    .HasPrecision(1)
                    .HasColumnName("VIVIENDA_ALQUILADA_CONTRATO");
            });

            modelBuilder.Entity<ConvocatoriaFinabeceDocumento>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaFinabeceDocumento)
                    .HasName("CONVOCATORIA_FINABECE_DOCUMENTO_PK");

                entity.ToTable("CONVOCATORIA_FINABECE_DOCUMENTO");

                entity.Property(e => e.IdconvocatoriaFinabeceDocumento)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_FINABECE_DOCUMENTO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Documento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTO");

                entity.Property(e => e.Idcovocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCOVOCATORIA");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoDocumento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_DOCUMENTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ConvocatoriaFinabeceGastoFamiliar>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaFinabeceGastoFamiliar)
                    .HasName("CONVOCATORIA_FINABECE_GASTO_FAMILIAR_PK");

                entity.ToTable("CONVOCATORIA_FINABECE_GASTO_FAMILIAR");

                entity.Property(e => e.IdconvocatoriaFinabeceGastoFamiliar)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_FINABECE_GASTO_FAMILIAR");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Gasto)
                    .HasColumnType("NUMBER(18,2)")
                    .HasColumnName("GASTO");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoGastoFamilia)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_GASTO_FAMILIA");
            });

            modelBuilder.Entity<ConvocatoriaFinabeceIngresoFamiliar>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaFinabeceIngresoFamiliar)
                    .HasName("CONVOCATORIA_FINABECE_INGRESO_FAMILIAR_PK");

                entity.ToTable("CONVOCATORIA_FINABECE_INGRESO_FAMILIAR");

                entity.Property(e => e.IdconvocatoriaFinabeceIngresoFamiliar)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_FINABECE_INGRESO_FAMILIAR");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Edad)
                    .HasPrecision(3)
                    .HasColumnName("EDAD");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoParentesco)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_PARENTESCO");

                entity.Property(e => e.Ingreso)
                    .HasColumnType("NUMBER(18,2)")
                    .HasColumnName("INGRESO");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COMPLETO");
            });

            modelBuilder.Entity<ConvocatoriaFinabeceTipoGastoEstudio>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaFinabeceTipoGasto)
                    .HasName("CONVOCATORIA_FINABECE_TIPO_GASTO_ESTUDIO_PK");

                entity.ToTable("CONVOCATORIA_FINABECE_TIPO_GASTO_ESTUDIO");

                entity.Property(e => e.IdconvocatoriaFinabeceTipoGasto)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_FINABECE_TIPO_GASTO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Gasto)
                    .HasColumnType("NUMBER(18,2)")
                    .HasColumnName("GASTO");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoGastoEstuio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_GASTO_ESTUIO");
            });

            modelBuilder.Entity<ConvocatoriaIdioma>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaIdioma)
                    .HasName("CONVOCATORIA_IDIOMA_PK");

                entity.ToTable("CONVOCATORIA_IDIOMA");

                entity.Property(e => e.IdconvocatoriaIdioma)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_IDIOMA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdIdiomaPrograma)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_IDIOMA_PROGRAMA");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");
            });

            modelBuilder.Entity<ConvocatoriaIdiomaRequerido>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaIdiomaRequerido)
                    .HasName("CONVOCATORIA_IDIOMA_REQUERIDO_PK");

                entity.ToTable("CONVOCATORIA_IDIOMA_REQUERIDO");

                entity.Property(e => e.IdconvocatoriaIdiomaRequerido)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_IDIOMA_REQUERIDO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdIdioma)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_IDIOMA");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");
            });

            modelBuilder.Entity<ConvocatoriaNivelAcademico>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaNivelAcademico)
                    .HasName("CONVOCATORIA_NIVEL_ACADEMICO_PK");

                entity.ToTable("CONVOCATORIA_NIVEL_ACADEMICO");

                entity.Property(e => e.IdconvocatoriaNivelAcademico)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_NIVEL_ACADEMICO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IdnivelAcademico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO");
            });

            modelBuilder.Entity<ConvocatoriaNivelAcademicoRequerido>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaNivelAcademicoRequerido)
                    .HasName("CONVOCATORIA_NIVEL_ACADEMICO_REQUERIDO_PK");

                entity.ToTable("CONVOCATORIA_NIVEL_ACADEMICO_REQUERIDO");

                entity.Property(e => e.IdconvocatoriaNivelAcademicoRequerido)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_NIVEL_ACADEMICO_REQUERIDO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IdnivelAcademico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO");
            });

            modelBuilder.Entity<ConvocatoriaPai>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaPais)
                    .HasName("CONVOCATORIA_PAIS_PK");

                entity.ToTable("CONVOCATORIA_PAIS");

                entity.Property(e => e.IdconvocatoriaPais)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_PAIS");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPAIS");
            });

            modelBuilder.Entity<ConvocatoriaParticipante>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaParticipante)
                    .HasName("CONVOCATORIA_PARTICIPANTE_PK");

                entity.ToTable("CONVOCATORIA_PARTICIPANTE");

                entity.Property(e => e.IdconvocatoriaParticipante)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_PARTICIPANTE");

                entity.Property(e => e.AnioGraduacion)
                    .HasPrecision(5)
                    .HasColumnName("ANIO_GRADUACION");

                entity.Property(e => e.DireccionResidencia)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_RESIDENCIA");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Iddepartamento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDEPARTAMENTO");

                entity.Property(e => e.Idmunicipio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMUNICIPIO");

                entity.Property(e => e.IdnivelAcademicoAprobado)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO_APROBADO");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.IdtipoCarrera)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_CARRERA");

                entity.Property(e => e.IdtipoInstitucionEducativa)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_INSTITUCION_EDUCATIVA");

                entity.Property(e => e.IdtipoTitulo)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_TITULO");

                entity.Property(e => e.NombreCarrera)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CARRERA");

                entity.Property(e => e.NombreInstitucionAprobado)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_INSTITUCION_APROBADO");

                entity.Property(e => e.Promedio)
                    .HasColumnType("NUMBER(18,2)")
                    .HasColumnName("PROMEDIO");

                entity.Property(e => e.TelefonoCasa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_CASA");

                entity.Property(e => e.TelefonoPersonal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_PERSONAL");
            });

            modelBuilder.Entity<ConvocatoriaParticipantePostulante>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaParticipantePostulante)
                    .HasName("CONVOCATORIA_PARTICIPANTE_POSTULANTE_PK");

                entity.ToTable("CONVOCATORIA_PARTICIPANTE_POSTULANTE");

                entity.Property(e => e.IdconvocatoriaParticipantePostulante)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_PARTICIPANTE_POSTULANTE");

                entity.Property(e => e.CargoMaximaAutoridad)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CARGO_MAXIMA_AUTORIDAD");

                entity.Property(e => e.CargoPostulante)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CARGO_POSTULANTE");

                entity.Property(e => e.CorreoElectronicoInstitucional)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ELECTRONICO_INSTITUCIONAL");

                entity.Property(e => e.Iddepartamento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDEPARTAMENTO");

                entity.Property(e => e.Idmunicipio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMUNICIPIO");

                entity.Property(e => e.IdtipoConservaCargo)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_CONSERVA_CARGO");

                entity.Property(e => e.IdtipoSectorLaboral)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_SECTOR_LABORAL");

                entity.Property(e => e.NombreInstitucionPostulante)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_INSTITUCION_POSTULANTE");

                entity.Property(e => e.NombreMaximaAutoridad)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MAXIMA_AUTORIDAD");

                entity.Property(e => e.NumeroTelefonoInstitucional)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_TELEFONO_INSTITUCIONAL");
            });

            modelBuilder.Entity<ConvocatoriaProgramaEstudio>(entity =>
            {
                entity.HasKey(e => e.IdconvocatoriaProgramaEstudio)
                    .HasName("CONVOCATORIA_CLASIFICACION_ESPECIALIDAD_PK");

                entity.ToTable("CONVOCATORIA_PROGRAMA_ESTUDIO");

                entity.Property(e => e.IdconvocatoriaProgramaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA_PROGRAMA_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.IdclasificacionEspecialidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCLASIFICACION_ESPECIALIDAD");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IdtipoBeca)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_BECA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ConvocatoriaPublico>(entity =>
            {
                entity.HasKey(e => e.IdconocatoriaPublico)
                    .HasName("CONVOCATORIA_PUBLICO_PK");

                entity.ToTable("CONVOCATORIA_PUBLICO");

                entity.Property(e => e.IdconocatoriaPublico)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONOCATORIA_PUBLICO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idpublico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPUBLICO");
            });

            modelBuilder.Entity<Convocatorium>(entity =>
            {
                entity.HasKey(e => e.Idconvocatoria)
                    .HasName("CONVOCATORIA_PK");

                entity.ToTable("CONVOCATORIA");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AvalSegeplan)
                    .HasPrecision(1)
                    .HasColumnName("AVAL_SEGEPLAN");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Contraparte)
                    .HasPrecision(1)
                    .HasColumnName("CONTRAPARTE");

                entity.Property(e => e.CorreoElectronicoContacto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ELECTRONICO_CONTACTO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Dirigido)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DIRIGIDO");

                entity.Property(e => e.DuracionAnio)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_ANIO");

                entity.Property(e => e.DuracionDia)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_DIA");

                entity.Property(e => e.DuracionMes)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_MES");

                entity.Property(e => e.DuracionSemana)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_SEMANA");

                entity.Property(e => e.FechaFinAplicacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN_APLICACION");

                entity.Property(e => e.FechaFinPrograma)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN_PROGRAMA");

                entity.Property(e => e.FechaInicioAplicacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO_APLICACION");

                entity.Property(e => e.FechaInicioPrograma)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO_PROGRAMA");

                entity.Property(e => e.Finabece)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("FINABECE")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Idcooperante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCOOPERANTE");

                entity.Property(e => e.IdmodalidadPrograma)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMODALIDAD_PROGRAMA");

                entity.Property(e => e.IdprogramaAcademico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPROGRAMA_ACADEMICO");

                entity.Property(e => e.IdtipoBeca)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPO_BECA");

                entity.Property(e => e.InformacionContacto)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("INFORMACION_CONTACTO");

                entity.Property(e => e.InstitucionProponente)
                    .HasPrecision(1)
                    .HasColumnName("INSTITUCION_PROPONENTE");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NACIONALIDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.OtrosBeneficios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OTROS_BENEFICIOS");

                entity.Property(e => e.Publica)
                    .HasPrecision(1)
                    .HasColumnName("PUBLICA");

                entity.Property(e => e.RequisitoEdad)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("REQUISITO_EDAD");
            });

            modelBuilder.Entity<Cooperante>(entity =>
            {
                entity.HasKey(e => e.Idcooperante)
                    .HasName("COOPERANTE_PK");

                entity.ToTable("COOPERANTE");

                entity.Property(e => e.Idcooperante)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCOOPERANTE");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Logo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Sitioweb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SITIOWEB");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.Iddepartamento)
                    .HasName("DEPARTAMENTO_PK");

                entity.ToTable("DEPARTAMENTO");

                entity.Property(e => e.Iddepartamento)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDEPARTAMENTO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<Discapacidad>(entity =>
            {
                entity.HasKey(e => e.Iddiscapacidad)
                    .HasName("DISCAPACIDAD_PK");

                entity.ToTable("DISCAPACIDAD");

                entity.Property(e => e.Iddiscapacidad)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDISCAPACIDAD");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Etnium>(entity =>
            {
                entity.HasKey(e => e.Idetnia)
                    .HasName("ETNIA_PK");

                entity.ToTable("ETNIA");

                entity.Property(e => e.Idetnia)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDETNIA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.Idevento)
                    .HasName("EVENTO_PK");

                entity.ToTable("EVENTO");

                entity.Property(e => e.Idevento)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDEVENTO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fechafin)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHAFIN");

                entity.Property(e => e.Fechainicio)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHAINICIO");

                entity.Property(e => e.Imagenencabezado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGENENCABEZADO");

                entity.Property(e => e.Requiereregistro)
                    .HasPrecision(1)
                    .HasColumnName("REQUIEREREGISTRO");

                entity.Property(e => e.Thumbail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("THUMBAIL");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TITULO");
            });

            modelBuilder.Entity<EventoParticipante>(entity =>
            {
                entity.HasKey(e => e.IdeventoParticipante)
                    .HasName("EVENTOPARTICIPANTE_PK");

                entity.ToTable("EVENTO_PARTICIPANTE");

                entity.Property(e => e.IdeventoParticipante)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDEVENTO_PARTICIPANTE");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDAREA_ESTUDIO");

                entity.Property(e => e.Iddelegacion)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDELEGACION");

                entity.Property(e => e.Idevento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDEVENTO");

                entity.Property(e => e.Idmedio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMEDIO");

                entity.Property(e => e.IdnivelAcademicoactual)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICOACTUAL");

                entity.Property(e => e.IdnivelAcademicointeres)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICOINTERES");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPARTICIPANTE");
            });

            modelBuilder.Entity<IdiomaPrograma>(entity =>
            {
                entity.HasKey(e => e.IdidiomaPrograma)
                    .HasName("IDIOMA_PROGRAMA_PK");

                entity.ToTable("IDIOMA_PROGRAMA");

                entity.Property(e => e.IdidiomaPrograma)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDIDIOMA_PROGRAMA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Medio>(entity =>
            {
                entity.HasKey(e => e.Idmedio)
                    .HasName("MEDIO_PK");

                entity.ToTable("MEDIO");

                entity.Property(e => e.Idmedio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDMEDIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<ModalidadPrograma>(entity =>
            {
                entity.HasKey(e => e.IdmodalidadPrograma)
                    .HasName("MODALIDAD_PROGRAMA_PK");

                entity.ToTable("MODALIDAD_PROGRAMA");

                entity.Property(e => e.IdmodalidadPrograma)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDMODALIDAD_PROGRAMA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.Idmunicipio)
                    .HasName("MUNICIPIO_PK");

                entity.ToTable("MUNICIPIO");

                entity.Property(e => e.Idmunicipio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDMUNICIPIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<NivelAcademico>(entity =>
            {
                entity.HasKey(e => e.IdnivelAcademico)
                    .HasName("NIVEL_ACADEMICO_PK");

                entity.ToTable("NIVEL_ACADEMICO");

                entity.Property(e => e.IdnivelAcademico)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNIVEL_ACADEMICO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.Idpais)
                    .HasName("PAIS_PK");

                entity.ToTable("PAIS");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Bandera)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BANDERA");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<Participante>(entity =>
            {
                entity.HasKey(e => e.Idparticipante)
                    .HasName("PARTICIPANTE_PK");

                entity.ToTable("PARTICIPANTE");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariofechamodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOFECHAMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ELECTRONICO");

                entity.Property(e => e.CuiDpi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CUI_DPI");

                entity.Property(e => e.Edad)
                    .HasPrecision(3)
                    .HasColumnName("EDAD");

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHANACIMIENTO");

                entity.Property(e => e.IdcomunidadLinguistica)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCOMUNIDAD_LINGUISTICA");

                entity.Property(e => e.Iddepartamento)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDDEPARTAMENTO");

                entity.Property(e => e.Idetnia)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDETNIA");

                entity.Property(e => e.Idmunicipio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMUNICIPIO");

                entity.Property(e => e.Idtipodiscapacidad)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDTIPODISCAPACIDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Sexo)
                    .HasPrecision(2)
                    .HasColumnName("SEXO");
            });

            modelBuilder.Entity<ProgramaAcademico>(entity =>
            {
                entity.HasKey(e => e.IdprogramaAcademico)
                    .HasName("PROGRAMA_ACADEMICO_PK");

                entity.ToTable("PROGRAMA_ACADEMICO");

                entity.Property(e => e.IdprogramaAcademico)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPROGRAMA_ACADEMICO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Idcooperante)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCOOPERANTE");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ProgramaAcademicoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdprogramaAcademicoDocumento)
                    .HasName("PROGRAMA_ACADEMICO_DOCUMENTO_PK");

                entity.ToTable("PROGRAMA_ACADEMICO_DOCUMENTO");

                entity.Property(e => e.IdprogramaAcademicoDocumento)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPROGRAMA_ACADEMICO_DOCUMENTO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Documento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTO");

                entity.Property(e => e.IdprogramaAcademico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPROGRAMA_ACADEMICO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Publico>(entity =>
            {
                entity.HasKey(e => e.Idpublico)
                    .HasName("PUBLICO_PK");

                entity.ToTable("PUBLICO");

                entity.Property(e => e.Idpublico)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPUBLICO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<SubareaEstudio>(entity =>
            {
                entity.HasKey(e => e.IdsubareaEstudio)
                    .HasName("SUBAREA_ESTUDIO_PK");

                entity.ToTable("SUBAREA_ESTUDIO");

                entity.Property(e => e.IdsubareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDSUBAREA_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDAREA_ESTUDIO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<Testimonio>(entity =>
            {
                entity.HasKey(e => e.Idtestimonio)
                    .HasName("TESTIMONIO_PK");

                entity.ToTable("TESTIMONIO");

                entity.Property(e => e.Idtestimonio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTESTIMONIO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Fechas)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FECHAS");

                entity.Property(e => e.Idcooperante)
                    .HasPrecision(5)
                    .HasColumnName("IDCOOPERANTE");

                entity.Property(e => e.Idpais)
                    .HasPrecision(5)
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN");

                entity.Property(e => e.ImagenThumb)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN_THUMB");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Prioridad)
                    .HasPrecision(2)
                    .HasColumnName("PRIORIDAD");

                entity.Property(e => e.Programa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA");

                entity.Property(e => e.Testimonio1)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIO");

                entity.Property(e => e.TestimonioResumen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIO_RESUMEN");
            });

            modelBuilder.Entity<TipoBeca>(entity =>
            {
                entity.HasKey(e => e.IdtipoBeca)
                    .HasName("TIPO_BECA_PK");

                entity.ToTable("TIPO_BECA");

                entity.Property(e => e.IdtipoBeca)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_BECA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0  ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoCaracteristicaViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoCaracteristicaVivienda)
                    .HasName("TIPO_CARACTERISTICA_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_CARACTERISTICA_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoCaracteristicaVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_CARACTERISTICA_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoCarrera>(entity =>
            {
                entity.HasKey(e => e.IdtipoCarrera)
                    .HasName("TIPO_CARRERA_PK");

                entity.ToTable("TIPO_CARRERA");

                entity.Property(e => e.IdtipoCarrera)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_CARRERA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoCicloAprobadoFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoCicloAprobado)
                    .HasName("TIPO_CICLO_APROBADO_FINABECE_PK");

                entity.ToTable("TIPO_CICLO_APROBADO_FINABECE");

                entity.Property(e => e.IdtipoCicloAprobado)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_CICLO_APROBADO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoCicloEstudioFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoCicloEstudio)
                    .HasName("TIPO_CICLO_ESTUDIO_FINABECE_PK");

                entity.ToTable("TIPO_CICLO_ESTUDIO_FINABECE");

                entity.Property(e => e.IdtipoCicloEstudio)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_CICLO_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoConservaCargo>(entity =>
            {
                entity.HasKey(e => e.IdtipoConservaCargo)
                    .HasName("TIPO_CONSERVA_CARGO_PK");

                entity.ToTable("TIPO_CONSERVA_CARGO");

                entity.Property(e => e.IdtipoConservaCargo)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_CONSERVA_CARGO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoEstatusPostulacionFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoEstatusPostulacion)
                    .HasName("TIPO_ESTATUS_POSTULACION_FINABECE_PK");

                entity.ToTable("TIPO_ESTATUS_POSTULACION_FINABECE");

                entity.Property(e => e.IdtipoEstatusPostulacion)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_ESTATUS_POSTULACION");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoGastoEstudioFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoGastoEstudio)
                    .HasName("TABLE1_PK");

                entity.ToTable("TIPO_GASTO_ESTUDIO_FINABECE");

                entity.Property(e => e.IdtipoGastoEstudio)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDTIPO_GASTO_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoGastoFamiliaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoGastoFamilia)
                    .HasName("TIPO_GASTO_FAMILIA_FINABECE_PK");

                entity.ToTable("TIPO_GASTO_FAMILIA_FINABECE");

                entity.Property(e => e.IdtipoGastoFamilia)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_GASTO_FAMILIA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoInstitucionEducativa>(entity =>
            {
                entity.HasKey(e => e.IdtipoInstitucionEducativa)
                    .HasName("TIPO_INSTITUCION_EDUCATIVA_PK");

                entity.ToTable("TIPO_INSTITUCION_EDUCATIVA");

                entity.Property(e => e.IdtipoInstitucionEducativa)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_INSTITUCION_EDUCATIVA");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoParedViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoParedVivienda)
                    .HasName("TIPO_PAREDES_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_PARED_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoParedVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_PARED_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoParentestoFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoParentesco)
                    .HasName("TIPO_PARENTESTO_FINABECE_PK");

                entity.ToTable("TIPO_PARENTESTO_FINABECE");

                entity.Property(e => e.IdtipoParentesco)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_PARENTESCO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoPisoViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoPisoVivienda)
                    .HasName("TIPO_PISOES_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_PISO_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoPisoVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_PISO_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoPlanEstudioFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoPlanEstudio)
                    .HasName("TIPO_PLAN_ESTUDIO_FINABECE_PK");

                entity.ToTable("TIPO_PLAN_ESTUDIO_FINABECE");

                entity.Property(e => e.IdtipoPlanEstudio)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_PLAN_ESTUDIO");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoSectorLaboral>(entity =>
            {
                entity.HasKey(e => e.IdtipoSectorLaboral)
                    .HasName("TIPO_SECTOR_LABORAL_PK");

                entity.ToTable("TIPO_SECTOR_LABORAL");

                entity.Property(e => e.IdtipoSectorLaboral)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_SECTOR_LABORAL");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoSectorViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoSectorVivienda)
                    .HasName("TIPO_SECTOR_VIVIENDA_PK");

                entity.ToTable("TIPO_SECTOR_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoSectorVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_SECTOR_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoServicioMedicoViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoServicioMedicoVivienda)
                    .HasName("TIPO_SERVICIO_MEDICOES_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_SERVICIO_MEDICO_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoServicioMedicoVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_SERVICIO_MEDICO_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoServicioViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoServicioVivienda)
                    .HasName("TIPO_SERVICIOES_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_SERVICIO_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoServicioVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_SERVICIO_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoSolicitudBecaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoSolicitudBeca)
                    .HasName("TIPO_SOLICITUD_BECA_FINABECE_PK");

                entity.ToTable("TIPO_SOLICITUD_BECA_FINABECE");

                entity.Property(e => e.IdtipoSolicitudBeca)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_SOLICITUD_BECA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoTechoViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoTechoVivienda)
                    .HasName("TIPO_TECHOES_VIVIENDA_FINABECE_PK");

                entity.ToTable("TIPO_TECHO_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoTechoVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_TECHO_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoTenenciaViviendaFinabece>(entity =>
            {
                entity.HasKey(e => e.IdtipoTenenciaVivienda)
                    .HasName("TIPO_TENENCIA_VIVIENDA_PK");

                entity.ToTable("TIPO_TENENCIA_VIVIENDA_FINABECE");

                entity.Property(e => e.IdtipoTenenciaVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_TENENCIA_VIVIENDA");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<TipoTitulo>(entity =>
            {
                entity.HasKey(e => e.IdtipoTitulo)
                    .HasName("TIPO_TITULO_PK");

                entity.ToTable("TIPO_TITULO");

                entity.Property(e => e.IdtipoTitulo)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_TITULO");

                entity.Property(e => e.AudEliminado)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE")
                    .HasDefaultValueSql("1 ");
            });

            modelBuilder.Entity<TipoViasAccesoViviendaFinabece>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TIPO_VIAS_ACCESO_VIVIENDA_FINABECE");

                entity.HasIndex(e => e.IdtipoViasAccesoVivienda, "TIPO_VIAS_ACCESO_VIVIENDA_FINABECE_PK")
                    .IsUnique();

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.IdtipoViasAccesoVivienda)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTIPO_VIAS_ACCESO_VIVIENDA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<Universidad>(entity =>
            {
                entity.HasKey(e => e.Iduniversidad)
                    .HasName("UNIVERSIDAD_PK");

                entity.ToTable("UNIVERSIDAD");

                entity.Property(e => e.Iduniversidad)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDUNIVERSIDAD");

                entity.Property(e => e.AudEliminado)
                    .HasPrecision(1)
                    .HasColumnName("AUD_ELIMINADO")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudFechacreacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHACREACION");

                entity.Property(e => e.AudFechamodificacion)
                    .HasColumnType("DATE")
                    .HasColumnName("AUD_FECHAMODIFICACION");

                entity.Property(e => e.AudIdusuariocreacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOCREACION");

                entity.Property(e => e.AudIdusuariomodificacion)
                    .HasPrecision(5)
                    .HasColumnName("AUD_IDUSUARIOMODIFICACION");

                entity.Property(e => e.AudLectura)
                    .HasPrecision(1)
                    .HasColumnName("AUD_LECTURA")
                    .HasDefaultValueSql("0\n   ");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Privada)
                    .HasPrecision(1)
                    .HasColumnName("PRIVADA");

                entity.Property(e => e.Vigente)
                    .HasPrecision(1)
                    .HasColumnName("VIGENTE");
            });

            modelBuilder.Entity<VwConvocatoriaFiltro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CONVOCATORIA_FILTROS");

                entity.Property(e => e.Bandera)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BANDERA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.IdIdioma)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_IDIOMA");

                entity.Property(e => e.IdareaEstudio)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDAREA_ESTUDIO");

                entity.Property(e => e.IdclasificacionEspecialidad)
                    .HasColumnType("NUMBER(38)")
                    
                    .HasColumnName("IDCLASIFICACION_ESPECIALIDAD");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IdmodalidadPrograma)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDMODALIDAD_PROGRAMA");

                entity.Property(e => e.IdnivelAcademico)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDNIVEL_ACADEMICO");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NombreNivelAcademico)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_NIVEL_ACADEMICO");

                entity.Property(e => e.NombrePais)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PAIS");
            });

            modelBuilder.Entity<VwParticipantePostulacionFinabece>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PARTICIPANTE_POSTULACION_FINABECE");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.CierraPensumProximoAnio)
                    .HasPrecision(1)
                    .HasColumnName("CIERRA_PENSUM_PROXIMO_ANIO");

                entity.Property(e => e.CuiDpi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CUI_DPI");

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHANACIMIENTO");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.IdconvocatoriaFinabece)
                    .HasColumnType("NUMBER")
                    
                    .HasColumnName("IDCONVOCATORIA_FINABECE");

                entity.Property(e => e.IdestatusPostulacion)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IDESTATUS_POSTULACION");

                entity.Property(e => e.Idparticipante)
                    .HasColumnType("NUMBER(38)")
                    
                    .HasColumnName("IDPARTICIPANTE");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.PromedioAplica)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROMEDIO_APLICA");

                entity.Property(e => e.Sexo)
                    .HasPrecision(2)
                    .HasColumnName("SEXO");
            });

            modelBuilder.Entity<VwProgramaConvocatorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PROGRAMA_CONVOCATORIA");

                entity.Property(e => e.AvalSegeplan)
                    .HasPrecision(1)
                    .HasColumnName("AVAL_SEGEPLAN");

                entity.Property(e => e.Bandera)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BANDERA");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.CorreoElectronicoContacto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ELECTRONICO_CONTACTO");

                entity.Property(e => e.DescripcionConvocatoria)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_CONVOCATORIA");

                entity.Property(e => e.DescripcionPrograma)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_PROGRAMA");

                entity.Property(e => e.Dirigido)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DIRIGIDO");

                entity.Property(e => e.DuracionAnio)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_ANIO");

                entity.Property(e => e.DuracionDia)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_DIA");

                entity.Property(e => e.DuracionMes)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_MES");

                entity.Property(e => e.DuracionSemana)
                    .HasPrecision(2)
                    .HasColumnName("DURACION_SEMANA");

                entity.Property(e => e.FechaFinAplicacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN_APLICACION");

                entity.Property(e => e.FechaFinPrograma)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_FIN_PROGRAMA");

                entity.Property(e => e.FechaInicioAplicacion)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO_APLICACION");

                entity.Property(e => e.FechaInicioPrograma)
                    .HasColumnType("DATE")
                    .HasColumnName("FECHA_INICIO_PROGRAMA");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Idconvocatoria)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCONVOCATORIA");

                entity.Property(e => e.Idpais)
                    .HasColumnType("NUMBER(38)")
                    
                    .HasColumnName("IDPAIS");

                entity.Property(e => e.IdprogramaAcademico)
                    .HasColumnType("NUMBER(38)")
                    
                    .HasColumnName("IDPROGRAMA_ACADEMICO");

                entity.Property(e => e.InformacionContacto)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("INFORMACION_CONTACTO");

                entity.Property(e => e.InstitucionProponente)
                    .HasPrecision(1)
                    .HasColumnName("INSTITUCION_PROPONENTE");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NACIONALIDAD");

                entity.Property(e => e.NombreConvocatoria)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CONVOCATORIA");

                entity.Property(e => e.NombreCooperante)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COOPERANTE");

                entity.Property(e => e.NombreModalidad)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MODALIDAD");

                entity.Property(e => e.NombrePrograma)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PROGRAMA");

                entity.Property(e => e.NombreTipoBeca)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_TIPO_BECA");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.OtrosBeneficios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OTROS_BENEFICIOS");

                entity.Property(e => e.PaisCooperante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PAIS_COOPERANTE");

                entity.Property(e => e.RequisitoEdad)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("REQUISITO_EDAD");
            });

            modelBuilder.Entity<VwTestimonio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TESTIMONIO");

                entity.Property(e => e.Bandera)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BANDERA");

                entity.Property(e => e.Fechas)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FECHAS");

                entity.Property(e => e.Idtestimonio)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTESTIMONIO");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN");

                entity.Property(e => e.ImagenThumb)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN_THUMB");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NombrePais)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PAIS");

                entity.Property(e => e.NombreTestimonio)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_TESTIMONIO");

                entity.Property(e => e.Programa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA");

                entity.Property(e => e.Testimonio)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIO");

                entity.Property(e => e.TestimonioResumen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIO_RESUMEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
