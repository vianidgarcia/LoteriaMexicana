namespace LoteriaMexicana.UI.Controles
{
    partial class CartaControl
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
            pbxCarta = new PictureBox();
            lblNombre = new Label();
            pbxFicha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxCarta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFicha).BeginInit();
            SuspendLayout();
            // 
            // pbxCarta
            // 
            pbxCarta.Location = new Point(14, 14);
            pbxCarta.Name = "pbxCarta";
            pbxCarta.Size = new Size(233, 303);
            pbxCarta.TabIndex = 0;
            pbxCarta.TabStop = false;
            pbxCarta.Click += pbxCarta_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(114, 274);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label1";
            // 
            // pbxFicha
            // 
            pbxFicha.Location = new Point(87, 125);
            pbxFicha.Name = "pbxFicha";
            pbxFicha.Size = new Size(87, 82);
            pbxFicha.TabIndex = 2;
            pbxFicha.TabStop = false;
            // 
            // CartaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbxFicha);
            Controls.Add(lblNombre);
            Controls.Add(pbxCarta);
            Name = "CartaControl";
            Size = new Size(263, 331);
            ((System.ComponentModel.ISupportInitialize)pbxCarta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFicha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCarta;
        private Label lblNombre;
        private PictureBox pbxFicha;
    }
}
