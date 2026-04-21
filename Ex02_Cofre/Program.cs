using Ex02_Cofre;

Console.WriteLine("=== COFRE DIGITAL ===\n");

Cofre cofre = new Cofre("João Silva", "senha123");
Console.WriteLine(cofre);

Console.WriteLine("\n-- 3 tentativas erradas --");
Console.WriteLine(cofre.Abrir("errada1"));
Console.WriteLine(cofre.Abrir("errada2"));
Console.WriteLine(cofre.Abrir("errada3"));

Console.WriteLine("\n-- Tentando abrir bloqueado --");
Console.WriteLine(cofre.Abrir("senha123"));

Console.WriteLine("\n-- Reset e abertura correta --");
cofre.ResetarBloqueio();
Console.WriteLine(cofre.Abrir("senha123"));
Console.WriteLine(cofre);

Console.WriteLine("\n-- Alterando senha --");
Console.WriteLine(cofre.AlterarSenha("senha123", "nova456"));
cofre.Fechar();

Console.WriteLine("\n-- Abrindo com nova senha --");
Console.WriteLine(cofre.Abrir("nova456"));
Console.WriteLine(cofre);