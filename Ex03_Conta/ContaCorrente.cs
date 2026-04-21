namespace Ex03_Conta
{
    public class ContaCorrente
    {
        private readonly int _numero;
        private string _titular;
        private double _saldo;
        private readonly double _limite;

        public ContaCorrente(int numero, string titular)
        {
            _numero = numero;
            _titular = titular;
            _saldo = 0;
            _limite = 500;
        }

        public int Numero => _numero;

        public string Titular
        {
            get => _titular;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _titular = value;
            }
        }

        public double Saldo => _saldo;
        public double Limite => _limite;

        // Campos calculados
        public double SaldoTotal => _saldo + _limite;
        public string StatusConta => _saldo < 0 ? "Negativo" : "Positivo";

        public bool Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido.");
                return false;
            }
            _saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado. Saldo: R${_saldo:F2}");
            return true;
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");
                return false;
            }
            if (valor > SaldoTotal)
            {
                Console.WriteLine($"Saldo insuficiente. Saldo total disponível: R${SaldoTotal:F2}");
                return false;
            }
            _saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado. Saldo: R${_saldo:F2}");
            if (_saldo < 0)
                Console.WriteLine($"⚠ Usando limite. Valor utilizado do limite: R${Math.Abs(_saldo):F2}");
            return true;
        }

        public override string ToString()
        {
            return $"Conta: {_numero} | Titular: {_titular} | Saldo: R${_saldo:F2} | Limite: R${_limite:F2}";
        }
    }
}