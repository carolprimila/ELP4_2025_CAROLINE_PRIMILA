using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlCidades : Controller
    {
        ColCidades aColCidades;
        DaoCidades aDaoCidades;
        public CtrlCidades()
        {
            aColCidades = new ColCidades();
            aDaoCidades = new DaoCidades();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            return aDaoCidades.Salvar(obj);
        }
        public List<Cidades> TodosCidades()
        {
            return aColCidades.RetornaLista();
        }
    }
}
