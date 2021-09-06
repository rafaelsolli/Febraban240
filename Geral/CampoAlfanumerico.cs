using System.Globalization;
using System.Text;

namespace Febraban240
{
    public class CampoAlfanumerico : Campo
    {
        public CampoAlfanumerico(int posicaoInicial, int posicaoFinal, string descricao)
                                 : base(posicaoInicial, posicaoFinal, descricao)
        {
        }

        public CampoAlfanumerico(int posicaoInicial, int posicaoFinal, string descricao, string valor)
                                 : this(posicaoInicial, posicaoFinal, descricao)
        {
            Valor = valor;
        }

        protected override int CalcularNumeroDigitos() => PosicaoFinal - PosicaoInicial + 1;

        public override string ToString() => SubstituirDiacriticos(Valor).PadRight(NumeroDigitos, ' ').Substring(0, NumeroDigitos);

        private string SubstituirDiacriticos(string valor)
        {
            var retorno = "";

            foreach (var caractere in valor.Normalize(NormalizationForm.FormD))
                if (CharUnicodeInfo.GetUnicodeCategory(caractere) != UnicodeCategory.NonSpacingMark)
                    retorno += caractere;

            return retorno.Normalize(NormalizationForm.FormC);
        }
    }
}
