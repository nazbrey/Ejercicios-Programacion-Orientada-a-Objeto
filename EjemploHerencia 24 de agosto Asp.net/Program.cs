// See https://aka.ms/new-console-template for more information


using EjemploHerencia_24_de_agosto_Asp.net;

Carro c = new Carro("Mustang ", "Gdm56","Carro","R500");
Moto M = new Moto("Gsxs", "Gmd45g", "Moto","T6000");



Console.WriteLine("PLaca:" + M.Placa + System.Environment.NewLine+"Referencia:" + M.Referencia + System.Environment.NewLine + "Tipo Vehiculo:" + M.TipoVehiculo+System.Environment.NewLine ) ;

Console.WriteLine("PLaca:" + c.Placa + System.Environment.NewLine + "Referencia" + c.Referencia+ System.Environment.NewLine + "Tipo Vehiculo:" + c.TipoVehiculo);