using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Ejemplo.Componentes
{
    internal class Procesador: Componente
    {
        public override void voltaje()
        {
            Console.WriteLine("voltaeje de 5");
        }
    }
}
