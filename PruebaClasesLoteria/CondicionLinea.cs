using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class CondicionLinea : ICondicionGanar
    {
        public string Nombre => "Línea";
        public bool Verificar(Tabla tabla)
        {
            for (int i = 0; i < 4; i++)
            {
                bool lineaCompleta = true;
                for (int j = 0; j < 4; j++)
                {
                    if (!tabla.ObtenerCasilla(i, j).Marcada)
                    {
                        lineaCompleta = false;
                        break;
                    }
                }
                if (lineaCompleta)
                    return true;
            }
            return false;
        }
    
    }
}
