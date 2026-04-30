using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.CondicionesParaGanar
{
    public class CondicionTablaLLena : ICondicionGanar
    {
        public string Nombre => "Tabla Llena";

        public bool Verificar(Tabla tabla)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!tabla.ObtenerCasilla(i, j).Marcada)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
