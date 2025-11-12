using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class frmConsCidades : ProjetoELP4_Paisess.frmConsultas
    {
        frmCadCidades oFrmCadCidades;
        Cidades oCidade;
        //Controller aCtrl;
        CtrlCidades aCtrlCidades;
        public frmConsCidades()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {
            ListV.Items.Clear();
            List<Cidades> lista = aCtrlCidades.Pesquisar(txtCodigo.Text);

            foreach (var oCidade in lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oCidade.Codigo));
                item.SubItems.Add(oCidade.Cidade);
                item.SubItems.Add(oCidade.Ddd);
                item.SubItems.Add(Convert.ToString(oCidade.OEstado.Codigo));
                item.SubItems.Add(oCidade.OEstado.Estado);
                ListV.Items.Add(item);
            }
        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
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
                "Deseja realmente excluir esta cidade?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                Cidades oCidade = new Cidades();
                oCidade.Codigo = id;

                string msg = aCtrlCidades.Excluir(oCidade);
                MessageBox.Show(msg);
                CarregaLV();
            }

            //string aux;
            //oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            //oFrmCadCidades.LimpaTxt();
            //oFrmCadCidades.BloquearTxt();
            //aux = oFrmCadCidades.btnSalvar.Text;
            //oFrmCadCidades.btnSalvar.Text = "Excluir";
            //oFrmCadCidades.ShowDialog();
            //oFrmCadCidades.DesbloquearTxt();
            //oFrmCadCidades.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }
        protected override void CarregaLV()
        {
            ListV.Items.Clear();
            foreach (var oCidade in aCtrlCidades.TodosCidades())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oCidade.Codigo));
                item.SubItems.Add(oCidade.Cidade);
                item.SubItems.Add(oCidade.Ddd);
                item.SubItems.Add(Convert.ToString(oCidade.OEstado.Codigo));
                item.SubItems.Add(oCidade.OEstado.Estado);
                ListV.Items.Add(item);
            }
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (frmCadCidades)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
            this.CarregaLV();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
