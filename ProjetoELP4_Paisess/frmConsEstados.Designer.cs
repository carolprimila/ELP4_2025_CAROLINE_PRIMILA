namespace ProjetoELP4_Paisess
{
    partial class frmConsEstados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(450, 415);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(531, 415);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(612, 415);
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstado,
            this.colUf,
            this.colCodPais,
            this.colPais});
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(693, 415);
            this.btnSair.Size = new System.Drawing.Size(95, 23);
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            // 
            // colUf
            // 
            this.colUf.Text = "UF";
            // 
            // colCodPais
            // 
            this.colCodPais.Text = "Código País";
            this.colCodPais.Width = 125;
            // 
            // colPais
            // 
            this.colPais.Text = "País";
            this.colPais.Width = 200;
            // 
            // frmConsEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsEstados";
            this.Text = "Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colUf;
        private System.Windows.Forms.ColumnHeader colCodPais;
        private System.Windows.Forms.ColumnHeader colPais;
    }
}
