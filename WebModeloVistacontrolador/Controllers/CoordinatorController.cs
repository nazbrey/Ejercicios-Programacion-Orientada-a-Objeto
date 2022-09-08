using Microsoft.AspNetCore.Mvc;
using WebModeloVistacontrolador.Models;
using WebModeloVistacontrolador.Services;

namespace WebModeloVistacontrolador.Controllers
{
    public class CoordinatorController : Controller
    {
        // Agregacion al servicio 
        private readonly CoordinatorService coordinatorService;
        //Cinstructor Del controller 
        public CoordinatorController(CoordinatorService coordinatorService)
        {
            this.coordinatorService = coordinatorService;
        }
        //Vista index 
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var coordinator = await coordinatorService.GetAllCoordinator();
            return View(coordinator);
        }
        //Creacion
        [HttpPost]
        public async Task<IActionResult> Create(int id, string name, int document, string area, Guid enterpriseId)
        {
            var coordinator = Coordinator.Build(id, name, document, area, enterpriseId);
            return View();
        }
        //Vista Creacion 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Modificar
        [HttpPost]
        public IActionResult Upate(Coordinator coordinator)
        {
            coordinatorService.Update(coordinator);
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
        public IActionResult Delete(Coordinator coordinator)
        {
            coordinatorService.Delete(coordinator);
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
