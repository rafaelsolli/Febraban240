namespace Febraban240
{
    public class SegmentoB
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
            public Campo Segmento = new CampoAlfanumerico(14, 14, "G039", "B");
        }
        public Campo IdentificacaoFavorecido = new CampoAlfanumerico(15, 17, "G100");
        public GrupoInscricao Inscricao = new GrupoInscricao();
        public class GrupoInscricao
        {
            public Campo Tipo = new CampoNumerico(18, 18, 0, "G005");
            public Campo Numero = new CampoNumerico(19, 32, 0, "G006");
        }
        public GrupoDadosComplementares DadosComplementares = new GrupoDadosComplementares();
        public class GrupoDadosComplementares
        {
            public Campo Informacao10 = new CampoAlfanumerico(33, 67, "G101");
            public Campo Informacao11 = new CampoAlfanumerico(68, 127, "G101");
            public Campo Informacao12 = new CampoAlfanumerico(128, 226, "G101");
        }
        public Campo CodigoUgCentralizadora = new CampoNumerico(227, 232, 0, "P012");
        public Campo IdentificacaoBancoSpb = new CampoNumerico(233, 240, 0, "P015");
    }
}
