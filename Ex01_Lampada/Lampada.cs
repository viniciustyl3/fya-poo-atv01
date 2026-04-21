namespace Ex01_Lampada
{
    public class Lampada
    {
        private string _marca;
        private readonly string _tecnologia;
        private bool _ligada;
        private int _brilho;

        public Lampada(string marca, string tecnologia)
        {
            _marca = marca;
            _tecnologia = tecnologia;
            _ligada = false;
            _brilho = 100;
        }

        public string Marca => _marca;
        public string Tecnologia => _tecnologia;
        public bool Ligada => _ligada;
        public int Brilho => _brilho;

        public void Alternar()
        {
            _ligada = !_ligada;
            string estado = _ligada ? "ligada" : "desligada";
            Console.WriteLine($"{_marca} {estado}. Brilho atual: {_brilho}%");
        }

        public void AjustarBrilho(int novoBrilho)
        {
            if (!_ligada)
            {
                Console.WriteLine("Erro: a lâmpada está desligada. Ligue-a antes de ajustar o brilho.");
                return;
            }
            if (novoBrilho < 0 || novoBrilho > 100)
            {
                Console.WriteLine("Erro: brilho deve estar entre 0 e 100.");
                return;
            }
            _brilho = novoBrilho;
            Console.WriteLine($"Brilho ajustado para {_brilho}%.");
        }

        public override string ToString()
        {
            string estado = _ligada ? "Ligada" : "Desligada";
            return $"Lâmpada [{_marca}] | Tecnologia: {_tecnologia} | Estado: {estado} | Brilho: {_brilho}%";
        }
    }
}