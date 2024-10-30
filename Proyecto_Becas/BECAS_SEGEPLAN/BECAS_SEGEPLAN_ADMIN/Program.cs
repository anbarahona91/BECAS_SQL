using Microsoft.EntityFrameworkCore;
using BECAS_SEGEPLAN_DATA;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Implementaciones;
using BECAS_SEGEPLAN_DATA.Models;
using DevExtreme.AspNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddCors(options => 
    options.AddPolicy("AllowAnyMethod", builder =>
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        }
    
    )
);



string connection = builder.Configuration.GetConnectionString("OracleConnection");

builder.Services.AddDbContext<ModelContext>(options => options.UseOracle(connection));

builder.Services.AddScoped<ICooperanteData, CooperanteData>();
builder.Services.AddScoped<IPaisData, PaisData>();
builder.Services.AddScoped<IAreaEstudioData, AreaEstudioData>();
builder.Services.AddScoped<ISubareaEstudioData, SubareaEstudioData>();
builder.Services.AddScoped<IClasificacionEspecialidadData, ClasificacionEspecialidadData>();
builder.Services.AddScoped<IIdiomaProgramaData, IdiomaProgramaData>();
builder.Services.AddScoped<INivelAcademicoData, NivelAcademicoData>();
builder.Services.AddScoped<IConvocatoriaData, ConvocatoriaData>();
builder.Services.AddScoped<IModalidadProgramaData, ModalidadProgramaData>();
builder.Services.AddScoped<IProgramaAcademicoData, ProgramaAcademicoData>();
builder.Services.AddScoped<ITipoBecaData, TipoBecaData>();
builder.Services.AddScoped<IConvocatoriaPaisData, ConvocatoriaPaisData>();
builder.Services.AddScoped<IPublicoData, PublicoData>();
builder.Services.AddScoped<IConvocatoriaPublicoData, ConvocatoriaPublicoData>();
builder.Services.AddScoped<IConvocatoriaNivelAcademicoData, ConvocatoriaNivelAcademicoData>();
builder.Services.AddScoped<IConvocatoriaNivelAcademicoRequeridoData, ConvocatoriaNivelAcademicoRequeridoData>();
builder.Services.AddScoped<IConvocatoriaIdiomaData, ConvocatoriaIdiomaData>();
builder.Services.AddScoped<IConvocatoriaIdiomaRequeridoData, ConvocatoriaIdiomaRequeridoData>();
builder.Services.AddScoped<IBeneficioData, BeneficioData>();
builder.Services.AddScoped<IConvocatoriaBeneficioData, ConvocatoriaBeneficioData>();
builder.Services.AddScoped<IConvocatoriaEnlaceData, ConvocatoriaEnlaceData>();
builder.Services.AddScoped<IConvocatoriaProgramaEstudioData, ConvocatoriaProgramaEstudioData>();
builder.Services.AddScoped<IConvocatoriaDocumentoData, ConvocatoriaDocumentoData>();
builder.Services.AddScoped<IVWParticipantePostulacionFinabeceData, VWParticipantePostulacionFinabeceData>();
builder.Services.AddScoped<ITipoEstatusPostulacionFinabeceData, TipoEstatusPostulacionFinabeceData>();
builder.Services.AddScoped<IParticipanteData, ParticipanteData>();
builder.Services.AddScoped<IDepartamentoData, DepartamentoData>();
builder.Services.AddScoped<IMunicipioData, MunicipioData>();
builder.Services.AddScoped<IComunidadLinguisticaData, ComunidadLinguisticaData>();
builder.Services.AddScoped<IEtniaData, EtniaData>();
builder.Services.AddScoped<IDiscapacidadData, DiscapacidadData>();
builder.Services.AddScoped<IConvocatoriaFinabeceIngresoFamiliarData, ConvocatoriaFinabeceIngresoFamiliarData>();
builder.Services.AddScoped<IConvocatoriaFinabeceGastoFamiliarData, ConvocatoriaFinabeceGastoFamiliarData>();
builder.Services.AddScoped<IConvocatoriaFinabeceTipoGastoEstudioData, ConvocatoriaFinabeceTipoGastoEstudioData>();
builder.Services.AddScoped<ITipoGastoEstudioFinabeceData, TipoGastoEstudioFinabeceData>();
builder.Services.AddScoped<ITipoParentescoFinabeceData, TipoParentestoFinabeceData>();
builder.Services.AddScoped<ITipoGastoFamiliaFinabeceData, TipoGastoFamiliaFinabeceData>();
builder.Services.AddScoped<IConvocatoriaFinabeceDocumentoData, ConvocatoriaFinabeceDocumentoData>();

builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseCors("AllowAnyMethod");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
