namespace ProjetoELP4_Paisess
{
    partial class frmCadastros
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txtDatCad = new System.Windows.Forms.TextBox();
            this.txtUltAlt = new System.Windows.Forms.TextBox();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 28);
            this.txtCodigo.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(632, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(51, 16);
            this.lbl_Codigo.TabIndex = 3;
            this.lbl_Codigo.Text = "Codigo";
            this.lbl_Codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatCad
            // 
            this.txtDatCad.Location = new System.Drawing.Point(188, 416);
            this.txtDatCad.Name = "txtDatCad";
            this.txtDatCad.Size = new System.Drawing.Size(100, 22);
            this.txtDatCad.TabIndex = 17;
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.Location = new System.Drawing.Point(321, 416);
            this.txtUltAlt.Name = "txtUltAlt";
            this.txtUltAlt.Size = new System.Drawing.Size(100, 22);
            this.txtUltAlt.TabIndex = 18;
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.Location = new System.Drawing.Point(449, 416);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.Size = new System.Drawing.Size(100, 22);
            this.txtCodUsu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Cad.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dat Ult Alt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário";
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodUsu);
            this.Controls.Add(this.txtUltAlt);
            this.Controls.Add(this.txtDatCad);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastros";
            this.Text = "Cadastros";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodUsu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txtDatCad;
        private System.Windows.Forms.TextBox txtUltAlt;
        private System.Windows.Forms.TextBox txtCodUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSalvar;
    }
}
