using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class frmCadEstados : ProjetoELP4_Paisess.frmCadastros
    {
        Estados oEstado;
        Controller aCtrl;
        public frmCadEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj == null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        protected override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            //aCtrl.Salvar(oEstado);
        }

        protected override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text = oEstado.Uf;
        }
        protected override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }
        protected override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
        }
        protected override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
        }
    }
}
