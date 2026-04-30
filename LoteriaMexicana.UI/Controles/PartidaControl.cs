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
    public partial class PartidaControl : UserControl
    {
        private Cliente cliente;
        private Servidor servidor;
        private FrmPrincipal frmPrincipal;
        public PartidaControl(Servidor servidor, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.servidor = servidor;
            this.frmPrincipal = frmPrincipal;
            label1.Visible = false;
        }

        public PartidaControl(Cliente cliente, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.frmPrincipal = frmPrincipal;

        }
    }
}
