using BECAS_SEGEPLAN_DATA.Models;
using BECAS_SEGEPLAN_DATA.Objetos;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public  interface IConvocatoriaData
    {
        IEnumerable<Convocatorium> Listado();

        IEnumerable<Convocatorium> ListadoAsociadoConvocatoria();

        bool ConvocatoriaFinabece(decimal IdConvocatoria);
        Convocatorium ObtenerId(decimal IdAreaEstudio);

        RespuestaCRUD Insertar(Convocatorium areaestudio);
        RespuestaCRUD Update(Convocatorium areaestudio);
        RespuestaCRUD Delete(decimal IdConvocatoria, short IdUsuario);
    }
}
