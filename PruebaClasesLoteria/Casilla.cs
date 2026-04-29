using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Casilla
    {
        public Carta Carta { get; set; }
        public bool Marcada { get; set; }
            public Casilla(Carta carta)
            {
                Carta = carta;
                Marcada = false;
        }
    }
}
