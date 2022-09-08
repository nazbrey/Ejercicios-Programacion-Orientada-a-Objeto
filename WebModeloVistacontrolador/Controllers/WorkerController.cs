using Microsoft.AspNetCore.Mvc;
using WebModeloVistacontrolador.Models;
using WebModeloVistacontrolador.Services;

namespace WebModeloVistacontrolador.Controllers
{
    public class WorkerController : Controller
    {
        private readonly WorkerService workerService;
        public WorkerController(WorkerService workerService)
        {
            this.workerService = workerService;
        }

        //Vista Index 
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var worker= await workerService.GetAllWorker();
            return View(worker);    
        }
        // Crear
        [HttpPost]
        public async Task<IActionResult> Create(int id, string name, DateTime fechaNacimiento,Guid enterpriseId,int documento )
        {
            var worker =  Worker.Build(id, name, fechaNacimiento, enterpriseId, documento);
            return View();
        }
        //Vista Crear
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Modificar
        [HttpPost]
        public IActionResult Upate(Worker worker)
        {
            workerService.Update(worker);
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
        public IActionResult Delete(Worker worker)
        {
            workerService.Delete(worker);
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
