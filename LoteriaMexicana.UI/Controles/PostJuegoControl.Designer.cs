namespace LoteriaMexicana.UI.Controles
{
    partial class PostJuegoControl
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
            lblGanador = new Label();
            btnVolverAlMenu = new Button();
            btnJugarDeNuevo = new Button();
            SuspendLayout();
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(168, 65);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(155, 15);
            lblGanador.TabIndex = 0;
            lblGanador.Text = "¡Jugador ha sido el ganador!";
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(97, 123);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(203, 23);
            btnVolverAlMenu.TabIndex = 1;
            btnVolverAlMenu.Text = "Volver al menú";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // btnJugarDeNuevo
            // 
            btnJugarDeNuevo.Location = new Point(119, 185);
            btnJugarDeNuevo.Name = "btnJugarDeNuevo";
            btnJugarDeNuevo.Size = new Size(167, 23);
            btnJugarDeNuevo.TabIndex = 2;
            btnJugarDeNuevo.Text = "Jugar de nuevo";
            btnJugarDeNuevo.UseVisualStyleBackColor = true;
            // 
            // PostJuegoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnJugarDeNuevo);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(lblGanador);
            Name = "PostJuegoControl";
            Size = new Size(412, 386);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGanador;
        private Button btnVolverAlMenu;
        private Button btnJugarDeNuevo;
    }
}
