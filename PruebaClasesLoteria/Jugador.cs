using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public List<Tabla> Tablas { get; set; }
        public int Puntos { get; set; }
        public int PartidasGanadas { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Tablas = new List<Tabla>();
        }
    }
}
