namespace Febraban240
{
    public class CampoNumerico : Campo
    {
        public int NumeroCasasDecimais { get; set; }

        public CampoNumerico(int posicaoInicial, int posicaoFinal, int numeroCasasDecimais, string descricao)
                             : base(posicaoInicial, posicaoFinal, descricao)
        {
            NumeroCasasDecimais = numeroCasasDecimais;
        }

        public CampoNumerico(int posicaoInicial, int posicaoFinal, int numeroCasasDecimais, string descricao, string valor)
                             : this(posicaoInicial, posicaoFinal, numeroCasasDecimais, descricao)
        {
            Valor = valor;
        }

        protected override int CalcularNumeroDigitos() => PosicaoFinal - PosicaoInicial - NumeroCasasDecimais + 1;

        public override string ToString() => ExtrairNumeros(Valor).PadLeft(NumeroDigitos, '0').Substring(0, NumeroDigitos);

        private string ExtrairNumeros(string valor)
        {
            string retorno = "";

            foreach (var caractere in valor)
                if (char.IsDigit(caractere))
                    retorno += caractere;

            return retorno;
        }
    }
}
