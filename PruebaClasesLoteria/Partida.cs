using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class Partida
    {
        public List<Jugador> Jugadores { get; private set; }
        public Mazo Mazo { get; private set; }
        public List<ICondicionGanar> CondicionesGanar { get; private set; }
        public EstadoPartida Estado { get; private set; }

        public Partida()
        {
            List<Carta> cartas = CatalogoCartas.CargarCatalogo();

            Jugadores = new List<Jugador>();
            Mazo = new Mazo(cartas);
            CondicionesGanar = new List<ICondicionGanar>();
            Estado = EstadoPartida.EsperandoJugadores;
        }

        public void IniciarPartida()
        {
            if (Jugadores.Count == 0)
                throw new Exception("No se pueden iniciar la partida sin jugadores.");
            if (CondicionesGanar.Count == 0)
                throw new Exception("No se pueden iniciar la partida sin condiciones de ganar.");
            Estado = EstadoPartida.EnCurso;
        }

        public void TerminarPartida()
        {
            Estado = EstadoPartida.Finalizada;
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (Estado != EstadoPartida.EsperandoJugadores)
                throw new Exception("No se pueden agregar jugadores una vez que la partida ha comenzado.");
            Jugadores.Add(jugador);
        }

        public void AgregarCondicionGanar(ICondicionGanar condicion)
        {
            if (Estado != EstadoPartida.EsperandoJugadores)
                throw new Exception("No se pueden agregar condiciones de ganar una vez que la partida ha comenzado.");
            CondicionesGanar.Add(condicion);
        }

        public Carta SacarCarta()
        {
            if (Estado != EstadoPartida.EnCurso)
                throw new Exception("La partida no está en curso.");
            if (Mazo.EstaVacio)
                throw new Exception("No hay más cartas para sacar.");
            Carta carta = Mazo.SacarCarta();
            return carta;
        }

        public Jugador VerificarGanadores()
        {
            foreach (var jugador in Jugadores)
            {
                foreach (var condicion in CondicionesGanar)
                {
                    foreach (var tabla in jugador.Tablas)
                    {
                        if (condicion.Verificar(tabla))
                        {
                           return jugador;
                        }
                    }
                }
            }
            return null;
        }
    }
}
