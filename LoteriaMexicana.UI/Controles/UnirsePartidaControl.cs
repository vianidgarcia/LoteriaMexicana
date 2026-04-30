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

namespace LoteriaMexicana.UI.Controles
{
    public partial class UnirsePartidaControl : UserControl
    {
        private FrmPrincipal frmPrincipal;
        public UnirsePartidaControl(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
                        frmPrincipal.MostrarControl(new MenuControl(frmPrincipal));
        }

        private void btnUnirse_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
                return;
            Cliente cliente = new Cliente();
            try
            {
                LobbyControl lobby = new LobbyControl(cliente, frmPrincipal);
                cliente.Conectar(txtIp.Text, 5000, txtNombre.Text);
                frmPrincipal.MostrarControl(lobby);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar al servidor: {ex.Message}");
            }
        }

        private bool ValidarEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre de jugador.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIp.Text))
            {
                MessageBox.Show("Por favor, ingresa la dirección IP del servidor.");
                return false;
            }
            return true;
        }
    }
}
