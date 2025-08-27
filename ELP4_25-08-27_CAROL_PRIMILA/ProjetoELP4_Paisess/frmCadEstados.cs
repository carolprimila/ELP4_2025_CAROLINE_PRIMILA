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
        FrmConsPaises ofrmConsPaises;
        public frmCadEstados()
        {
            InitializeComponent();
            
        }
        public void setFrmConsPaises(Object obj) 
        {
            if (obj != null)
            {
                ofrmConsPaises = (FrmConsPaises)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            //aCtrl.Salvar(oEstado);
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text = oEstado.Uf;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
        }

        private void frmCadEstados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = ofrmConsPaises.btnSair.Text;
            ofrmConsPaises.btnSair.Text = "Selecionar";
            ofrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            ofrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais.ToString();
            ofrmConsPaises.btnSair.Text = btnSair;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
