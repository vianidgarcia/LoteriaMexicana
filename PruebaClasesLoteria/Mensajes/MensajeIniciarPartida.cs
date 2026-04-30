using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.Mensajes
{
    public class MensajeIniciarPartida : MensajeBase
    {
        public MensajeIniciarPartida()
        {
            Tipo = "IniciarPartida";
        }
    }
}
