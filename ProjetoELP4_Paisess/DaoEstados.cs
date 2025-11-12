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
            //Estados oEstado = (Estados)obj;
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
        public override Object CarregaObj(int chave)
        {
            string mSql = "select * from estados where id = 'chave'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Estados estados = new Estados();

                while (reader.Read())
                {
                    Estados oEstado = new Estados();
                    estados.Codigo = Convert.ToInt32(reader["id"]);
                    estados.Estado = reader["estado"].ToString();
                    estados.Uf = reader["uf"].ToString();

                    Paises paises = new Paises();
                    paises.Codigo = Convert.ToInt32(reader["idpais"]);
                    estados.OPais = paises;

                    //lista.Add(oEstado);
                }

                reader.Close();
                return estados;
            }
        }
        public override List<Estados> Pesquisar(string chave)
        {
            string mSql = @"SELECT e.*, p.id AS codPais, p.pais FROM estados e INNER JOIN paises p ON e.idPais = p.id WHERE e.estado LIKE @chave OR e.uf LIKE @chave OR p.pais LIKE @chave ORDER BY e.estado";

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
                        oPais.Codigo = Convert.ToInt32(reader["codPais"]);
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
