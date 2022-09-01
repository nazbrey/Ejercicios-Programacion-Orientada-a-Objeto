using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPolimorfismo
{
    internal class Cuadrado: Forma
    {
        public Cuadrado( string Lado1, String Lado2):base(Lado1,Lado2)
        {
                
        }
        public void CalcularArea() {

            int Lado1int = Convert.ToInt32(lAdo1);
            int Lado2int = Convert.ToInt32(lAdo2);
            
            double Area = (Lado1int * Lado2int);

            Console.WriteLine("El resultado del Cuadrado es "+Area);
        
        }

    }
}
