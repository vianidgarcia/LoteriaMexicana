using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.Mensajes
{
    public class MensajeGanador : MensajeBase
    {
        public string Usuario { get; set; }
        public string TipoGanador { get; set; }
        public MensajeGanador()
        {
            Tipo = "Ganador";
        }
    }
}
