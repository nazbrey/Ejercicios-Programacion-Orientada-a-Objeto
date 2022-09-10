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
        public void  Update(Enterprise empresa)
        {
            if (empresa is null)
                throw new Exception("Empresa Vacia");

            this.repository.Update(empresa);
            this.repository.Commit();
        }
        //Eliminar
        public void Delete1(Enterprise empresa)
        {
            if (empresa is null)
                throw new Exception("Trabajador  Esta vacio");

            this.repository.Delete(empresa);
            this.repository.Commit();
        }
    }
}
