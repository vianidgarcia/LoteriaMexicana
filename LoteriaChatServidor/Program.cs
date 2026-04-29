using LoteriaMexicanaModelos.Mensajes;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

TcpListener servidor = new TcpListener(IPAddress.Any, 5000);
servidor.Start();

Console.WriteLine("Servidor iniciado. Esperando conexiones...");

List<StreamWriter> clientes = new List<StreamWriter>();

while (true)
{ 
    TcpClient cliente = servidor.AcceptTcpClient();
    NetworkStream stream = cliente.GetStream();
    StreamWriter escritor = new StreamWriter(stream);
    StreamReader lector = new StreamReader(stream);
    clientes.Add(escritor);

    ThreadPool.QueueUserWorkItem(_ =>
    {
        try
        {
            
            while (true)
            {
                string mensaje = lector.ReadLine();
                if (mensaje == null) break;

                JsonSerializerOptions opciones = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                MensajeBase tipoDeMensaje = JsonSerializer.Deserialize<MensajeBase>(mensaje, opciones);
             
                switch (tipoDeMensaje.Tipo)
                {
                    case "Carta":
                        MensajeCarta mensajeCarta = JsonSerializer.Deserialize<MensajeCarta>(mensaje, opciones);
                        Console.WriteLine($"Tipo de mensaje recibido: {mensajeCarta.Tipo}");
                        break;
                    case "Chat":
                        MensajeChat mensajeChat = JsonSerializer.Deserialize<MensajeChat>(mensaje, opciones);
                        Console.WriteLine($"Tipo de mensaje recibido: {mensajeChat.Tipo}");
                        Console.WriteLine(mensajeChat.Usuario + ": " + mensajeChat.Contenido);
                        foreach (var c in clientes)
                        {
                            c.WriteLine(mensaje);
                            c.Flush();
                        }
                        break;
                    case "Ganador":
                        MensajeGanador mensajeGanador = JsonSerializer.Deserialize<MensajeGanador>(mensaje, opciones);
                        Console.WriteLine($"Tipo de mensaje recibido: {mensajeGanador.Tipo}");
                        break;
                    case "Unirse": 
                        MensajeUnirse mensajeUnirse = JsonSerializer.Deserialize<MensajeUnirse>(mensaje, opciones); 
                        Console.WriteLine($"Tipo de mensaje recibido: {mensajeUnirse.Tipo}");
                        MensajeUnirse aviso = new MensajeUnirse();
                        aviso.Usuario = mensajeUnirse.Usuario;
                        string avisoJson = JsonSerializer.Serialize(aviso);
                        foreach (var c in clientes) { c.WriteLine(avisoJson); c.Flush(); }
                        break;
                }
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            clientes.Remove(escritor);
            cliente.Close();
            Console.WriteLine("Cliente desconectado.");
        }
    });

}