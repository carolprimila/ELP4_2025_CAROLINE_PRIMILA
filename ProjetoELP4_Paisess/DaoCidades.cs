using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class DaoCidades : DAO
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string mSql = "", mOk = "";

            if (oCidade.Codigo == 0)
            {
                mSql = "insert into cidades(cidade, ddd, idestado) values(@cidade, @ddd, @idestado)";
            }
            else
            {
                mSql = "update cidades set cidade = @cidade, ddd = @ddd, idestado = @idestado where id = @id";
            }

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@cidade", oCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", oCidade.Ddd);
                cmd.Parameters.AddWithValue("@idestado", oCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@id", oCidade.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@identity";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override List<object> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<object> Pesquisar(string chave)
        {
            return null;
        }
    }
}
