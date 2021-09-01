namespace Febraban240
{
    class RegistroHeaderLote040 : RegistroHeaderLote
    {
        public RegistroHeaderLote040()
        {
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(223, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            TipoOperacao.Valor = "C";
            NumeroVersaoLayoutLote.Valor = "040";
        }
    }
}
