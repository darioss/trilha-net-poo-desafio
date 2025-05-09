using DesafioPOO.Models;

Nokia nokia = new Nokia("(48) 98987-5908","C10","NB2837493947BR", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatapp");

Iphone iphone = new Iphone("(48) 98730-9493", "Iphone 17", "NB9847393483BR", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");