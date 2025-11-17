using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{
    public partial class frmConsEstados : ProjetoELP4_Paisess.frmConsultas
    {
        frmCadEstados oFrmCadEstados;
        Estados oEstado;
        //Controller aCtrl;
        CtrlEstados aCtrlEstados;
        public frmConsEstados()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {
            ListV.Items.Clear();
            List<Estados> lista = aCtrlEstados.Pesquisar(txtCodigo.Text);

            foreach (var oEstado in lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
                item.SubItems.Add(oEstado.OPais.Pais);
                ListV.Items.Add(item);
            }
        }
        protected override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            if (ListV.SelectedItems.Count == 0)
            {
                return;
            }

            var item = ListV.SelectedItems[0];

            oEstado.Codigo = Convert.ToInt32(item.SubItems[0].Text);
            oEstado.Estado = item.SubItems[1].Text;
            oEstado.Uf = item.SubItems[2].Text;

            if (oEstado.OPais == null)
                oEstado.OPais = new Paises();

            oEstado.OPais.Codigo = Convert.ToInt32(item.SubItems[3].Text);
            oEstado.OPais.Pais = item.SubItems[4].Text;

            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }
        protected override void CarregaLV()
        { 
            ListV.Items.Clear();
            foreach (var oEstado in aCtrlEstados.TodosEstados())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
                item.SubItems.Add(oEstado.OPais.Pais);
                ListV.Items.Add(item);
            }
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadEstados = (frmCadEstados)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrlEstados = (CtrlEstados)ctrl;
            this.CarregaLV();
        }
    }
}
