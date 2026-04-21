using Ex03_Conta;

Console.WriteLine("=== CONTA CORRENTE UNIVERSITÁRIA ===\n");

ContaCorrente conta = new ContaCorrente(12345, "Maria Oliveira");
Console.WriteLine(conta);
Console.WriteLine($"Saldo Total: R${conta.SaldoTotal:F2} | Status: {conta.StatusConta}");

Console.WriteLine("\n-- Depósito de R$200 --");
conta.Depositar(200);

Console.WriteLine("\n-- Saque de R$600 (usa limite) --");
conta.Sacar(600);
Console.WriteLine($"Status: {conta.StatusConta}");

Console.WriteLine("\n-- Saque além do possível --");
conta.Sacar(300);

Console.WriteLine("\n-- Alterando titular --");
conta.Titular = "Maria Santos";
Console.WriteLine(conta);