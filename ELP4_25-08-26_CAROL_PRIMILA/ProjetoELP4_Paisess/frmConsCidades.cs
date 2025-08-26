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
        Controller aCtrl;
        public frmConsCidades()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
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
                aCtrl = (Controller)ctrl;
        }
    }
}
