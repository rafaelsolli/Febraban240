using System.Collections.Generic;

namespace Febraban240
{
    class Lote
    {
        public RegistroHeaderLote HeaderLote { get; set; }
        public List<RegistroDetalhe> Detalhes { get; set; }
        public RegistroTrailerLote TrailerLote { get; set; }
    }
}
