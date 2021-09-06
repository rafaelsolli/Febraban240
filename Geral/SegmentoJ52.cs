namespace Febraban240
{
    public class SegmentoJ52
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
            public Campo Cnab = new CampoNumerico(15, 15, 0, "G004");
            public Campo CodigoMovimento = new CampoNumerico(16, 17, 0, "C004");
            public Campo CodigoRegistro = new CampoNumerico(18, 19, 0, "G067", "52");
        }
        public GrupoDadosPagador DadosPagador = new GrupoDadosPagador();
        public class GrupoDadosPagador
        {
            public GrupoInscricao Inscricao = new GrupoInscricao();
            public class GrupoInscricao
            {
                public Campo Tipo = new CampoNumerico(20, 20, 0, "G005");
                public Campo Numero = new CampoNumerico(21, 35, 0, "G006");
            }
            public Campo Nome = new CampoAlfanumerico(36, 75, "G013");
        }
        public GrupoDadosBeneficiario DadosBeneficiario = new GrupoDadosBeneficiario();
        public class GrupoDadosBeneficiario
        {
            public GrupoInscricao Inscricao = new GrupoInscricao();
            public class GrupoInscricao
            {
                public Campo Tipo = new CampoNumerico(76, 76, 0, "G005");
                public Campo Numero = new CampoNumerico(77, 91, 0, "G006");
            }
            public Campo Nome = new CampoAlfanumerico(92, 131, "G013");
        }
        public GrupoDadosPagadorr DadosPagadorr = new GrupoDadosPagadorr();
        public class GrupoDadosPagadorr
        {
            public GrupoInscricao Inscricao = new GrupoInscricao();
            public class GrupoInscricao
            {
                public Campo Tipo = new CampoNumerico(132, 132, 0, "G005");
                public Campo Numero = new CampoNumerico(133, 147, 0, "G006");
            }
            public Campo Nome = new CampoAlfanumerico(148, 187, "G013");
        }
        public Campo Cnab = new CampoAlfanumerico(188, 240, "G004");
    }
}
