using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string mSql = "DELETE FROM cidades WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", oCidade.Codigo);
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                    return "Cidade excluída com sucesso!";
                else
                    return "Nenhuma cidade encontrada para excluir.";
            }
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
        public override List<Cidades> Listar()
        {
            string mSql = "select * from cidades order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Cidades> lista = new List<Cidades>();

                while (reader.Read())
                {
                    Cidades oCidade = new Cidades();
                    oCidade.Codigo = Convert.ToInt32(reader["id"]);
                    oCidade.Cidade = reader["cidade"].ToString();
                    oCidade.Ddd = reader["ddd"].ToString();

                    Estados oEstado = new Estados();
                    oEstado.Codigo = Convert.ToInt32(reader["idestado"]);
                    oCidade.OEstado = oEstado;

                    lista.Add(oCidade);
                }

                reader.Close();
                return lista;
            }
        }
        public override Object CarregaObj(int chave)
        {
            string mSql = "select * from cidades where id = 'chave'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Cidades cidades = new Cidades();

                while (reader.Read())
                {
                    //Cidades oCidade = new Cidades();
                    cidades.Codigo = Convert.ToInt32(reader["id"]);
                    cidades.Cidade = reader["cidade"].ToString();
                    cidades.Ddd = reader["ddd"].ToString();

                    Estados estados = new Estados();
                    estados.Codigo = Convert.ToInt32(reader["idestado"]);
                    cidades.OEstado = estados;

                    //lista.Add(oCidade);
                }
                reader.Close();
                return cidades;
            }
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            string mSql = @"SELECT c.*, e.id AS codEstado, e.estado FROM cidades c INNER JOIN estados e ON c.idEstado = e.id WHERE c.cidade LIKE @chave OR e.estado LIKE @chave ORDER BY c.cidade";

            using (SqlConnection conn = new SqlConnection(cnn.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(mSql, conn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Cidades> lista = new List<Cidades>();

                    while (reader.Read())
                    {
                        Cidades oCidade = new Cidades();
                        oCidade.Codigo = Convert.ToInt32(reader["id"]);
                        oCidade.Cidade = reader["cidade"].ToString();

                        Estados oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(reader["codEstado"]);
                        oEstado.Estado = reader["estado"].ToString();

                        oCidade.OEstado = oEstado;

                        lista.Add(oCidade);
                    }

                    reader.Close();
                    return lista;
                }
            }
        }
    }
}
