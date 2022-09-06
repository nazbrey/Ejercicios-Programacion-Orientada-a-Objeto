using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_MVC.Models
{
    internal class CoordinatorWork : Entity
    {
        public  string WorkeId { set; private get;}
        public string CoordinatorId { set; private get; }

        public CoordinatorWork(int id,  string workeId, string coordinatorId) : base(id)     
        {
            WorkeId = workeId;
            CoordinatorId = coordinatorId;  
        }
    }
}
