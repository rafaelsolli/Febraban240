namespace Febraban240
{
    public class TrailerArquivo
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002", "9999");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "9");
        }
        public Campo Cnab1 = new CampoAlfanumerico(9, 17, "G004");
        public GrupoTotais Totais = new GrupoTotais();
        public class GrupoTotais
        {
            public Campo QuantidadeLotes = new CampoAlfanumerico(18, 23, "G049");
            public Campo QuantidadeRegistros = new CampoAlfanumerico(24, 29, "G056");
            public Campo QuantidadeContasConciliacao = new CampoAlfanumerico(30, 35, "G037");
        }
        public Campo Cnab2 = new CampoAlfanumerico(36, 240, "G004");
    }
}
