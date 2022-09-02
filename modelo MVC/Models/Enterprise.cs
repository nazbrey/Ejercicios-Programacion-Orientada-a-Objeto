using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_MVC.Models
{
    internal  class Enterprise : Entity
    {
        public string Name { get; private set; }    
        
        public string Direccion { get; private set; }
    
        public List<Coordinator> Coordinators { get; private set; }
        
        public List<Worker> Workers { get; private set; }

        public Enterprise(int id, string Name, string direccion,Coordinator coordinator, Worker worker) : base(id) 
	{
            Coordinators = new List<Coordinator> (); 
            Workers = new List<Worker> ();
            this.Name = Name;
            this.Direccion = direccion;

	}
        public void AddCoordinators(Coordinator coordinator) 
        {
            this.Coordinators.Add(coordinator);
        }
        public void AddWorkes(Worker worker) 
        {
            this.Workers.Add(worker);
        }
    }

}
