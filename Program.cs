using DesafioPOO.Models;

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "145688", modelo: "iphone6", imei: "22222", memoria: 84);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234", modelo: "AX2055", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");



