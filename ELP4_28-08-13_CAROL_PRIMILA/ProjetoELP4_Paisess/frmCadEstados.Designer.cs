namespace ProjetoELP4_Paisess
{
    partial class frmCadEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(623, 415);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(704, 415);
            this.btnSair.Size = new System.Drawing.Size(84, 23);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(97, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(211, 9);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(25, 16);
            this.lblUf.TabIndex = 11;
            this.lblUf.Text = "UF";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(100, 28);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(96, 22);
            this.txtEstado.TabIndex = 12;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(214, 28);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(56, 22);
            this.txtUf.TabIndex = 13;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(291, 9);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoPais.TabIndex = 14;
            this.lblCodigoPais.Text = "Codigo";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(377, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "Pais";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(294, 28);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(69, 22);
            this.txtCodigoPais.TabIndex = 16;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(380, 28);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(499, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblEstado);
            this.Name = "frmCadEstados";
            this.Text = "Cadastros de Estados";
            this.Load += new System.EventHandler(this.frmCadEstados_Load);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUf, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUf, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnBuscar;
    }
}
