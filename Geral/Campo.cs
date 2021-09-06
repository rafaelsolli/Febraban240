namespace Febraban240
{
    public abstract class Campo
    {
        public int PosicaoInicial { get; set; }
        public int PosicaoFinal { get; set; }
        public int NumeroDigitos { get => CalcularNumeroDigitos(); }
        public string Descricao { get; set; }
        public string Valor { get; set; }

        public Campo(int posicaoInicial, int posicaoFinal, string descricao)
        {
            PosicaoInicial = posicaoInicial;
            PosicaoFinal = posicaoFinal;
            Descricao = descricao;
            Valor = null;
        }

        protected abstract int CalcularNumeroDigitos();
    }
}
