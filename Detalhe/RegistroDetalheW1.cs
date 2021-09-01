namespace Febraban240
{
    class RegistroDetalheW1 : RegistroDetalheW
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CampoIdentificadorFgts { get; set; }
        public Campo LacreConectividadeSocial { get; set; }
        public Campo DigitoLacreConectividadeSocial { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }

        public RegistroDetalheW1()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(179, 184, "N002");
            TipoIdentificacaoContribuinte = new CampoAlfanumerico(185, 186, "N003");
            IdentificacaoContribuinte = new CampoAlfanumerico(187, 200, "N004");
            CampoIdentificadorFgts = new CampoAlfanumerico(201, 216, "N021");
            LacreConectividadeSocial = new CampoAlfanumerico(217, 225, "N028");
            DigitoLacreConectividadeSocial = new CampoAlfanumerico(226, 227, "N029");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(228, 228, "G0004");
        }
    }
}
