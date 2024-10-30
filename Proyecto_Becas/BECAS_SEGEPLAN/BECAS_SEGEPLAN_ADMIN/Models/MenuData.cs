namespace BECAS_SEGEPLAN_ADMIN.Models
{

    public class MenuItem
    {
        public string text { get; set; }
        public bool disabled { get; set; }
        public string icon { get; set; }
        public string ruta { get; set; }
        public IEnumerable<MenuItem> items { get; set; }
    }
    public class MenuData
    {
        public static readonly IEnumerable<MenuItem> Opciones = new[] {
            new MenuItem {
                text = "Inicio",
                ruta = "/Principal"
            },
            new MenuItem {
                text = "Área estudio",
                items = new[] {
                    new MenuItem {
                        text = "Área estudio",
                        ruta = "/AreaEstudio",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Subárea estudio",
                        ruta = "/SubAreaEstudio",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Clasificación especialidades",
                        ruta = "/ClasificacionEspecialidad",
                        icon = ""
                    }

                }
            },
            new MenuItem {
                text = "Programas",
                items = new[] {
                    new MenuItem {
                        text = "Cooperante",
                        ruta = "/Cooperante",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Programa académico",
                        ruta = "/ProgramaAcademico",
                        icon = ""
                    }
                }
            },
            new MenuItem {
                text = "Convocatorias",
                items = new[] {
                    new MenuItem {
                        text = "Convocatoria",
                        ruta = "/Convocatoria",
                        icon = ""
                    }
                }
            },
            new MenuItem {
                text = "Finabece",
                items = new[] {
                    new MenuItem {
                        text = "Consulta postulación",
                        ruta = "/ConvocatoriaFinabeceConsulta/Index/101",
                        icon = ""
                    }
                }
            },
            new MenuItem {
                text = "Catálogos",
                items = new[] {
                    new MenuItem {
                        text = "Idioma del programa",
                        ruta = "/IdiomaPrograma",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Nivel académico",
                        ruta = "/NivelAcademico",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Tipo de beca",
                        ruta = "/TipoBeca",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Modalidad programa",
                        ruta = "/ModalidadPrograma",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Tipo público",
                        ruta = "/Publico",
                        icon = ""
                    },
                    new MenuItem {
                        text = "Beneficio",
                        ruta = "/Beneficio",
                        icon = ""
                    }
                }
            }

        };
    }
}
