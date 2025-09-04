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
        Controller aCtrl;
        public frmConsEstados()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }
        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
            item.SubItems.Add(oEstado.Estado);
            item.SubItems.Add(oEstado.Uf);
            item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
            item.SubItems.Add(oEstado.OPais.Pais);
            ListV.Items.Add(item);
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
                aCtrl = (Controller)ctrl;
        }
    }
}
