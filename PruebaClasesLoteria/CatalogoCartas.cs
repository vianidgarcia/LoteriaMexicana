using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LoteriaMexicanaModelos
{
    public class CatalogoCartas
    {
        private static List<Carta> Cartas { get; set; }

        public static List<Carta> CargarCatalogo()
        {
            if (!File.Exists("cartas.json"))
                throw new Exception ("El archivo de cartas no existe.");

            try
            {
                string json = File.ReadAllText("cartas.json");
                if (string.IsNullOrEmpty(json))
                    throw new Exception("El archivo de cartas está vacío.");

                List<Carta> cartas = JsonSerializer.Deserialize<List<Carta>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return Cartas = cartas ?? new List<Carta>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo cargar el catálogo de cartas.: {ex}");
                throw new Exception ($"No se pudo cargar el catálogo de cartas.: {ex}");
            }
        }

        public static Carta ObtenerPorNumero(int numero)
        {
            if (Cartas == null)
           throw new Exception("El catálogo no ha sido cargado");
           return Cartas.FirstOrDefault(c => c.Numero == numero);
        }

    }

}
