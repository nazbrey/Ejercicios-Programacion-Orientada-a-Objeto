﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_MVC.Models
{
    internal class Worker : Entity

    {
        public int Cedula { get; private set; }
        public List<CoordinatorWork> coordinatorWork { get; private set; }

        public Enterprise Enterprise { get; private set; }
        public Worker(int id, int cedula, Enterprise enterprise) : base(id)
        {
            Cedula = cedula;
            coordinatorWork = new();
            Enterprise = enterprise ;
        }
        public void  AddCoordinator(string CoordinatorId) 
        { 
         this.coordinatorWork.Add(
             new CoordinatorWork(this.Id, Guid.NewGuid().ToString(), CoordinatorId));
        }
    }
}
