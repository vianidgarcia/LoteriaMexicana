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
            btnLoteria.Visible = false;
            servidor.OnCartaSacada += RefrescarMazoVisual;
            servidor.OnGanador += FinalizarPartidaUI;
            lblFormasGanar.Text = "Formas de ganar: " + string.Join(", ", servidor.CondicionesGanar.Select(c => c.Nombre));
            servidor.OnJugadorConectado += _ => ActualizarScoreboard();
            servidor.OnGanador += _ => ActualizarScoreboard();
        }

        public PartidaControl(Cliente cliente, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.frmPrincipal = frmPrincipal;
            cliente.OnCartaSacada += RefrescarMazoVisual;
            cliente.OnGanador += FinalizarPartidaUI;
            cliente.OnMensajeRecibido += RefrescarChat;
            cliente.PrepararJugador(CatalogoCartas.CargarCatalogo());
            tcJugador.CargarTabla(cliente.ObtenerTabla());
            btnSacarCarta.Visible = false; 
        }

        private void RefrescarMazoVisual(MensajeCarta mensaje)
        {
            this.Invoke(new Action(() =>
            {
                pbxCartaCantada.SizeMode = PictureBoxSizeMode.Zoom;
                lblFrase.Text = mensaje.Frase;

                pbxCartaCantada.Image = CargarImagen(mensaje.RutaImagen);

                // Agregar: Sonido de "¡Corre y va corriendo!"
            }));
        }

        private void btnLoteria_Click(object sender, EventArgs e)
        {

            cliente.EnviarTabla(cliente.ObtenerTabla());
        }

        private Image CargarImagen(string nombreArchivo)
        {
            string ruta = Path.Combine(Application.StartupPath, "Resources", nombreArchivo);
            return File.Exists(ruta) ? Image.FromFile(ruta) : null;
        }

        private void FinalizarPartidaUI(MensajeGanador mensaje)
        {
            this.Invoke(new Action(() =>
            {
                MessageBox.Show($"¡El ganador es {mensaje.Usuario}!");
                if (servidor != null)
                {
                    frmPrincipal.MostrarControl(new PostJuegoControl(mensaje.Usuario, frmPrincipal, servidor));
                }
                else
                {
                    frmPrincipal.MostrarControl(new PostJuegoControl(mensaje.Usuario, frmPrincipal));
                }
            }));
        }

        private void btnSacarCarta_Click(object sender, EventArgs e)
        {

            if (servidor.MazoVacio)
            {
                MessageBox.Show("No hay más cartas en el mazo.");
                return;
            }
            servidor.SacarCarta();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                cliente.EnviarMensaje(txtMensaje.Text);
                txtMensaje.Clear();
            }
            else
             {
                MessageBox.Show("No puedes enviar un mensaje vacío.");
            }
        }

        private void ActualizarScoreboard()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ActualizarScoreboard));
                return;
            }
            dgvScoreboard.Rows.Clear();
            foreach (var jugador in servidor.ObtenerJugadores())
            {
                dgvScoreboard.Rows.Add(jugador.Nombre, jugador.PartidasGanadas);
            }
        }

        private void RefrescarChat(MensajeChat mensaje)
        {
            this.Invoke(new Action(() =>
            {
                txtChat.AppendText($"{mensaje.Usuario}: {mensaje.Contenido}{Environment.NewLine}");
            }));
        }
    }
}
