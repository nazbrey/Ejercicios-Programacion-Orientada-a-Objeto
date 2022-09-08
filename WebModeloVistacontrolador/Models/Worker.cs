using WebModeloVistacontrolador.Models;

namespace WebModeloVistacontrolador.Models
{
    public class Worker : Entity
    {
        public String Name { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public  Guid EnterpriseId { get; private set; }
        public int Documento { get; private set; }
       



        // Constructor privado 
        private Worker(int id, string name,DateTime fechaNacimiento, Guid enterpriseId, int documento) : base(id)
        {
            Name = name;

            EnterpriseId = enterpriseId;
            FechaNacimiento = fechaNacimiento;
            Documento = documento;
            
        }
        // Contructor Que se puede llamar 
        public static Worker Build(int id, string name, DateTime fechaNacimiento, Guid enterpriseId,int documento)
        {
            return new Worker(id, name, fechaNacimiento, enterpriseId, documento);

        }
    }
}
