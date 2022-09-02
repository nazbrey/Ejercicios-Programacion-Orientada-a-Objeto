using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_MVC.Models
{
    internal class Coordinator : Entity
    {
        public string Name { get; private set; }
       
        public string Description { get; private set; }
        public List<Enterprise> Enterprises { get; private set; }
        public Coordinator(int id, string name, Enterprise enterprise ) : base(id)
        { 
            this.Name = name;
            Enterprise = enterprise;
            this.Description = name;    
        }
    }
}
