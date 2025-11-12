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
        //Controller<T> aCtrl;
        CtrlPaises aCtrlPaises;
        public FrmConsPaises()
        {
            aCtrlPaises = new CtrlPaises();
            InitializeComponent();
        }
        protected override void Pesquisar()
        {
            ListV.Items.Clear();
            List<Paises> lista = aCtrlPaises.Pesquisar(txtCodigo.Text);

            foreach (var oPais in lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                ListV.Items.Add(item);
            }
        }
        protected override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            if (ListV.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = ListV.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[0].Text);

            DialogResult confirm = MessageBox.Show(
                "Deseja realmente excluir este país?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                Paises oPais = new Paises();
                oPais.Codigo = id;

                string msg = aCtrlPaises.Excluir(oPais);
                MessageBox.Show(msg);
                CarregaLV();
            }
            //    string aux;
            //oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            //oFrmCadPaises.LimpaTxt();
            //oFrmCadPaises.BloquearTxt();
            //aux = oFrmCadPaises.btnSalvar.Text;
            //oFrmCadPaises.btnSalvar.Text = "Excluir";
            //oFrmCadPaises.ShowDialog();
            //oFrmCadPaises.DesbloquearTxt();
            //oFrmCadPaises.btnSalvar.Text = aux;
            //this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            ListV.Items.Clear();
            foreach (var oPais in aCtrlPaises.TodosPaises())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                ListV.Items.Add(item);
            }
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
                aCtrlPaises = (CtrlPaises)ctrl;
            this.CarregaLV();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
    }
}
