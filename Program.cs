using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - OK

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "31999887766", modelo: "Modelo Nokia 1", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "31988775544", modelo: "Modelo iPhone 1", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");