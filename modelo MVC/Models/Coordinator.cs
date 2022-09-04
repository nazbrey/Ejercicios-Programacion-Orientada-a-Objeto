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
        public List<CoordinatorWork> coordinatorWork { get; private set; }

        public Coordinator(int id, string name) : base(id)
        { 
            this.Name = name;
            this.Description = name;
            coordinatorWork = new();
        }
        public void AddWork(string workId) 
        {
            this.coordinatorWork.Add(
                new CoordinatorWork(this.Id,Guid.NewGuid().ToString(), workId));
        
        }
    }
}
