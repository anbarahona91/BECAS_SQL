using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_DATA.Interfaces
{
    public interface ITipoInstitucionEducativaData
    {
        IEnumerable<TipoInstitucionEducativa> Listado();
        TipoInstitucionEducativa ObtenerId(int Id);
    }
}
