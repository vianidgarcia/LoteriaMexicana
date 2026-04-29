using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos
{
    public class CondicionDiagonal : ICondicionGanar
    {
        public string Nombre => "Diagonal";
        public bool Verificar(Tabla tabla)
        {
            bool diagonal1Completa = true;
            bool diagonal2Completa = true;

            for (int i = 0; i < 4; i++)
            {
                if (!tabla.ObtenerCasilla(i, i).Marcada)
                {
                    diagonal1Completa = false;
                }
                if (!tabla.ObtenerCasilla(i, 3-i).Marcada)
                {
                   diagonal2Completa = false;
                }
            }
            return diagonal1Completa || diagonal2Completa;
        }
    }
}
