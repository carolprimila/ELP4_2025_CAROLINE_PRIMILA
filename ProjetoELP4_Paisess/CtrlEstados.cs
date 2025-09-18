using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlEstados : Controller
    {
        ColEstados aColEstados;
        public CtrlEstados()
        {
            aColEstados = new ColEstados();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Estados oEstado = (Estados)obj;
            if (oEstado.Codigo == 0)
            {
                aColEstados.Inserir((Estados)obj);
            }
            else
            {

            }
        }
    }
}
