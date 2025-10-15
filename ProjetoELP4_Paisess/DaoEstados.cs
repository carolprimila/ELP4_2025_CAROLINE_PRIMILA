using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class DaoEstados : DAO
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";

            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(estado, uf, idpais) values(@estado, @uf, @idpais)";
            }
            else
            {
                mSql = "update estados set estado = @estado, uf = @uf, idpais = @idpais where id = @id";
            }

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@idpais", oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@id", oEstado.Codigo);
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
