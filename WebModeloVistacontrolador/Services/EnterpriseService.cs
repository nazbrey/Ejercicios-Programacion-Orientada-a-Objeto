using WebModeloVistacontrolador.Data;
using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Services
{
    public class EnterpriseService
    {
        // Agregacion
        private readonly IRepository repository;
        // Constructor
        public EnterpriseService(IRepository repository)
        {
            this.repository = repository;
        }

        // Crear
        public async Task Crear(Enterprise enterprise)
        {
            if(enterprise is null)
            
                throw new Exception("Empresa vacia");

            await repository.Save(enterprise);
            await repository.Commit();

        }
        // Listar 
        public async Task<List<Enterprise>> GetAllenterprise()
        {
            return await this.repository.GetAll<Enterprise>();
        }
        // Modificar 
        public void Update(Enterprise enterprise)
        {
            if (enterprise is null)
                throw new Exception("Trabajador  Esta vacio");

            repository.Update(enterprise);
        }
        //Eliminar
        public void Delete(Enterprise enterprise)
        {
            if (enterprise is null)
                throw new Exception("Trabajador  Esta vacio");

            repository.Delete(enterprise);
        }
    }
}
