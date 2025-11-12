using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlCidades : Controller<Cidades>
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
            return aDaoCidades.Listar();
        }
        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return aDaoCidades.Pesquisar(chave);
        }
    }
}
