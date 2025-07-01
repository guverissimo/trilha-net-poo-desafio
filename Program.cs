using DesafioPOO.Models;

Console.Clear();
System.Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("11940028922", "V2", "1111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("----------------------------------------");

System.Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("11940028922", "14 Pro", "1111111", 256);
iphone.Ligar();
iphone.InstalarAplicativo("X");