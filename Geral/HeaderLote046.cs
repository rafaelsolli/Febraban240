namespace Febraban240
{
    public class HeaderLote046
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "1");
        }
        public GrupoServico Servico = new GrupoServico();
        public class GrupoServico
        {
            public Campo Operacao = new CampoAlfanumerico(9, 9, "G028", "C");
            public Campo Servico = new CampoAlfanumerico(10, 11, "G025");
            public Campo FormaLancamento = new CampoAlfanumerico(12, 13, "G029");
            public Campo LayoutLote = new CampoAlfanumerico(14, 16, "G030", "046");
        }
        public Campo Cnab1 = new CampoAlfanumerico(17, 17, "G004");
        public GrupoEmpresa Empresa = new GrupoEmpresa();
        public class GrupoEmpresa
        {
            public GrupoInscricao Inscricao = new GrupoInscricao();
            public class GrupoInscricao
            {
                public Campo Tipo = new CampoNumerico(18, 18, 0, "G005");
                public Campo Numero = new CampoNumerico(19, 32, 0, "G006");
            }
            public Campo Convenio = new CampoAlfanumerico(33, 52, "G007");
            public GrupoContaCorrente ContaCorrente = new GrupoContaCorrente();
            public class GrupoContaCorrente
            {
                public GrupoAgencia Agencia = new GrupoAgencia();
                public class GrupoAgencia
                {
                    public Campo Codigo = new CampoNumerico(53, 57, 0, "G008");
                    public Campo DV = new CampoAlfanumerico(58, 58, "G009");
                }
                public GrupoConta Conta = new GrupoConta();
                public class GrupoConta
                {
                    public Campo Numero = new CampoNumerico(59, 70, 0, "G010");
                    public Campo DV = new CampoAlfanumerico(71, 71, "G011");
                }
                public Campo DV = new CampoAlfanumerico(72, 72, "G012");
            }
            public Campo Nome = new CampoAlfanumerico(73, 102, "G013");
        }
        public Campo Informacao1 = new CampoAlfanumerico(103, 142, "G031");
        public GrupoEnderecoEmpresa EnderecoEmpresa = new GrupoEnderecoEmpresa();
        public class GrupoEnderecoEmpresa
        {
            public Campo Logradouro = new CampoAlfanumerico(143, 172, "G032");
            public Campo Numero = new CampoAlfanumerico(173, 177, "G032");
            public Campo Complemento = new CampoAlfanumerico(178, 192, "G032");
            public Campo Cidade = new CampoAlfanumerico(193, 212, "G033");
            public Campo CEP = new CampoAlfanumerico(213, 217, "G034");
            public Campo ComplementoCEP = new CampoAlfanumerico(218, 220, "G035");
            public Campo Estado = new CampoAlfanumerico(221, 222, "G036");
        }
        public Campo IndicativoFormaPagamento = new CampoAlfanumerico(223, 224, "P014");
        public Campo Cnab2 = new CampoAlfanumerico(225, 230, "G004");
        public Campo Ocorrencias = new CampoAlfanumerico(231, 240, "G059");
    }
}
