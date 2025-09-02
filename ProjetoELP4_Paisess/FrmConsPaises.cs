using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class FrmConsPaises : ProjetoELP4_Paisess.frmConsultas
    {
        frmCadPaises oFrmCadPaises;
        Paises oPais;
        Controller aCtrl;
        public FrmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.BloquearTxt();
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();
            oFrmCadPaises.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadPaises = (frmCadPaises)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
    }
}
