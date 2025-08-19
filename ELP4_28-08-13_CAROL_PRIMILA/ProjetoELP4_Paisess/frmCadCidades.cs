using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class frmCadCidades : ProjetoELP4_Paisess.frmCadastros
    {
        Cidades oCidade; 
        Controller aCtrl;
        public frmCadCidades()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj == null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        protected override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            oCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.Ddd = txtDDD.Text;
            //aCtrl.Salvar(oCidade);
        }
        protected override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oCidade.Codigo);
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDDD.Text = oCidade.Ddd;
        }
        protected override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
        }
        protected override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
        }
        protected override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
        }
    }
}
