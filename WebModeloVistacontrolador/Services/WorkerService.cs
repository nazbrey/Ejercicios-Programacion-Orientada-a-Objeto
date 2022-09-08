using WebModeloVistacontrolador.Data;
using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Services
{
    public class WorkerService
    {
        // Agregacion 
        public readonly IRepository repository;

        // Constructor
        public WorkerService(IRepository repository)
        {
            this.repository = repository;
        }
        // Crear 
        public async Task Crear( Worker worker)
        {
            if(worker is null)
                throw new Exception("Trabajador  Esta vacio");

            await repository.Save(worker);
            await repository.Commit();

        }
        //Listar 
        public async Task<List<Worker>> GetAllWorker()
        {
            return await repository.GetAll<Worker>();
        }
        // Modificar 
        public  void Update(Worker worker)
        {
            if (worker is null)
                throw new Exception("Trabajador  Esta vacio");

             repository.Update(worker);
        }
        //Eliminar
        public void Delete(Worker worker)
        {
            if (worker is null)
                throw new Exception("Trabajador  Esta vacio");

            repository.Delete(worker);
        }
    }
}
