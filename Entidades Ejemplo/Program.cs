// See https://aka.ms/new-console-template for more information
using Entidades_Ejemplo.Entidades;
using Entidades_Ejemplo.Factory;
Console.WriteLine("Hello, World!");
// Creamos las entidades 
var empresa = (Empresa)FactoryEntidades.CrearEmpresa();
empresa.Direccion = "Calle 1";
var Dueño = (Dueño)FactoryEntidades.CrearDueño();
Dueño.Nombre = "Nazbrey";
var Representante  = (Representante)FactoryEntidades.CrearRepresentante();
Representante.Nombre = "Sebastian";
var Trabajdor = (Trabajador)FactoryEntidades.CrearTrabajador();
Trabajdor.Nombre = "Raul";