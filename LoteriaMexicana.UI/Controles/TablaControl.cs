using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoteriaMexicanaModelos;

namespace LoteriaMexicana.UI.Controles
{
    public partial class TablaControl : UserControl
    {
        private Tabla tabla;
        public TablaControl()
        {
            InitializeComponent();
        }

        public void CargarTabla(Tabla tabla)
        {
            this.tabla = tabla;
            tlpTabla.Controls.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Casilla casilla = this.tabla.ObtenerCasilla(i, j);

                    CartaControl cartaVisual = new CartaControl(casilla);
                    cartaVisual.Dock = DockStyle.Fill;


                    tlpTabla.Controls.Add(cartaVisual, j, i);
                }
            }
        }

    }
}