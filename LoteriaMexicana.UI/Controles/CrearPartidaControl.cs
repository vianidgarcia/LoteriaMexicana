using LoteriaMexicanaModelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoteriaMexicanaModelos.CondicionesParaGanar;

namespace LoteriaMexicana.UI.Controles
{
    public partial class CrearPartidaControl : UserControl
    {
        private FrmPrincipal frmPrincipal;
        public CrearPartidaControl(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
            clbxCondicionesGanar.Items.AddRange(new string[] { "Cuatro Esquinas", "Linea Horizontal", "Linea Vertical", "Diagonal", "Carton Lleno" });
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal.MostrarControl(new MenuControl(frmPrincipal));
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
                return;

            List<ICondicionGanar> condiciones = new List<ICondicionGanar>();

            foreach (var item in clbxCondicionesGanar.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Cuatro Esquinas":
                        condiciones.Add(new CondicionEsquinas());
                        break;
                    case "Linea Horizontal":
                        condiciones.Add(new CondicionLinea());
                        break;
                    case "Linea Vertical":
                        condiciones.Add(new CondicionColumna());
                        break;
                    case "Diagonal":
                        condiciones.Add(new CondicionDiagonal());
                        break;
                    case "Carton Lleno":
                        condiciones.Add(new CondicionTablaLLena());
                        break;
                }
            }

            Servidor servidor = new Servidor(condiciones);
           
            servidor.Iniciar(int.TryParse(txtPuerto.Text, out int puerto) ? puerto : 5000);
            frmPrincipal.MostrarControl(new LobbyControl(servidor, frmPrincipal));
        }


        private bool ValidarEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtNombreHost.Text))
            {
                MessageBox.Show("El nombre del host no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clbxCondicionesGanar.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una condición para ganar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numTablasJugador.Value < 1 || numTablasJugador.Value > 3)
            {
                MessageBox.Show("El número de tablas por jugador debe ser entre 1 y 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
