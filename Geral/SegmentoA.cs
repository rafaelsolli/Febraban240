namespace Febraban240
{
    public class SegmentoA
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
            public Campo Segmento = new CampoAlfanumerico(14, 14, "G039", "A");
            public GrupoMovimento Movimento = new GrupoMovimento();
            public class GrupoMovimento
            {
                public Campo Tipo = new CampoNumerico(15, 15, 0, "G060");
                public Campo Codigo = new CampoNumerico(16, 17, 0, "G061");
            }
        }
        public GrupoFavorecido Favorecido = new GrupoFavorecido();
        public class GrupoFavorecido
        {
            public Campo Camara = new CampoNumerico(18, 20, 0, "P001");
            public Campo Banco = new CampoNumerico(21, 23, 0, "P002");
            public GrupoContaCorrente ContaCorrente = new GrupoContaCorrente();
            public class GrupoContaCorrente
            {
                public GrupoAgencia Agencia = new GrupoAgencia();
                public class GrupoAgencia
                {
                    public Campo Codigo = new CampoNumerico(24, 28, 0, "G008");
                    public Campo DV = new CampoAlfanumerico(29, 29, "G009");
                }
                public GrupoConta Conta = new GrupoConta();
                public class GrupoConta
                {
                    public Campo Numero = new CampoNumerico(30, 41, 0, "G010");
                    public Campo DV = new CampoAlfanumerico(42, 42, "G011");
                }
                public Campo DV = new CampoAlfanumerico(43, 43, "G012");
            }
            public Campo Nome = new CampoAlfanumerico(44, 73, "G013");
        }
        public GrupoCredito Credito = new GrupoCredito();
        public class GrupoCredito
        {
            public Campo SeuNumero = new CampoAlfanumerico(74, 93, "");
            public Campo DataPagamento = new CampoNumerico(94, 101, 0, "P009");
            public GrupoMoeda Moeda = new GrupoMoeda();
            public class GrupoMoeda
            {
                public Campo Tipo = new CampoAlfanumerico(102, 104, "");
                public Campo Quantidade = new CampoNumerico(105, 119, 5, "G041");
            }
            public Campo ValorPagamento = new CampoNumerico(120, 134, 2, "P010");
            public Campo NossoNumero = new CampoAlfanumerico(135, 154, "G043");
            public Campo DataReal = new CampoNumerico(155, 162, 0, "P003");
            public Campo ValorReal = new CampoNumerico(163, 177, 2, "P004");
        }
        public Campo Informacao2 = new CampoAlfanumerico(178, 217, "G031");
        public Campo CodigoFinalidadeDoc = new CampoAlfanumerico(218, 219, "P005");
        public Campo CodigoFinalidadeTed = new CampoAlfanumerico(220, 224, "P011");
        public Campo CodigoFinalidadeComplementar = new CampoAlfanumerico(225, 226, "P013");
        public Campo Cnab = new CampoAlfanumerico(227, 229, "G004");
        public Campo Aviso = new CampoNumerico(230, 230, 0, "P006");
        public Campo Ocorrencias = new CampoAlfanumerico(231, 234, "G059");
    }
}
