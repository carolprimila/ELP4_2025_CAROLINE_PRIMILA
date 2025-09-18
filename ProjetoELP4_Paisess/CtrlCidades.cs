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
        public CtrlCidades()
        {
            aColCidades = new ColCidades();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Cidades oCidade = (Cidades)obj;
            if (oCidade.Codigo == 0)
            {
                aColCidades.Inserir((Cidades)obj);
            }
            else
            {

            }
        }
    }
}
