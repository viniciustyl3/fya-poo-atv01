using Ex04_RPG;

Console.WriteLine("=== PERSONAGEM DE RPG ===\n");

Personagem guerreiro = new Personagem("Arthas", Classe.Guerreiro);
Personagem mago = new Personagem("Merlin", Classe.Mago);

Console.WriteLine(guerreiro);
Console.WriteLine(mago);

Console.WriteLine("\n-- Guerreiro recebe dano --");
guerreiro.ReceberDano(80);

Console.WriteLine("\n-- Guerreiro se cura --");
guerreiro.Curar(40);

Console.WriteLine("\n-- Guerreiro sobe de nível --");
guerreiro.SubirNivel();
Console.WriteLine(guerreiro);

Console.WriteLine("\n-- Mago recebe dano fatal --");
mago.ReceberDano(80);

Console.WriteLine("\n-- Tentativas com mago morto --");
mago.Curar(30);
mago.SubirNivel();

Console.WriteLine("\n-- Ressuscitando o mago --");
mago.Ressuscitar();
mago.SubirNivel();
Console.WriteLine(mago);