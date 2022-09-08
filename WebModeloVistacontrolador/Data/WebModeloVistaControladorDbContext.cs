using Microsoft.EntityFrameworkCore;
using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Data
{
    // Creamos Conexion 
    public class WebModeloVistaControladorDbContext : DbContext
    {
         public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Worker> Works { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public WebModeloVistaControladorDbContext(DbContextOptions<WebModeloVistaControladorDbContext> options) : base(options)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {

        }
    }
}
