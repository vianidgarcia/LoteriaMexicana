namespace LoteriaMexicana.UI.Controles
{
    partial class CrearPartidaControl
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
            txtNombreHost = new TextBox();
            txtPuerto = new TextBox();
            clbxCondicionesGanar = new CheckedListBox();
            numTablasJugador = new NumericUpDown();
            btnEmpezar = new Button();
            btnVolver = new Button();
            lblNombreHost = new Label();
            lblPuerto = new Label();
            lblCondicionesGanar = new Label();
            lblTablasJugador = new Label();
            ((System.ComponentModel.ISupportInitialize)numTablasJugador).BeginInit();
            SuspendLayout();
            // 
            // txtNombreHost
            // 
            txtNombreHost.Location = new Point(195, 18);
            txtNombreHost.Name = "txtNombreHost";
            txtNombreHost.Size = new Size(100, 23);
            txtNombreHost.TabIndex = 0;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(195, 47);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 1;
            txtPuerto.Text = "5000";
            // 
            // clbxCondicionesGanar
            // 
            clbxCondicionesGanar.FormattingEnabled = true;
            clbxCondicionesGanar.Location = new Point(195, 76);
            clbxCondicionesGanar.Name = "clbxCondicionesGanar";
            clbxCondicionesGanar.Size = new Size(120, 94);
            clbxCondicionesGanar.TabIndex = 2;
            // 
            // numTablasJugador
            // 
            numTablasJugador.Location = new Point(195, 181);
            numTablasJugador.Name = "numTablasJugador";
            numTablasJugador.Size = new Size(120, 23);
            numTablasJugador.TabIndex = 3;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Location = new Point(245, 257);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(75, 23);
            btnEmpezar.TabIndex = 4;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(25, 255);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombreHost
            // 
            lblNombreHost.AutoSize = true;
            lblNombreHost.Location = new Point(15, 26);
            lblNombreHost.Name = "lblNombreHost";
            lblNombreHost.Size = new Size(96, 15);
            lblNombreHost.TabIndex = 6;
            lblNombreHost.Text = "Nombre del host";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(18, 54);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 7;
            lblPuerto.Text = "Puerto";
            // 
            // lblCondicionesGanar
            // 
            lblCondicionesGanar.AutoSize = true;
            lblCondicionesGanar.Location = new Point(17, 91);
            lblCondicionesGanar.Name = "lblCondicionesGanar";
            lblCondicionesGanar.Size = new Size(132, 15);
            lblCondicionesGanar.TabIndex = 8;
            lblCondicionesGanar.Text = "Condiciones para ganar";
            // 
            // lblTablasJugador
            // 
            lblTablasJugador.AutoSize = true;
            lblTablasJugador.Location = new Point(23, 183);
            lblTablasJugador.Name = "lblTablasJugador";
            lblTablasJugador.Size = new Size(166, 15);
            lblTablasJugador.TabIndex = 9;
            lblTablasJugador.Text = "Número de tablas por jugador";
            // 
            // CrearPartidaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTablasJugador);
            Controls.Add(lblCondicionesGanar);
            Controls.Add(lblPuerto);
            Controls.Add(lblNombreHost);
            Controls.Add(btnVolver);
            Controls.Add(btnEmpezar);
            Controls.Add(numTablasJugador);
            Controls.Add(clbxCondicionesGanar);
            Controls.Add(txtPuerto);
            Controls.Add(txtNombreHost);
            Name = "CrearPartidaControl";
            Size = new Size(337, 296);
            ((System.ComponentModel.ISupportInitialize)numTablasJugador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreHost;
        private TextBox txtPuerto;
        private CheckedListBox clbxCondicionesGanar;
        private NumericUpDown numTablasJugador;
        private Button btnEmpezar;
        private Button btnVolver;
        private Label lblNombreHost;
        private Label lblPuerto;
        private Label lblCondicionesGanar;
        private Label lblTablasJugador;
    }
}
