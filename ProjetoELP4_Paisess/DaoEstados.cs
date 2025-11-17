using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class DaoEstados : DAO<Estados>
    {
        public override string Excluir(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "DELETE FROM estados WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", oEstado.Codigo);
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                    return "Estado excluído com sucesso!";
                else
                    return "Nenhum estado encontrado para excluir.";
            }
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
        public override List<Estados> Listar()
        {
            string mSql = "select * from estados order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();

                while (reader.Read())
                {
                    Estados oEstado = new Estados();
                    oEstado.Codigo = Convert.ToInt32(reader["id"]);
                    oEstado.Estado = reader["estado"].ToString();
                    oEstado.Uf = reader["uf"].ToString();

                    Paises oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["idpais"]);
                    oEstado.OPais = oPais;

                    lista.Add(oEstado);
                }

                reader.Close();
                return lista;
            }
        }
        public override object CarregaObj(int chave)
        {
            string mSql = "select * from estados where id = @id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", chave);

                SqlDataReader reader = cmd.ExecuteReader();
                Estados estado = null;

                if (reader.Read())
                {
                    estado = new Estados();
                    estado.Codigo = Convert.ToInt32(reader["id"]);
                    estado.Estado = reader["estado"].ToString();
                    estado.Uf = reader["uf"].ToString();

                    Paises pais = new Paises();
                    pais.Codigo = Convert.ToInt32(reader["idpais"]);
                    estado.OPais = pais;
                }

                reader.Close();
                return estado;
            }
        }
        public override List<Estados> Pesquisar(string chave)
        {
            string mSql = @"SELECT e.*, p.pais 
                    FROM estados e 
                    INNER JOIN paises p ON e.idpais = p.id 
                    ORDER BY e.id";

            using (SqlConnection conn = new SqlConnection(cnn.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(mSql, conn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Estados> lista = new List<Estados>();

                    while (reader.Read())
                    {
                        Estados oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(reader["id"]);
                        oEstado.Estado = reader["estado"].ToString();
                        oEstado.Uf = reader["uf"].ToString();

                        Paises oPais = new Paises();
                        oPais.Codigo = Convert.ToInt32(reader["idpais"]);
                        oPais.Pais = reader["pais"].ToString();

                        oEstado.OPais = oPais;

                        lista.Add(oEstado);
                    }

                    reader.Close();
                    return lista;
                }
            }
        }
    }
}
