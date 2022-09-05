using PGenerico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGenerico.Collaborators
{
    internal class Enterprise <T> where T : Entity
    {
        private List<T> Asociados { get; set; }

        public Enterprise() :base()
        {

            Asociados = new List<T>();
        }
        public void Asociar(T obj) {

            obj.Id = "1234";

            Asociados.Add(obj);
        
        }
        

    }
}
