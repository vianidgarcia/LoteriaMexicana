using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Frase { get; set; }
        public string RutaImagen => $"{Numero}.jpg";

        public Carta() { }

    }
}
