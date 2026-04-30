using LoteriaMexicanaModelos;
using LoteriaMexicanaModelos.CondicionesParaGanar;

List<Carta> cartas = CatalogoCartas.CargarCatalogo();

Jugador jugador1 = new Jugador("Alice");
Jugador jugador2 = new Jugador("Bob"); 

Tabla tabla1 = new Tabla(jugador1.Nombre, "Tabla de Alice");
tabla1.GenerarAleatoria(cartas);

Tabla tabla2 = new Tabla(jugador2.Nombre, "Tabla de Bob");
tabla2.GenerarAleatoria(cartas);

jugador1.Tablas.Add(tabla1);
jugador2.Tablas.Add(tabla2);

ICondicionGanar condicionLinea = new CondicionLinea();
ICondicionGanar condicionCuatroEsquinas = new CondicionEsquinas();

Partida partida = new Partida();
partida.AgregarJugador(jugador1);
partida.AgregarJugador(jugador2);
partida.AgregarCondicionGanar(condicionLinea);
partida.AgregarCondicionGanar(condicionCuatroEsquinas);

partida.IniciarPartida();
bool hayGanador = false;

for (int i = 0; i < 54 && !hayGanador; i++)
{
    Carta c = partida.SacarCarta();
    Console.WriteLine($"Carta sacada: {c.Numero} - {c.Nombre} - {c.Frase}");
    Console.WriteLine(partida.Mazo.CartasRestantes);
    foreach (Jugador jugador in partida.Jugadores)
    {
        foreach (var tabla in jugador.Tablas)
        {
            if (tabla.MarcarCarta(c))
            {
                Console.WriteLine($"{jugador.Nombre} ha marcado la carta {c.Numero} - {c.Nombre}");
                foreach (ICondicionGanar condicion in partida.CondicionesGanar)
                {
                    if (condicion.Verificar(tabla))
                    {
                        Console.WriteLine($"{jugador.Nombre} ha ganado con la condición: {condicion.GetType().Name}!");
                        partida.TerminarPartida();
                        hayGanador = true;
                        break;
                        
                    }
                }
            }
        }
    }
}