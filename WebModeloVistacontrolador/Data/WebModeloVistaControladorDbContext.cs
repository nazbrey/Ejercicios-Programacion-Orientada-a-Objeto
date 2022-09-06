using Microsoft.EntityFrameworkCore;
using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Data
{
    public class WebModeloVistaControladorDbContext : DbContext
    {
         public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<Worker> Works { get; set; }

        public WebModeloVistaControladorDbContext(DbContextOptions<WebModeloVistaControladorDbContext> options) : base(options)
        {

        }
    }
}
