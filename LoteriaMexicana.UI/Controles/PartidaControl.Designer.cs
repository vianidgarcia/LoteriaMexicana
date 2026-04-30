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
            label1 = new Label();
            lblpruebacliente = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 74);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Soy un label de prueba:3";
            // 
            // lblpruebacliente
            // 
            lblpruebacliente.AutoSize = true;
            lblpruebacliente.Location = new Point(67, 126);
            lblpruebacliente.Name = "lblpruebacliente";
            lblpruebacliente.Size = new Size(136, 15);
            lblpruebacliente.TabIndex = 1;
            lblpruebacliente.Text = "Soy un label de prueba:3";
            // 
            // PartidaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblpruebacliente);
            Controls.Add(label1);
            Name = "PartidaControl";
            Size = new Size(271, 266);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblpruebacliente;
    }
}
