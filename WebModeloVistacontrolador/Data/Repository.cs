using WebModeloVistacontrolador.Models;
using Microsoft.EntityFrameworkCore;


namespace WebModeloVistacontrolador.Data
{
    //Herencia de interface Irepositorio 
    public class Repository : IRepository
    {
        // Agregacion A al contexto una variable que guarda variable  
        private readonly WebModeloVistaControladorDbContext context;

        // constructor del repositorio 
        public Repository(WebModeloVistaControladorDbContext context)
        {
                this.context = context;
        }

        // commit 
        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        //Funcion de elimnar 
        public  void Delete<T>(T obj) where T : Entity
        {
           context.Set<T>().Remove(obj);
        }
        // Funcion de Listar 
        public async Task<List<T>> GetAll<T>() where T : Entity
        {
            return await context.Set<T>().ToListAsync();
        }
        // Funcion de Guardar 
        public async Task Save<T>(T obj) where T : Entity
        {
            await context.Set<T>().AddAsync(obj);
        }
        // Funcion de Actualizar
        public  void Update<T>(T obj) where T : Entity
        {
           context.Set<T>().Update(obj);
        }

     

    


        // funcion buscar 

    }
}
