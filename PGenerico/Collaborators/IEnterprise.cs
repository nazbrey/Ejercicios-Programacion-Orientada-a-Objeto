using PGenerico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGenerico.Collaborators
{
    internal interface IEnterprise<T> where  T : Entity
    {
        public void Asociar(T obj);
    }
}
