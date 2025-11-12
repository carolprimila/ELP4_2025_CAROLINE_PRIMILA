using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlPaises : Controller<Paises>
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
            return aDaoPaises.Salvar(obj);
        }
        public List<Paises> TodosPaises()
        {
            return aDaoPaises.Listar();
        }
        public override string Excluir(object obj)
        {
            return aDaoPaises.Excluir(obj);
        }
        public override List<Paises> Pesquisar(string chave)
        {
            return aDaoPaises.Pesquisar(chave);
        }
    }
}
