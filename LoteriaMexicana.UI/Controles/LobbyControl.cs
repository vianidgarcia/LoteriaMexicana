using LoteriaMexicanaModelos;
using LoteriaMexicanaModelos.Mensajes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaMexicana.UI.Controles
{
    public partial class LobbyControl : UserControl
    {
        private Servidor servidor;
        private Cliente cliente;
        private FrmPrincipal frmPrincipal;

        public LobbyControl(Servidor servidor, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.servidor = servidor;
            this.frmPrincipal = frmPrincipal;
            servidor.OnJugadorConectado += JugadorConectado;
            string ip = Dns.GetHostEntry(Dns.GetHostName())
              .AddressList
              .First(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
              .ToString();
            lblIp.Text = "Tu IP" + ip;
        }

        public LobbyControl(Cliente cliente, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
            this.cliente = cliente;
            cliente.OnJugadorConectado += JugadorConectado;
            cliente.OnPartidaIniciada += PartidaIniciada;
            btnComenzarPartida.Visible = false;
            lblIp.Visible = false;
        }

        private void PartidaIniciada(MensajeIniciarPartida mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<MensajeIniciarPartida>(PartidaIniciada), mensaje);
                return;
            }

            frmPrincipal.MostrarControl(new PartidaControl(cliente, frmPrincipal));
        }

        private void JugadorConectado(string nombre)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(JugadorConectado), nombre);
                return;
            }

            lbxJugadoresConectados.Items.Add(nombre);
        }

        private void btnComenzarPartida_Click(object sender, EventArgs e)
        {
                MensajeIniciarPartida mensaje = new MensajeIniciarPartida();
                string json = JsonSerializer.Serialize(mensaje);
                servidor.EnviarATodos(json);
                frmPrincipal.MostrarControl(new PartidaControl(servidor, frmPrincipal));
        }
    }
}
