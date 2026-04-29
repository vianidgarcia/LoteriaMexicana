using LoteriaMexicanaModelos.Mensajes;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

TcpClient cliente = new TcpClient();
try
{
    cliente.Connect("127.0.0.1", 5000);
    Console.WriteLine("Conectado al servidor.");
    NetworkStream stream = cliente.GetStream();
    StreamWriter escritor = new StreamWriter(stream);
    StreamReader lector = new StreamReader(stream);

    Console.WriteLine("Escribe tu nombre para unirte a la partida.");
        string nombre = Console.ReadLine();
    MensajeUnirse mensajeUnirse = new MensajeUnirse();
    mensajeUnirse.Usuario = nombre;
    string mensajeJson = JsonSerializer.Serialize(mensajeUnirse);
    escritor.WriteLine(mensajeJson);
    escritor.Flush();

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
                        Console.WriteLine($"Carta sacada: {mensajeCarta.Numero} - {mensajeCarta.Nombre}");
                        break;
                    case "Chat":
                        MensajeChat mensajeChat = JsonSerializer.Deserialize<MensajeChat>(mensaje, opciones);
                        Console.WriteLine(mensajeChat.Usuario + ": " + mensajeChat.Contenido);
                        break;
                    case "Ganador":
                        MensajeGanador mensajeGanador = JsonSerializer.Deserialize<MensajeGanador>(mensaje, opciones);                        Console.WriteLine($"¡{mensajeGanador.Usuario} ha ganado la partida!");
                        break;
                    case "Unirse":
                        MensajeUnirse mensajeUnirse = JsonSerializer.Deserialize<MensajeUnirse>(mensaje, opciones);
                        Console.WriteLine($"Jugador {mensajeUnirse.Usuario} se ha unido a la partida.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    });
    while (true)
    {
        string input = Console.ReadLine();
        if (input.ToLower() == "salir") break;
        MensajeChat mensajeChat = new MensajeChat();
        mensajeChat.Usuario = nombre;
        mensajeChat.Contenido = input;
        string mensajeJsonChat = JsonSerializer.Serialize(mensajeChat);
        escritor.WriteLine(mensajeJsonChat);
        escritor.Flush();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error al conectar: {ex.Message}");
}
finally
{
    cliente.Close();
    Console.WriteLine("Conexión cerrada.");
}