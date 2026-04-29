using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class CondicionColumna : ICondicionGanar
    {
        public string Nombre => "Columna";
        public bool Verificar(Tabla tabla)
        {
            for (int i = 0; i < 4; i++)
            {
                bool columnaCompleta = true;
                for (int j = 0; j < 4; j++)
                {
                    if (!tabla.ObtenerCasilla(j, i).Marcada)
                    {
                        columnaCompleta = false;
                        break;
                    }
                }
                if (columnaCompleta)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
