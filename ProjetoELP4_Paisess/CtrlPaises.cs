using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class CtrlPaises : Controller
    {
        //ColPaises aColPaises;
        private static ColPaises aColPaises = new ColPaises();
        public CtrlPaises()
        {
            aColPaises = new ColPaises();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Paises oPais = (Paises)obj;
            if (oPais.Codigo == 0)
            {
                aColPaises.Inserir((Paises)obj);
            }
            else
            {

            }
        }
        public static List<Paises> TodosPaises
        {
            get { return aColPaises.Todos(); }
        }
    }
}
