using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.Mensajes
{
    public class MensajeChat : MensajeBase
    { 
        public string Usuario { get; set; }
        public string Contenido { get; set; }
        public MensajeChat()
        {
            Tipo = "Chat";
        }
    }
}
