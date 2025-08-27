using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoELP4_Paisess
{

    public partial class FrmPrincipal : Form
    {
        Interfaces aInter = new Interfaces();
        Paises oPais = new Paises();
        Estados oEstado = new Estados();
        Cidades oCidade = new Cidades();
        Controller aCtrl = new Controller();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, aCtrl);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, aCtrl);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(oCidade, aCtrl);
        }
    }
}
