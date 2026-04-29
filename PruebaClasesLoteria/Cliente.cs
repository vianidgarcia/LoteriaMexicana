using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoteriaMexicanaModelos.Mensajes;
using System.Net;
using System.Net.Sockets; 
using System.Text.Json;

namespace LoteriaMexicanaModelos
{
    public class Cliente
    {
        private string usuario;
        TcpClient cliente;
        NetworkStream stream;
        StreamWriter escritor;
        StreamReader lector;

        

        public void Conectar(string direccion, int puerto, string usuario)
        {
            cliente = new TcpClient();
            cliente.Connect(IPAddress.Parse(direccion), puerto);
            stream = cliente.GetStream();
            escritor = new StreamWriter(stream);
            lector = new StreamReader(stream);

            // Enviar mensaje de unirse al servidor
            this.usuario = usuario;
            MensajeUnirse mensajeUnirse = new MensajeUnirse { Usuario = usuario };
            string json = JsonSerializer.Serialize(mensajeUnirse);
            escritor.WriteLine(json);
            escritor.Flush();

            // Iniciar tarea para escuchar mensajes del servidor
            Task.Run(() =>
            {
                try
                {
                    while (cliente.Connected)
                    {
                        string mensajeJson = lector.ReadLine();
                        if (mensajeJson == null) break; // El servidor cerró la conexión
                        JsonSerializerOptions opciones = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };

                        MensajeBase tipoDeMensaje = JsonSerializer.Deserialize<MensajeBase>(mensajeJson, opciones);

                        switch (tipoDeMensaje.Tipo)
                        {
                            case "Carta":
                                MensajeCarta mensajeCarta = JsonSerializer.Deserialize<MensajeCarta>(mensajeJson, opciones);
                                OnCartaSacada?.Invoke(mensajeCarta);
                                break;
                            case "Chat":
                                MensajeChat mensajeChat = JsonSerializer.Deserialize<MensajeChat>(mensajeJson, opciones);
                                OnMensajeRecibido?.Invoke(mensajeChat);
                                break;
                            case "Ganador":
                                MensajeGanador mensajeGanador = JsonSerializer.Deserialize<MensajeGanador>(mensajeJson, opciones);
                                OnGanador?.Invoke(mensajeGanador);
                                break;
                            case "Unirse":
                                MensajeUnirse mensajeUnirse = JsonSerializer.Deserialize<MensajeUnirse>(mensajeJson, opciones);
                                OnJugadorConectado?.Invoke(mensajeUnirse.Usuario);
                                break;

                        }
                    }
                }
                catch (Exception ex)
                {
                    OnJugadorDesconectado?.Invoke($"Desconectado del servidor: {ex.Message}");
                }
            });
        }

        public void EnviarMensaje(string contenido)
        {
            if (cliente == null || !cliente.Connected)
                throw new InvalidOperationException("No estás conectado al servidor.");
            MensajeChat mensajeChat = new MensajeChat { Usuario = this.usuario, Contenido = contenido };
            string json = JsonSerializer.Serialize(mensajeChat);
            escritor.WriteLine(json);
            escritor.Flush();
        }

        public event Action<MensajeChat> OnMensajeRecibido;
        public event Action<string> OnJugadorConectado;
        public event Action<string> OnJugadorDesconectado;
        public event Action<MensajeCarta> OnCartaSacada;
        public event Action<MensajeGanador> OnGanador;
    }
}
