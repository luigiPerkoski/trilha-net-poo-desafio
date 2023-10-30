using DesafioPOO.Models;

WriteLine("Smartphone Nokia:");
Smartphone tijolo = new Nokia("999999999", "Tijolao", "123456789", 256);
tijolo.Ligar();
tijolo.InstalarAplicativo("Dio");

Smartphone se = new IPhone("888888888", "Iphone SE", "987654321", 128);
se.ReceberLigacao();
se.InstalarAplicativo("Dio");