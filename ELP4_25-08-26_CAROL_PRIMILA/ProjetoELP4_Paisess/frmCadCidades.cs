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
        frmConsEstados ofrmConsEstados;
        public frmCadCidades()
        {
            InitializeComponent();
        }
        public void setFrmConsEstados(Object obj)
        {
            if (obj != null)
            {
                ofrmConsEstados = (frmConsEstados)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
              oCidade = (Cidades)obj;
            if (ctrl != null)
              aCtrl = (Controller)ctrl;
        }

        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            oCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.Ddd = txtDDD.Text;
            //aCtrl.Salvar(oCidade);
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oCidade.Codigo);
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDDD.Text = oCidade.Ddd;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = ofrmConsEstados.btnSair.Text;
            ofrmConsEstados.btnSair.Text = "Selecionar";
            ofrmConsEstados.ConhecaObj(oCidade.OEstado, aCtrl);
            ofrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(oCidade.OEstado.Codigo);
            this.txtEstado.Text = oCidade.OEstado.Estado.ToString();
            ofrmConsEstados.btnSair.Text = btnSair;
        }
    }
}
