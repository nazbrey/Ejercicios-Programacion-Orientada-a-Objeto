// See https://aka.ms/new-console-template for more information
using ejemploPolimorfismo;

Forma cu = new Cuadrado("20", "30");
var cua = (Cuadrado)cu;
Console.WriteLine(cua.lAdo1);

Forma R = new Rectangulo("40", "60");
var rec= (Rectangulo)R;
rec.CalcularArea();

