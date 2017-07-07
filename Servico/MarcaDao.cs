using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Servico
{
    public class MarcaDao
    {
        public Marca Inserir(Marca marca)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "insert into marca(mar_descricao) values(@mar_descricao)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mar_descricao", marca.mar_descricao);
                cn.Open();
                cmd.ExecuteNonQuery();
                return marca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        public Marca Alterar(Marca marca)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "update marca set mar_descricao = @mar_descricao where mar_id = @mar_id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mar_id", marca.mar_id);
                cmd.Parameters.AddWithValue("@mar_descricao", marca.mar_descricao);
                cn.Open();
                cmd.ExecuteNonQuery();
                return marca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int Codigo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "delete from marca where mar_id = @mar_id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mar_id", Codigo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Marca> ListarTodas()
        {
            SqlConnection con = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "select * from marca";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                List<Marca> resultados = new List<Marca>();
                while (dados.Read())
                {
                    Marca marca = new Marca();
                    marca.mar_id = Convert.ToInt32(dados[0].ToString());
                    marca.mar_descricao = dados[1].ToString();
                    resultados.Add(marca);
                }
                return resultados;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public Marca BuscarId(int codigo)
        {
            SqlConnection con = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "select * from marca where mar_id = @mar_id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mar_id", codigo);
                con.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                Marca marca = new Marca();
                while (dados.Read())
                {
                    marca.mar_id = Convert.ToInt32(dados[0].ToString());
                    marca.mar_descricao = dados[1].ToString();
                }
                return marca;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }        
    }
}
