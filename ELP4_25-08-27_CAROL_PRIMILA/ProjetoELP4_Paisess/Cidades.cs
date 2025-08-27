using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class Cidades: Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

    public Cidades():base()
        {
            cidade = "";
            ddd = string.Empty;
            oEstado = new Estados();
        }
        public Cidades(int codigo, DateTime datcad, DateTime ultalt, string cidade, string ddd, Estados oEstado)
            : base(codigo, datcad, ultalt)
        {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado;
        }
        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }
        public string Ddd
        {
            get => ddd;
            set => ddd = value;
        }
        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}
