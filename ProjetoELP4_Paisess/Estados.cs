using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoELP4_Paisess
{
    internal class Estados: Pai
    {
        protected string estado;
        protected string uf;
        protected Paises oPais;
        public Estados():base()
        {
            estado = "";
            uf = string.Empty;
            oPais = new Paises();
        }

        public Estados(int codigo, DateTime datcad, DateTime ultalt, string estado, string uf,
            Paises oPais)
            : base(codigo, datcad, ultalt)
        {   
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais;
        }
        public Estados Clone()
        {
            return new Estados(this.codigo, this.datcad, this.ultalt, this.estado, this.uf,
                this.oPais);
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }

        public string Uf
        {
            get => uf;
            set => uf = value;
        }

        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }
    }
}

