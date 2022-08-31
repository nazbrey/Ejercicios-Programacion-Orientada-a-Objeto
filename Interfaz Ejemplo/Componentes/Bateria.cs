using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Ejemplo.Componentes
{
    internal class Bateria: Componente
    {
        public override void voltaje()
        {
            Console.WriteLine("bateria es de 45 voltios");
        }
    }
}
