namespace LoteriaMexicana.UI.Controles
{
    partial class PartidaControl
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
            lblFrase = new Label();
            pbxCartaCantada = new PictureBox();
            btnLoteria = new Button();
            txtChat = new TextBox();
            btnSacarCarta = new Button();
            tcJugador = new TablaControl();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            lblFormasGanar = new Label();
            dgvScoreboard = new DataGridView();
            ColumnaJugador = new DataGridViewTextBoxColumn();
            ColumnaVictorias = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbxCartaCantada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvScoreboard).BeginInit();
            SuspendLayout();
            // 
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.Location = new Point(489, 189);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(60, 15);
            lblFrase.TabIndex = 0;
            lblFrase.Text = "Frasecarta";
            // 
            // pbxCartaCantada
            // 
            pbxCartaCantada.Location = new Point(489, 67);
            pbxCartaCantada.Name = "pbxCartaCantada";
            pbxCartaCantada.Size = new Size(86, 110);
            pbxCartaCantada.TabIndex = 2;
            pbxCartaCantada.TabStop = false;
            // 
            // btnLoteria
            // 
            btnLoteria.Location = new Point(489, 286);
            btnLoteria.Name = "btnLoteria";
            btnLoteria.Size = new Size(75, 23);
            btnLoteria.TabIndex = 3;
            btnLoteria.Text = "Loteria!";
            btnLoteria.UseVisualStyleBackColor = true;
            btnLoteria.Click += btnLoteria_Click;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(489, 315);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(286, 112);
            txtChat.TabIndex = 4;
            // 
            // btnSacarCarta
            // 
            btnSacarCarta.Location = new Point(489, 217);
            btnSacarCarta.Name = "btnSacarCarta";
            btnSacarCarta.Size = new Size(105, 41);
            btnSacarCarta.TabIndex = 6;
            btnSacarCarta.Text = "Sacar carta";
            btnSacarCarta.UseVisualStyleBackColor = true;
            btnSacarCarta.Click += btnSacarCarta_Click;
            // 
            // tcJugador
            // 
            tcJugador.Location = new Point(13, 13);
            tcJugador.Name = "tcJugador";
            tcJugador.Size = new Size(455, 672);
            tcJugador.TabIndex = 7;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(489, 433);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(174, 23);
            txtMensaje.TabIndex = 8;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(489, 462);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(174, 23);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar Mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblFormasGanar
            // 
            lblFormasGanar.Location = new Point(489, 13);
            lblFormasGanar.Name = "lblFormasGanar";
            lblFormasGanar.Size = new Size(174, 33);
            lblFormasGanar.TabIndex = 10;
            lblFormasGanar.Text = "Formas de ganar:";
            // 
            // dgvScoreboard
            // 
            dgvScoreboard.AllowUserToAddRows = false;
            dgvScoreboard.AllowUserToDeleteRows = false;
            dgvScoreboard.AllowUserToResizeColumns = false;
            dgvScoreboard.AllowUserToResizeRows = false;
            dgvScoreboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvScoreboard.Columns.AddRange(new DataGridViewColumn[] { ColumnaJugador, ColumnaVictorias });
            dgvScoreboard.Location = new Point(487, 499);
            dgvScoreboard.Name = "dgvScoreboard";
            dgvScoreboard.Size = new Size(288, 165);
            dgvScoreboard.TabIndex = 11;
            // 
            // ColumnaJugador
            // 
            ColumnaJugador.DataPropertyName = "ColumnaJugador";
            ColumnaJugador.HeaderText = "Jugador";
            ColumnaJugador.Name = "ColumnaJugador";
            ColumnaJugador.ReadOnly = true;
            // 
            // ColumnaVictorias
            // 
            ColumnaVictorias.DataPropertyName = "ColumnaVictorias";
            ColumnaVictorias.HeaderText = "Victorias";
            ColumnaVictorias.Name = "ColumnaVictorias";
            ColumnaVictorias.ReadOnly = true;
            // 
            // PartidaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvScoreboard);
            Controls.Add(lblFormasGanar);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(tcJugador);
            Controls.Add(btnSacarCarta);
            Controls.Add(txtChat);
            Controls.Add(btnLoteria);
            Controls.Add(pbxCartaCantada);
            Controls.Add(lblFrase);
            Name = "PartidaControl";
            Size = new Size(794, 698);
            ((System.ComponentModel.ISupportInitialize)pbxCartaCantada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvScoreboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrase;
        private PictureBox pbxCartaCantada;
        private Button btnLoteria;
        private TextBox txtChat;
        private Button btnSacarCarta;
        private TablaControl tcJugador;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private Label lblFormasGanar;
        private DataGridView dgvScoreboard;
        private DataGridViewTextBoxColumn ColumnaJugador;
        private DataGridViewTextBoxColumn ColumnaVictorias;
    }
}
