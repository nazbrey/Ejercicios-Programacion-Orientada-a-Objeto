namespace WebModeloVistacontrolador.Models
{
    public class Coordinator : Entity
    {
        public string Name { get; private set; }
        public int Document { get; private set; }
        public string Area { get; private set; }

        public Guid EnterpriseId { get; private set; }
        
        public List<Worker> workers { get; private set; }

        private Coordinator(int id, string name, int document, string area, Guid enterpriseId) : base(id)
        {
            Name = name;
            Document = document;
            Area = area;
            EnterpriseId = enterpriseId;    
        }

        public static Coordinator  Build(int id, string name, int document, string area, Guid enterpriseId) 
        {
            return new Coordinator(id, name, document, area, enterpriseId);
        }

        public void AddWork( Worker worker) 
        {
            this.workers.Add(worker);      
        }
    }
}
