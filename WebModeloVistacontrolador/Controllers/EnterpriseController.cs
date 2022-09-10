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
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();  
        }


        //Vista despues de crear
        [HttpGet]
        public IActionResult Update(int id, string name, string adress, int nit)
        {
            var empresa =  Enterprise.Build(id,name,adress,nit);
               
            return View(empresa);
        }
        //Modificar
        [HttpPost]
        public IActionResult Udpate(int id, string name, string adress, int nit)
        {
            var empresa = Enterprise.Build(id, name, adress, nit);
            this.enterpriseService.Update(empresa);
            return RedirectToAction(nameof(Index)); ;
        }


        //Elimanar

        [HttpGet]
        public IActionResult Delete(int id, string name, string adress, int nit)
        {
            var empresa = Enterprise.Build(id, name, adress, nit);

            return View(empresa);
        }

        [HttpPost]
        public IActionResult Delete1(int id, string name, string adress, int nit)
        {
            var empresa = Enterprise.Build(id, name, adress, nit);
            this.enterpriseService.Delete1(empresa);
            return RedirectToAction(nameof(Index)); ;
        }


        // Vista despues de Eliminar


    }
}
