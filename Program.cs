// See https://aka.ms/new-console-template for more information
using DesafioPOO.Models;

Console.WriteLine("Smartphone Apple \n");
Iphone iphone1 = new Iphone(numero: "933948130", modelo: "Iphone X", imei: "001970-01-010000-0", memoria: 128);
iphone1.ToString();
iphone1.Ligar("11933948130");
iphone1.desligarLigacao();
iphone1.ReceberLigacao("0000000000");

iphone1.InstalarAplicativo("Dio.me");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Smartphone Nokia \n");
Nokia nokia1 = new Nokia(numero: "12540120", modelo: "Nokia 110", imei: "001223-01-0156780-5", memoria: 128);
nokia1.ToString();
nokia1.Ligar("11933948130");
nokia1.desligarLigacao();
nokia1.ReceberLigacao("Dio.me");
