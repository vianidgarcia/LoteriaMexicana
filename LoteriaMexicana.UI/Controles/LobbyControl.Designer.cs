namespace LoteriaMexicana.UI.Controles
{
    partial class LobbyControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblEsperandoJugadores = new Label();
            lbxJugadoresConectados = new ListBox();
            btnComenzarPartida = new Button();
            lblIp = new Label();
            SuspendLayout();
            // 
            // lblEsperandoJugadores
            // 
            lblEsperandoJugadores.AutoSize = true;
            lblEsperandoJugadores.Location = new Point(103, 22);
            lblEsperandoJugadores.Name = "lblEsperandoJugadores";
            lblEsperandoJugadores.Size = new Size(136, 15);
            lblEsperandoJugadores.TabIndex = 0;
            lblEsperandoJugadores.Text = "Esperando Jugadores . . .";
            // 
            // lbxJugadoresConectados
            // 
            lbxJugadoresConectados.FormattingEnabled = true;
            lbxJugadoresConectados.ItemHeight = 15;
            lbxJugadoresConectados.Location = new Point(30, 54);
            lbxJugadoresConectados.Name = "lbxJugadoresConectados";
            lbxJugadoresConectados.Size = new Size(289, 139);
            lbxJugadoresConectados.TabIndex = 1;
            // 
            // btnComenzarPartida
            // 
            btnComenzarPartida.Location = new Point(30, 210);
            btnComenzarPartida.Name = "btnComenzarPartida";
            btnComenzarPartida.Size = new Size(151, 23);
            btnComenzarPartida.TabIndex = 2;
            btnComenzarPartida.Text = "Comenzar Partida";
            btnComenzarPartida.UseVisualStyleBackColor = true;
            btnComenzarPartida.Click += btnComenzarPartida_Click;
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(187, 214);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(17, 15);
            lblIp.TabIndex = 3;
            lblIp.Text = "IP";
            // 
            // LobbyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIp);
            Controls.Add(btnComenzarPartida);
            Controls.Add(lbxJugadoresConectados);
            Controls.Add(lblEsperandoJugadores);
            Name = "LobbyControl";
            Size = new Size(348, 256);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEsperandoJugadores;
        private ListBox lbxJugadoresConectados;
        private Button btnComenzarPartida;
        private Label lblIp;
    }
}
