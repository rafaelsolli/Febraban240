namespace Febraban240
{
    public class SegmentoJ
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "3");
        }
        public GrupoServico Servico = new GrupoServico();
        public class GrupoServico
        {
            public Campo NumeroRegistro = new CampoNumerico(9, 13, 0, "G038");
            public Campo Segmento = new CampoAlfanumerico(14, 14, "G039", "J");
            public GrupoMovimento Movimento = new GrupoMovimento();
            public class GrupoMovimento
            {
                public Campo Tipo = new CampoNumerico(15, 15, 0, "G060");
                public Campo Codigo = new CampoNumerico(16, 17, 0, "G061");
            }
        }
        public GrupoPagamento Pagamento = new GrupoPagamento();
        public class GrupoPagamento
        {
            public Campo CodigoBarras = new CampoNumerico(18, 61, 0, "G063");
            public Campo NomeBeneficiario = new CampoAlfanumerico(62, 91, "G013");
            public Campo DataVencimento = new CampoNumerico(92, 99, 0, "G044");
            public Campo ValorTitulo = new CampoNumerico(100, 114, 2, "G042");
            public Campo Desconto = new CampoNumerico(115, 129, 2, "L002");
            public Campo Acrescimo = new CampoNumerico(130, 144, 2, "L003");
            public Campo DataPagamento = new CampoNumerico(145, 152, 0, "P009");
            public Campo ValorPagamento = new CampoNumerico(153, 167, 2, "P010");
            public Campo QuantidadeMoeda = new CampoNumerico(168, 182, 5, "G041");
            public Campo ReferenciaPagador = new CampoAlfanumerico(183, 202, "G064");
        }
        public Campo NossoNumero = new CampoAlfanumerico(203, 222, "G043");
        public Campo CodigoMoeda = new CampoAlfanumerico(223, 224, "G065");
        public Campo Cnab = new CampoAlfanumerico(225, 230, "G004");
        public Campo Ocorrencias = new CampoAlfanumerico(231, 234, "G059");
    }
}
