using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Pegando o celular Nokia na mão");
Nokia nokia = new Nokia ("51987451241", "N95", "358240051111111", 1600);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Pegando o Iphone na mão");
Iphone iphone = new Iphone("11998563212", "16", "354994020123456", 262144);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");