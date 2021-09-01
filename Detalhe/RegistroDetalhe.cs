namespace Febraban240
{
    abstract class RegistroDetalhe : Registro
    {
        public Campo NumeroSequencialRegistroLote { get; set; }
        public Campo CodigoSegmentoRegistroDetalhe { get; set; }

        protected RegistroDetalhe()
        {
            NumeroSequencialRegistroLote = new CampoNumerico(9, 13, 0, "*G038");
            CodigoSegmentoRegistroDetalhe = new CampoAlfanumerico(14, 14, "*G039");

            TipoRegistro.Valor = "3";
        }
    }
}
