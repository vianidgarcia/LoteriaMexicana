using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Tabla
    {
        private Casilla[,] casillas;
        public string NombreJugador { get; set; }
        public string Nombre { get; set; }

        public Tabla(string nombreJugador, string nombre) { 
            NombreJugador = nombreJugador;
            Nombre = nombre;
            casillas = new Casilla[4, 4];
        }

        public void GenerarAleatoria(List<Carta> cartas)
        {
            List<Carta> cartasDisponibles = new List<Carta>(cartas);;

            Random rnd = new Random();

            for (int i = cartasDisponibles.Count; i > 0; i--)
            {
                int index = rnd.Next(i);
                Carta temp = cartasDisponibles[index];
                cartasDisponibles[index] = cartasDisponibles[i - 1];
                cartasDisponibles[i - 1] = temp;
            }

            for (int i = 0; i < 16; i++)
            {
                Carta carta = cartasDisponibles[i];
                int fila = i / 4;
                int columna = i % 4;
                casillas[fila, columna] = new Casilla(carta);
            }

        }

        public bool MarcarCarta(Carta carta) 
        {
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    if (casillas[fila, columna] != null && casillas[fila, columna].Carta.Numero == carta.Numero)
                    {
                        casillas[fila, columna].Marcada = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public Casilla ObtenerCasilla(int fila, int columna) 
        {
            if (fila < 0 || fila >= 4 || columna < 0 || columna >= 4)
                throw new Exception("Índices de fila o columna fuera de rango");
            return casillas[fila, columna];
        }

        public void MarcarCasilla(int fila, int columna) 
        {
            if (fila < 0 || fila >= 4 || columna < 0 || columna >= 4)
                throw new Exception("Índices de fila o columna fuera de rango");

            if (casillas[fila, columna] == null)
                throw new Exception("La casilla no tiene carta asignada");

            casillas[fila, columna].Marcada = true;
        }



    }
}
