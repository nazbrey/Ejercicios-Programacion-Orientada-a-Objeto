using WebModeloVistacontrolador.Data;
using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Services
{
    public class CoordinatorService
    {
        // Agregacion 
        public readonly IRepository repository;
        // Constructor 
        public CoordinatorService(IRepository repository)
        {
            this.repository = repository;
        }
        // Crear 
        public async Task Create(Coordinator coordinator)
        {
            if (coordinator is null)
                throw new Exception("coordinador es nulo");
            await repository.Save(coordinator);
            await repository.Commit();
        }
        // Listar 
        public async Task<List<Coordinator>> GetAllCoordinator()
        {
            return await this.repository.GetAll<Coordinator>();
        }

        // Modificar 
        public void Update(Coordinator coordinator)
        {
            if (coordinator is null)
                throw new Exception("Trabajador  Esta vacio");

            repository.Update(coordinator);
        }
        //Eliminar
        public void Delete(Coordinator coordinator)
        {
            if (coordinator is null)
                throw new Exception("Trabajador  Esta vacio");

            repository.Delete(coordinator);
        }
    }
}
