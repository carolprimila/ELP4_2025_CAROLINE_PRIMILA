using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlPaises : Controller
    {
        ColPaises aColPaises;
        DaoPaises aDaoPaises;
        public CtrlPaises()
        {
            aColPaises = new ColPaises();
            aDaoPaises = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            return  aDaoPaises.Salvar(obj);
        }
        public List<Paises> TodosPaises()
        {
            return aColPaises.RetornaLista();
        }
    }
}
