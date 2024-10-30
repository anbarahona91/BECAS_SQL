using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using BECAS_SEGEPLAN_ADMIN.Models;

namespace BECAS_SEGEPLAN_ADMIN.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index(LoginUser Datos)
        {
            if(Datos.Usuario != "Admin" && Datos.Password !="becas")
            {
               return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.TituloOpcion = "Portal de administración";
                return View();
            }
            

            
        }

        [HttpGet]
        public object GetMenu(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(MenuData.Opciones, loadOptions);
        }
    }
}
