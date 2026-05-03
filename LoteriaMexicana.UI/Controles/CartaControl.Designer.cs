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
            pbxFicha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxCarta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFicha).BeginInit();
            SuspendLayout();
            // 
            // pbxCarta
            // 
            pbxCarta.Location = new Point(0, 0);
            pbxCarta.Margin = new Padding(0);
            pbxCarta.Name = "pbxCarta";
            pbxCarta.Size = new Size(106, 169);
            pbxCarta.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCarta.TabIndex = 0;
            pbxCarta.TabStop = false;
            pbxCarta.Click += pbxCarta_Click;
            // 
            // pbxFicha
            // 
            pbxFicha.Location = new Point(27, 58);
            pbxFicha.Name = "pbxFicha";
            pbxFicha.Size = new Size(52, 51);
            pbxFicha.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFicha.TabIndex = 2;
            pbxFicha.TabStop = false;
            // 
            // CartaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbxFicha);
            Controls.Add(pbxCarta);
            Name = "CartaControl";
            Size = new Size(106, 169);
            ((System.ComponentModel.ISupportInitialize)pbxCarta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFicha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxCarta;
        private PictureBox pbxFicha;
    }
}
