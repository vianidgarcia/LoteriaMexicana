using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.Mensajes
{
    public class MensajeCarta : MensajeBase
    {
        public string Nombre { get; set; }
        public string Frase { get; set; }
        public int Numero { get; set; }
        
        public string RutaImagen { get; set; } = string.Empty;
        public MensajeCarta()
            {
                Tipo = "Carta";
        }
    }
}
