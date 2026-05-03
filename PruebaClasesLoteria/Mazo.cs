using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Mazo
    {
        private List<Carta> cartasDisponibles;
        private List<Carta> cartasUsadas;
        public int CartasRestantes => cartasDisponibles.Count;
        public bool EstaVacio => cartasDisponibles.Count == 0;

        public Mazo(List<Carta> cartas)
        { 
          cartasDisponibles = new List<Carta>(cartas);
          cartasUsadas = new List<Carta>();
            
          Random rnd = new Random();

            for (int i = cartasDisponibles.Count; i > 0; i--)
            { 
                int index = rnd.Next(i);
                Carta temp = cartasDisponibles[index];
                cartasDisponibles[index] = cartasDisponibles[i - 1];
                cartasDisponibles[i - 1] = temp;
            }
        }

        public Carta SacarCarta()
        {
            if (EstaVacio)
                throw new Exception("No hay más cartas disponibles");

            Carta c = cartasDisponibles[0];
            cartasDisponibles.RemoveAt(0);
            cartasUsadas.Add(c);
            return c;
        }

        public bool FueCantada(int numeroCarta)
        {
            return cartasUsadas.Any(c => c.Numero == numeroCarta);
        }
    }
}
