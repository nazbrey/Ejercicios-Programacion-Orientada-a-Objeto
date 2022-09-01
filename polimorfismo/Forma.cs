using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPolimorfismo
{
    internal class Forma
    {
       
        public string lAdo1 { get; protected set; }
        public string lAdo2 { get; protected set; }
        public Forma(string lAdo1, string lAdo2)
        {
            this.lAdo1 = lAdo1;
            this.lAdo2 = lAdo2;
        }
        }
}
