namespace LoteriaMexicana.UI.Controles
{
    partial class TablaControl
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
            tlpTabla = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpTabla
            // 
            tlpTabla.ColumnCount = 4;
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTabla.Location = new Point(2, 0);
            tlpTabla.Margin = new Padding(0);
            tlpTabla.Name = "tlpTabla";
            tlpTabla.RowCount = 4;
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpTabla.Size = new Size(450, 672);
            tlpTabla.TabIndex = 0;
            // 
            // TablaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpTabla);
            Name = "TablaControl";
            Size = new Size(455, 672);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpTabla;
    }
}
