using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        protected virtual void Sair()
        {
            Close();
        }
        protected virtual void setFrmCadastro(object obj)
        {
            
        }
        public virtual void ConhecaObj(object obj, object ctrl)
        {

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
