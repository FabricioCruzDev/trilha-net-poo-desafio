using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 8", imei: "d55d45dd5", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "12345", modelo: "Modelo 8", imei: "d55d45dd5", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");