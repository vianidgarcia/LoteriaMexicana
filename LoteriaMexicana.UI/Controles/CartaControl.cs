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
    public partial class CartaControl : UserControl
    {
        private Casilla _casilla;
        public CartaControl(Casilla casilla)
        {
            InitializeComponent();
            pbxFicha.Parent = pbxCarta;
            pbxFicha.BackColor = Color.Transparent;
            pbxFicha.Location = new Point(50, 50);
            pbxFicha.Visible = false;

            pbxCarta.SizeMode = PictureBoxSizeMode.Zoom;
            _casilla = casilla;

            pbxFicha.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "fichaDeBotella.png"));
            AsignarFoto();
        }

        private void pbxCarta_Click(object sender, EventArgs e)
        {
            _casilla.Marcada = !_casilla.Marcada;
            pbxFicha.Visible = _casilla.Marcada;
        }

        private void AsignarFoto()
        {
            string rutaCarpeta = Path.Combine(Application.StartupPath, "Resources");
            string rutaCompleta = Path.Combine(rutaCarpeta, _casilla.Carta.RutaImagen);
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    pbxCarta.Image = Image.FromFile(rutaCompleta);
                }
            }
            catch (Exception)
            {
                pbxCarta.Image = null;
            }
        }
    }
}
