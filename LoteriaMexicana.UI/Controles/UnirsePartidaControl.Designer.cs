namespace LoteriaMexicana.UI.Controles
{
    partial class UnirsePartidaControl
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
            txtNombre = new TextBox();
            txtIp = new TextBox();
            txtPuerto = new TextBox();
            btnVolver = new Button();
            btnUnirse = new Button();
            lblNombre = new Label();
            lblIp = new Label();
            lblPuerto = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(168, 96);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(100, 23);
            txtIp.TabIndex = 1;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(169, 133);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 2;
            txtPuerto.Text = "5000";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 234);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnUnirse
            // 
            btnUnirse.Location = new Point(322, 234);
            btnUnirse.Name = "btnUnirse";
            btnUnirse.Size = new Size(75, 23);
            btnUnirse.TabIndex = 4;
            btnUnirse.Text = "Unirse";
            btnUnirse.UseVisualStyleBackColor = true;
            btnUnirse.Click += btnUnirse_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(115, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre del Jugador";
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(48, 98);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(81, 15);
            lblIp.TabIndex = 6;
            lblIp.Text = "Ip del servidor";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(56, 136);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 7;
            lblPuerto.Text = "Puerto";
            // 
            // UnirsePartidaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPuerto);
            Controls.Add(lblIp);
            Controls.Add(lblNombre);
            Controls.Add(btnUnirse);
            Controls.Add(btnVolver);
            Controls.Add(txtPuerto);
            Controls.Add(txtIp);
            Controls.Add(txtNombre);
            Name = "UnirsePartidaControl";
            Size = new Size(453, 298);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtIp;
        private TextBox txtPuerto;
        private Button btnVolver;
        private Button btnUnirse;
        private Label lblNombre;
        private Label lblIp;
        private Label lblPuerto;
    }
}
