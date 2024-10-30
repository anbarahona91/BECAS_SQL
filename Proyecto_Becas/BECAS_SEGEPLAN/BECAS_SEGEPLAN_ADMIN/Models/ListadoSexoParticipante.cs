namespace BECAS_SEGEPLAN_ADMIN.Models
{
    public class SexoParticipante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListadoSexoParticipante
    {
        public List<SexoParticipante> Listado { get; set; }

        public void GenerarListado()
        {
            Listado = new List<SexoParticipante>();

            SexoParticipante servicio = new SexoParticipante();
            servicio.Id = 1;
            servicio.Nombre = "Hombre";

            SexoParticipante servicio1 = new SexoParticipante();
            servicio1.Id = 2;
            servicio1.Nombre = "Mujer";

            SexoParticipante servicio2 = new SexoParticipante();
            servicio2.Id = 3;
            servicio2.Nombre = "Prefiere no mencionar";



            Listado.Add(servicio);
            Listado.Add(servicio1);
            Listado.Add(servicio2);

        }
    }
}
