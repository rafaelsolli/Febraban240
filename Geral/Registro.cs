namespace Febraban240
{
    abstract class Registro
    {
        public Campo CodigoBancoCompensacao { get; set; }
        public Campo LoteServico { get; set; }
        public Campo TipoRegistro { get; set; }

        protected Registro()
        {
            CodigoBancoCompensacao = new CampoNumerico(1, 3, 0, "G001");
            LoteServico = new CampoNumerico(4, 7, 0, "*G002");
            TipoRegistro = new CampoNumerico(8, 8, 0, "*G003");
        }
    }
}
