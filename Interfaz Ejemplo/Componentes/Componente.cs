using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Ejemplo.Componentes
{
    internal abstract class Componente
    {
        public void ensamblar()
        {

            Console.WriteLine("Conectar directamente a la tarjeta interna del celular");
        }
        public abstract void voltaje();
    }
}
