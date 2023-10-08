using CelularPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "67436", modelo: "G21 4G", imei: "622222", memoria: 1222);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "23726", modelo: "Iphone XR", imei: "433433", memoria: 1111);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");