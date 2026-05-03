using LoteriaMexicanaModelos;
using LoteriaMexicanaModelos.Mensajes;
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
    public partial class PostJuegoControl : UserControl
    {
        private Servidor servidor;
        private FrmPrincipal frmPrincipal;
        public PostJuegoControl(string ganador, FrmPrincipal frmPrincipal, Servidor servidor = null)
        {
            this.servidor = servidor;
            this.frmPrincipal= frmPrincipal;
            InitializeComponent();
            lblGanador.Text = $"¡{ganador} ha sido el ganador de la partida!";
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            frmPrincipal.MostrarControl(new MenuControl(frmPrincipal)); 
            if (servidor != null)
                servidor.Detener();
        }
    }
}
