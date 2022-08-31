// See https://aka.ms/new-console-template for more information
using Interfaz_Ejemplo.Componentes;
using Interfaz_Ejemplo.Accesorios;
using Interfaz_Ejemplo;
using Interfaz_Ejemplo.Celulares;

Console.WriteLine("Hello, World!");

IAccesorio Accesorio = new Auricular();
IAccesorio Accesorio1 = new Reloj();

Celular celular = new Celular(Accesorio, Accesorio1);

