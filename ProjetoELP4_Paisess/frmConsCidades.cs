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
            string aux;
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.BloquearTxt(); 
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
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
            foreach (var oCidade in CtrlCidades.TodosCidades)
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
        }
    }
}
