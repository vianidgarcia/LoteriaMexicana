using LoteriaMexicanaModelos.CondicionesParaGanar;
using LoteriaMexicanaModelos.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoteriaMexicanaModelos.CondicionesParaGanar;

namespace LoteriaMexicanaModelos
{
    public class Servidor
    {
        Partida partida = new Partida();
        TcpListener servidor;
        List<StreamWriter> clientes = new List<StreamWriter>();
        public List<ICondicionGanar> CondicionesGanar { get; private set; }
        public bool MazoVacio => partida.Mazo.EstaVacio;
        public List<Jugador> ObtenerJugadores() => partida.Jugadores;
        public Servidor(List<ICondicionGanar> condiciones)
        {
            partida = new Partida();
            CondicionesGanar = condiciones;
            foreach (var condicion in condiciones)
                partida.AgregarCondicionGanar(condicion);
        }

        public void Iniciar(int puerto)
        {
            Thread thread = new Thread(() =>
            {
                servidor = new TcpListener(IPAddress.Any, puerto);
                servidor.Start();
                try
                {
                    while (true)
                    {
                        TcpClient cliente = servidor.AcceptTcpClient();
                        NetworkStream stream = cliente.GetStream();
                        StreamWriter escritor = new StreamWriter(stream);
                        StreamReader lector = new StreamReader(stream);
                        clientes.Add(escritor);
                        ThreadPool.QueueUserWorkItem(_ =>
                        {
                            AtenderCliente(escritor, lector);
                        });
                    }
                }


                catch (SocketException ex)
                {
                    Console.WriteLine("Error en el servidor: " + ex.Message);
                }
                finally
                {
                    servidor.Stop();
                }
            }
            );
            thread.IsBackground = true;
            thread.Start();
        }

        private void AtenderCliente(StreamWriter escritor, StreamReader lector)
        {
            try
            {
                while (true)
                {
                    string mensaje = lector.ReadLine();
                    if (mensaje == null)
                    {
                        clientes.Remove(escritor);
                        OnJugadorDesconectado?.Invoke("Un jugador se ha desconectado.");
                        break;
                    }
                    ProcesarMensaje(mensaje);
                }
            }
            catch
            {
                clientes.Remove(escritor);
                OnJugadorDesconectado?.Invoke("Un jugador se ha desconectado.");
            }
        }

        public void EnviarATodos(string json)
        {
            foreach (var cliente in clientes)
            {
                cliente.WriteLine(json);
                cliente.Flush();
            }
        }

        public void ProcesarMensaje(string mensaje)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            MensajeBase tipoDeMensaje = JsonSerializer.Deserialize<MensajeBase>(mensaje, opciones);
            switch (tipoDeMensaje.Tipo)
            {
                case "Carta":
                    MensajeCarta mensajeCarta = JsonSerializer.Deserialize<MensajeCarta>(mensaje, opciones);
                    OnCartaSacada?.Invoke(mensajeCarta);
                    EnviarATodos(mensaje);
                    break;
                case "Chat":
                    MensajeChat mensajeChat = JsonSerializer.Deserialize<MensajeChat>(mensaje, opciones);
                    OnMensajeRecibido?.Invoke(mensajeChat);
                    EnviarATodos(mensaje);
                    break;
                case "Ganador":
                    MensajeGanador mensajeGanador = JsonSerializer.Deserialize<MensajeGanador>(mensaje, opciones);
                    bool trampa = false;
                    foreach (CartaEstado cartaEstado in mensajeGanador.CasillasMarcadas)
                    {
                        if (cartaEstado.Marcada && !partida.FueCantada(cartaEstado.NumeroCarta))
                        {
                            trampa = true;
                            break;
                        }
                    }
                    if (trampa) break;


                    Tabla tablaGanadora = new Tabla(mensajeGanador.CasillasMarcadas);
                    ICondicionGanar condicion = partida.VerificarPosibleGanador(tablaGanadora);
                    if (condicion != null)
                    {
                        mensajeGanador.TipoGanador = condicion.Nombre;
                        OnGanador?.Invoke(mensajeGanador);
                        EnviarATodos(JsonSerializer.Serialize(mensajeGanador));
                        Jugador ganador = partida.Jugadores.FirstOrDefault(j => j.Nombre == mensajeGanador.Usuario);
                        if (ganador != null)
                            ganador.PartidasGanadas++;
                        partida.TerminarPartida();
                    }
                    break;
                case "Unirse":
                    MensajeUnirse mensajeUnirse = JsonSerializer.Deserialize<MensajeUnirse>(mensaje, opciones);
                    Jugador nuevoJugador = new Jugador(mensajeUnirse.Usuario);
                    partida.AgregarJugador(nuevoJugador);
                    OnJugadorConectado?.Invoke(mensajeUnirse.Usuario);
                    EnviarATodos(mensaje);
                    break;
            }
        }

        public void SacarCarta()
        {
            Carta carta = partida.SacarCarta();
            if (carta == null) return;
            MensajeCarta mensaje = new MensajeCarta
            {
                Numero = carta.Numero,
                Nombre = carta.Nombre,
                Frase = carta.Frase,
                RutaImagen = carta.RutaImagen
            };
            string json = JsonSerializer.Serialize(mensaje);
            EnviarATodos(json);
            OnCartaSacada?.Invoke(mensaje);
        }
        public void IniciarJuego()
        {
            partida.IniciarPartida();

            // Creamos el mensaje para avisar a todos
            MensajeIniciarPartida mensaje = new MensajeIniciarPartida();

            EnviarATodos(JsonSerializer.Serialize(mensaje)); //
        }

        public void Detener()
        {
            servidor.Stop();
            clientes.Clear();
        }
        
        public event Action<MensajeChat> OnMensajeRecibido;
        public event Action<string> OnJugadorConectado;
        public event Action<string> OnJugadorDesconectado;
        public event Action<MensajeCarta> OnCartaSacada;
        public event Action<MensajeGanador> OnGanador;
        
    }
}