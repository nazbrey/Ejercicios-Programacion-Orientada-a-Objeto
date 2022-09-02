using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPolimorfismo
{
    internal class Rectangulo : Forma
    {
        public Rectangulo(string Lado1, String Lado2) : base(Lado1, Lado2)
        {
        }

        public void CalcularArea()
        {

            int Lado1int = Convert.ToInt32(lAdo1);
            int Lado2int = Convert.ToInt32(lAdo2);

            double Area = Lado1int * Lado2int;

            Console.WriteLine("El resultado del  area del rectangulo con base  " + Lado1int +" y altura "+Lado2int+" es :"+Area);

        }
    }
}
