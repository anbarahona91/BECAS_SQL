using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface IBeneficioData
    {
        IEnumerable<Beneficio> Listado();

        IEnumerable<Beneficio> ListadoAsociadoConvocatoria();
        Beneficio ObtenerId(int IdBeneficio);

        RespuestaCRUD Insertar(Beneficio Beneficio);
        RespuestaCRUD Update(Beneficio Beneficio);
        RespuestaCRUD Delete(decimal IdBeneficio, short IdUsuario);
    }
}
