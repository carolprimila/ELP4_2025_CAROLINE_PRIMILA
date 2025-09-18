using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class frmCadastros : ProjetoELP4_Paisess.Frm
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }
        public virtual void Salvar()
        {
            
        }
        public virtual void CarregaTxt()
        {

        }
        public virtual void LimpaTxt()
        {

        }
        public virtual void BloquearTxt()
        {

        }
        public virtual void DesbloquearTxt()
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
