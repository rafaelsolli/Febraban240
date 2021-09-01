namespace Febraban240
{
    class RegistroTrailerLote : RegistroTrailer
    {
        public Campo QuantidadeRegistrosLote { get; set; }
        public Campo SomatorioValores { get; set; }
        public Campo CodigosOcorrenciasRetorno { get; set; }

        public RegistroTrailerLote()
        {
            QuantidadeRegistrosLote = new CampoNumerico(18, 6, 0, "*G057");
            SomatorioValores = new CampoNumerico(24, 41, 2, "P007");
            CodigosOcorrenciasRetorno = new CampoAlfanumerico(231, 240, "*G059");

            TipoRegistro.Valor = "5";
        }
    }
}
