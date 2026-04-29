using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoteriaMexicanaModelos.Mensajes;

namespace LoteriaMexicanaModelos
{
    public class Servidor
    {
        TcpListener servidor;
        List<StreamWriter> clientes = new List<StreamWriter>();
        Partida partida;

        public Servidor()
        {
            partida = new Partida();
        }

        public void Iniciar(int puerto)
        {
            Thread thread = new Thread(() =>
            {
                servidor = new TcpListener(IPAddress.Any, puerto);
                servidor.Start();
                while (true)
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    NetworkStream stream = cliente.GetStream();
                    StreamWriter escritor = new StreamWriter(stream);
                    StreamReader lector = new StreamReader(stream);
                    ThreadPool.QueueUserWorkItem(_ =>
                    {
                        while (true)
                        {
                            string mensaje = lector.ReadLine();
                            if (mensaje == null)
                            {
                                clientes.Remove(escritor);
                                OnJugadorDesconectado?.Invoke("Un jugador se ha desconectado.");
                                break; // sale del while, no return
                            }
                            ProcesarMensaje(mensaje);
                        }
                    });
                }
            }
            );
            thread.IsBackground = true;
            thread.Start();
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
                    break;
                case "Chat":
                    MensajeChat mensajeChat = JsonSerializer.Deserialize<MensajeChat>(mensaje, opciones);
                    OnMensajeRecibido?.Invoke(mensajeChat);
                    EnviarATodos(mensaje);
                    break;
                case "Ganador":
                    MensajeGanador mensajeGanador = JsonSerializer.Deserialize<MensajeGanador>(mensaje, opciones);
                    OnGanador?.Invoke(mensajeGanador);
                    break;
                case "Unirse":
                    MensajeUnirse mensajeUnirse = JsonSerializer.Deserialize<MensajeUnirse>(mensaje, opciones);
                    OnJugadorConectado?.Invoke(mensajeUnirse.Usuario);
                    break;
            }
        }

        public event Action<MensajeChat> OnMensajeRecibido;
        public event Action<string> OnJugadorConectado;
        public event Action<string> OnJugadorDesconectado;
        public event Action<MensajeCarta> OnCartaSacada;
        public event Action<MensajeGanador> OnGanador;
    }
}