namespace WebModeloVistacontrolador.Models
{
    // Clase y realcion 
    public class Enterprise :Entity
        {
            // Atributos 
            public string Name { get;  private set; }
            public string Adress { get; private set; }
            public int Nit { get; private set; }
            public List<Worker> Workers { get; private set; }    
            public List<Coordinator> coordinators { get; private set; } 
            //public Ceo ceo { get; private set; }    Preguntas para el profe como implemento esta entidad si es sola una 


        //Constructor privado
        private Enterprise(int id, string name, string adress, int nit) : base(id)
        {
            Name = name;
            Adress = adress;
            Nit = nit;
        }
        public Enterprise Build( int id, string name, string adress, int nit)
        {
            return new Enterprise(id, name, adress, nit);   
        }
        public void AddWorker( Worker worker)
        {
            this.Workers.Add(worker);
        }
        public void AddCordinator(Coordinator coordinator)
        {
            this.coordinators.Add(coordinator);
        }
       
    }
}
