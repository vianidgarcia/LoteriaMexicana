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
            lblpruebacliente = new Label();
            pbxCartaCantada = new PictureBox();
            btnLoteria = new Button();
            txtChat = new TextBox();
            tcJugador = new TablaControl();
            ((System.ComponentModel.ISupportInitialize)pbxCartaCantada).BeginInit();
            SuspendLayout();
            // 
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.Location = new Point(157, 143);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(136, 15);
            lblFrase.TabIndex = 0;
            lblFrase.Text = "Soy un label de prueba:3";
            // 
            // lblpruebacliente
            // 
            lblpruebacliente.AutoSize = true;
            lblpruebacliente.Location = new Point(369, 20);
            lblpruebacliente.Name = "lblpruebacliente";
            lblpruebacliente.Size = new Size(136, 15);
            lblpruebacliente.TabIndex = 1;
            lblpruebacliente.Text = "Soy un label de prueba:3";
            // 
            // pbxCartaCantada
            // 
            pbxCartaCantada.Location = new Point(181, 20);
            pbxCartaCantada.Name = "pbxCartaCantada";
            pbxCartaCantada.Size = new Size(86, 110);
            pbxCartaCantada.TabIndex = 2;
            pbxCartaCantada.TabStop = false;
            // 
            // btnLoteria
            // 
            btnLoteria.Location = new Point(192, 488);
            btnLoteria.Name = "btnLoteria";
            btnLoteria.Size = new Size(75, 23);
            btnLoteria.TabIndex = 3;
            btnLoteria.Text = "button1";
            btnLoteria.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(414, 374);
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(100, 23);
            txtChat.TabIndex = 4;
            // 
            // tcJugador
            // 
            tcJugador.Location = new Point(122, 172);
            tcJugador.Name = "tcJugador";
            tcJugador.Size = new Size(234, 287);
            tcJugador.TabIndex = 5;
            // 
            // PartidaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tcJugador);
            Controls.Add(txtChat);
            Controls.Add(btnLoteria);
            Controls.Add(pbxCartaCantada);
            Controls.Add(lblpruebacliente);
            Controls.Add(lblFrase);
            Name = "PartidaControl";
            Size = new Size(571, 526);
            ((System.ComponentModel.ISupportInitialize)pbxCartaCantada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrase;
        private Label lblpruebacliente;
        private PictureBox pbxCartaCantada;
        private Button btnLoteria;
        private TextBox txtChat;
        private TablaControl tcJugador;
    }
}
