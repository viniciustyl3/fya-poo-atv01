namespace Ex04_RPG
{
    public enum Classe { Guerreiro, Mago }

    public class Personagem
    {
        private readonly string _nome;
        private readonly Classe _classe;
        private int _nivel;
        private int _vidaAtual;
        private int _vidaMaxima;

        public Personagem(string nome, Classe classe)
        {
            _nome = nome;
            _classe = classe;
            _nivel = 1;
            _vidaMaxima = classe == Classe.Guerreiro ? 150 : 80;
            _vidaAtual = _vidaMaxima;
        }

        public string Nome => _nome;
        public Classe Classe => _classe;
        public int Nivel => _nivel;
        public int VidaAtual => _vidaAtual;
        public int VidaMaxima => _vidaMaxima;
        public bool EstaVivo => _vidaAtual > 0;

        public void ReceberDano(int pontos)
        {
            if (pontos <= 0) return;
            _vidaAtual = Math.Max(0, _vidaAtual - pontos);
            Console.WriteLine($"{_nome} recebeu {pontos} de dano! HP: {_vidaAtual}/{_vidaMaxima}");
            if (!EstaVivo) Console.WriteLine($"{_nome} morreu!");
        }

        public void Curar(int pontos)
        {
            if (!EstaVivo)
            {
                Console.WriteLine($"{_nome} está morto e não pode ser curado.");
                return;
            }
            if (pontos <= 0) return;
            _vidaAtual = Math.Min(_vidaMaxima, _vidaAtual + pontos);
            Console.WriteLine($"{_nome} curou {pontos}! HP: {_vidaAtual}/{_vidaMaxima}");
        }

        public void SubirNivel()
        {
            if (!EstaVivo)
            {
                Console.WriteLine($"{_nome} está morto e não pode subir de nível.");
                return;
            }
            if (_nivel >= 99)
            {
                Console.WriteLine($"{_nome} já está no nível máximo!");
                return;
            }
            _nivel++;
            _vidaMaxima = (int)(_vidaMaxima * 1.10);
            _vidaAtual = _vidaMaxima;
            Console.WriteLine($"{_nome} subiu para o nível {_nivel}! Nova Vida Máxima: {_vidaMaxima}. Vida restaurada!");
        }

        public void Ressuscitar()
        {
            if (EstaVivo)
            {
                Console.WriteLine($"{_nome} já está vivo.");
                return;
            }
            _vidaAtual = _vidaMaxima;
            Console.WriteLine($"{_nome} foi ressuscitado! HP: {_vidaAtual}/{_vidaMaxima}");
        }

        public override string ToString()
        {
            return $"{_nome} ({_classe}) - Lvl {_nivel} - HP: {_vidaAtual}/{_vidaMaxima}";
        }
    }
}