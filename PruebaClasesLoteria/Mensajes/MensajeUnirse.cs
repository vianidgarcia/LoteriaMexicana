using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.Mensajes
{
    public class MensajeUnirse : MensajeBase
    {
       public string Usuario { get; set; }
        public MensajeUnirse()
        {
            Tipo = "Unirse";
        }
    }
}
