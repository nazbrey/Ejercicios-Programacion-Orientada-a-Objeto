using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Ejemplo.Accesorios
{
    internal class Auricular : IAccesorio
    {
        public void conectar() {
            Console.WriteLine("Se  conecto por medio de  bluethoo y alambrico ");
        }
    }
}
