namespace LoteriaMexicana.UI.Controles
{
    partial class MenuControl
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
            btnCrearPartida = new Button();
            btnUnirsePartida = new Button();
            SuspendLayout();
            // 
            // btnCrearPartida
            // 
            btnCrearPartida.Location = new Point(90, 82);
            btnCrearPartida.Name = "btnCrearPartida";
            btnCrearPartida.Size = new Size(131, 23);
            btnCrearPartida.TabIndex = 0;
            btnCrearPartida.Text = "Crear Partida";
            btnCrearPartida.UseVisualStyleBackColor = true;
            // 
            // btnUnirsePartida
            // 
            btnUnirsePartida.Location = new Point(90, 133);
            btnUnirsePartida.Name = "btnUnirsePartida";
            btnUnirsePartida.Size = new Size(131, 23);
            btnUnirsePartida.TabIndex = 1;
            btnUnirsePartida.Text = "Unirse a Partida";
            btnUnirsePartida.UseVisualStyleBackColor = true;
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUnirsePartida);
            Controls.Add(btnCrearPartida);
            Name = "MenuControl";
            Size = new Size(341, 212);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearPartida;
        private Button btnUnirsePartida;
    }
}
