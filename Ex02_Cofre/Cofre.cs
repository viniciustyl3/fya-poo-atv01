namespace Ex02_Cofre
{
    public class Cofre
    {
        private readonly string _dono;
        private string _senha;
        private bool _estaAberto;
        private int _tentativasErradas;

        private const int MaxTentativas = 3;

        public Cofre(string dono, string senha)
        {
            _dono = dono;
            _senha = senha;
            _estaAberto = false;
            _tentativasErradas = 0;
        }

        public string Dono => _dono;
        public bool EstaAberto => _estaAberto;
        public int TentativasErradas => _tentativasErradas;
        public bool EstaBloqueado => _tentativasErradas >= MaxTentativas;

        public string Abrir(string senhaInformada)
        {
            if (EstaBloqueado)
                return "Cofre Bloqueado! Limite de tentativas atingido.";

            if (_estaAberto)
                return "O cofre já está aberto.";

            if (senhaInformada == _senha)
            {
                _estaAberto = true;
                _tentativasErradas = 0;
                return "Cofre aberto com sucesso!";
            }

            _tentativasErradas++;

            if (EstaBloqueado)
                return "Senha incorreta. Cofre Bloqueado!";

            return $"Senha incorreta. Tentativas restantes: {MaxTentativas - _tentativasErradas}.";
        }

        public void Fechar()
        {
            _estaAberto = false;
            Console.WriteLine("Cofre fechado.");
        }

        public string AlterarSenha(string senhaAntiga, string novaSenha)
        {
            if (!_estaAberto)
                return "O cofre precisa estar aberto para alterar a senha.";

            if (senhaAntiga != _senha)
                return "Senha antiga incorreta.";

            _senha = novaSenha;
            return "Senha alterada com sucesso!";
        }

        public void ResetarBloqueio()
        {
            _tentativasErradas = 0;
            Console.WriteLine("Bloqueio resetado.");
        }

        public override string ToString()
        {
            string estado = _estaAberto ? "Aberto" : "Fechado";
            string bloqueio = EstaBloqueado ? " [BLOQUEADO]" : "";
            return $"Cofre de {_dono} | Estado: {estado}{bloqueio} | Tentativas erradas: {_tentativasErradas}";
        }
    }
}