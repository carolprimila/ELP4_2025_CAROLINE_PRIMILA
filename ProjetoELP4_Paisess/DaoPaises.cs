using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4_Paisess
{
    internal class DaoPaises : DAO<Paises>
    {
        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "DELETE FROM paises WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", oPais.Codigo);
                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                    return "País excluído com sucesso!";
                else
                    return "Nenhum registro encontrado para excluir.";
            }
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";
            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(Pais, Sigla, DDI, Moeda, DatCad, UltAlt) values(@pais, @sigla, @ddi, @moeda, @datcad, @ultalt)";
            }
            else
            {
                mSql = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda, datcad = @datcad, ultalt = @ultalt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@Sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@DDI", oPais.Ddi);
                cmd.Parameters.AddWithValue("@Moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datcad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oPais.UltAlt);
                cmd.Parameters.AddWithValue("@Codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override List<Paises> Listar()
        {
            string mSql = "select * from paises order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Paises> lista = new List<Paises>();
                while (reader.Read())
                {
                    Paises oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Pais"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                    lista.Add(oPais);
                }
                reader.Close();
                return lista;
            }
        }
        public override Object CarregaObj(int chave)
        {
            string mSql = "select * from paises where id = 'chave'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                Paises pais = new Paises();
                while (reader.Read())
                {
                    //Paises oPais = new Paises();
                    pais.Codigo = Convert.ToInt32(reader["id"]);
                    pais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    pais.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    pais.Pais = reader["Pais"].ToString();
                    pais.Sigla = reader["Sigla"].ToString();
                    pais.Ddi = reader["DDI"].ToString();
                    pais.Moeda = reader["Moeda"].ToString();
                    //lista.Add(oPais);
                }
                reader.Close();
                return pais;
            }
        }
        public override List<Paises> Pesquisar(string chave)
        {
            string mSql = @"SELECT * FROM paises WHERE pais LIKE @chave OR sigla LIKE @chave OR ddi LIKE @chave OR moeda LIKE @chave ORDER BY pais";

            using (SqlConnection conn = new SqlConnection(cnn.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(mSql, conn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Paises> lista = new List<Paises>();

                    while (reader.Read())
                    {
                        Paises oPais = new Paises();
                        oPais.Codigo = Convert.ToInt32(reader["id"]);
                        oPais.Pais = reader["pais"].ToString();
                        oPais.Sigla = reader["sigla"].ToString();
                        oPais.Ddi = reader["ddi"].ToString();
                        oPais.Moeda = reader["moeda"].ToString();

                        lista.Add(oPais);
                    }

                    reader.Close();
                    return lista;
                }
            }
        }
    }
}
