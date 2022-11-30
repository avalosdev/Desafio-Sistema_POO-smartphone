using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "1234-4321", modelo: "G21", imei: "47845es8", memoria: 128);
Smartphone iphone = new Iphone(numero:"0909-1234", modelo:"Iphone 11 pro max", imei:"E7IHn8", memoria: 256);

Console.WriteLine("Smartphone Nokia:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");
nokia.Configuracoes();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Deezer");
iphone.Configuracoes();



