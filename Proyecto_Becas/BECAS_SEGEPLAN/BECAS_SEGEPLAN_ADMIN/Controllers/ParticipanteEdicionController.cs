using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_DATA.Interfaces;
using BECAS_SEGEPLAN_DATA.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class ParticipanteEdicionController : Controller
    {
        private readonly IParticipanteData _Repositorio;

        public ParticipanteEdicionController(IParticipanteData repositorio)
        {
            _Repositorio = repositorio;
        }

        public IActionResult Index(decimal Id)
        {
            Participante modelo = _Repositorio.ObtenerId(Id);


            return View("Index",modelo);
        }
    }
}
