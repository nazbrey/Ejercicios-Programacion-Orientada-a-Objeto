using Microsoft.AspNetCore.Mvc;
using WebModeloVistacontrolador.Models;
using WebModeloVistacontrolador.Services;

namespace WebModeloVistacontrolador.Controllers
{
    public class EnterpriseController : Controller
    {
        private readonly EnterpriseService enterpriseService;

        public EnterpriseController(EnterpriseService enterpriseService)
        {
            this.enterpriseService = enterpriseService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var enterprise =await enterpriseService.GetAllenterprise();
            return View(enterprise);
        }
        [HttpPost]
        public async Task<IActionResult> Create( int id, string name, string adress, int  nit)
        { 
            var enterprise = Enterprise.Build(id, name, adress, nit);
            await this.enterpriseService.Crear(enterprise);
            return View();

        }
        [HttpGet]
        public  IActionResult Crearte()
        {
            return View();  
        }
        //Modificar
        [HttpPost]
        public IActionResult Upate(Enterprise enterprise)
        {
            enterpriseService.Update(enterprise);
            return View();
        }
        //Vista despues de crear
        [HttpGet]
        public IActionResult Upate()
        {
            return View();
        }

        //Elimanar
        [HttpPost]
        public IActionResult Delete(Enterprise enterprise)
        {
            enterpriseService.Delete(enterprise);
            return View();

        }
        // Vista despues de Eliminar
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

    }
}
