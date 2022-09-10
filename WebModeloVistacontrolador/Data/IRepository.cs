using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Data

{
    // Creacion de interfaz 
    public interface IRepository
    {
        // Creacion de metodos  para Hacer el crud 
        public Task Save<T>(T obj) where T : Entity;
        public void Delete<T>(T obj) where T : Entity;
        public void Update<T>(T obj) where T : Entity;
        public Task< List<T>> GetAll<T>() where T : Entity;
     
        public  Task Commit();
      
    }
}
