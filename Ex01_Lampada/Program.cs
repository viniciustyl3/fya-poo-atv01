using Ex01_Lampada;

Console.WriteLine("=== LÂMPADA INTELIGENTE ===\n");

Lampada lamp = new Lampada("Philips", "LED");
Console.WriteLine(lamp);

Console.WriteLine("\n-- Tentando ajustar brilho desligada --");
lamp.AjustarBrilho(50);

Console.WriteLine("\n-- Ligando --");
lamp.Alternar();
lamp.AjustarBrilho(70);
Console.WriteLine(lamp);

Console.WriteLine("\n-- Desligando e religando (brilho deve permanecer 70%) --");
lamp.Alternar();
lamp.Alternar();
Console.WriteLine(lamp);

Console.WriteLine("\n-- Valor inválido --");
lamp.AjustarBrilho(150);