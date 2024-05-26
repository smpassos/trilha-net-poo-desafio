using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "98799-7452", modelo: "Nokia C20", imei: "001987-05-010000-0", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone (numero: "99852-5153", modelo: "Iphone 14", imei: "001970-01-010000-0", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");