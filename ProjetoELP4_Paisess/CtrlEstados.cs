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
        DaoEstados aDaoEstados;
        public CtrlEstados()
        {
            aColEstados = new ColEstados();
            aDaoEstados = new DaoEstados();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            return aDaoEstados.Salvar(obj);
        }
        public List<Estados> TodosEstados()
        {
            return aColEstados.RetornaLista();
        }
    }
}
