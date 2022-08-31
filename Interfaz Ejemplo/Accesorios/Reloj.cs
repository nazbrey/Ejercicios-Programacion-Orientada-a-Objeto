using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Ejemplo.Accesorios
{
    internal class Reloj : IAccesorio
    {
        public void conectar() { 
        Console.WriteLine("Se conecta Por medio de Bluethoo")
        }
    }
}
