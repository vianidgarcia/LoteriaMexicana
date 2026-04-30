using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.CondicionesParaGanar
{
    public class CondicionEsquinas : ICondicionGanar
    {
        public string Nombre => "Esquinas";
        public bool Verificar(Tabla tabla)
        {
        return tabla.ObtenerCasilla(0, 0).Marcada &&
        tabla.ObtenerCasilla(0, 3).Marcada &&
        tabla.ObtenerCasilla(3, 0).Marcada &&
        tabla.ObtenerCasilla(3, 3).Marcada;
        }
    }
}
