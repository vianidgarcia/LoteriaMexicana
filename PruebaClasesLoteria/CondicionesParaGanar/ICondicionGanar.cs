using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaMexicanaModelos.CondicionesParaGanar
{
    public interface ICondicionGanar
    {
        string Nombre { get; }
        bool Verificar(Tabla tabla);
    }
}
