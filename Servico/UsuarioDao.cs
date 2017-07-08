using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class UsuarioDao
    {
        public bool Login(string usuario, string senha)
        {
            SqlConnection con = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = @"select * from usuario 
                               where usu_usuario = @usu_usuario
                               and usu_senha = @usu_senha";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usu_usuario", usuario);
                cmd.Parameters.AddWithValue("@usu_senha", senha);
                con.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                Usuario user = new Usuario();                
                while (dados.Read())
                {
                    user.usu_usuario = dados[1].ToString();
                    user.usu_senha = dados[2].ToString();
                }
                if(user.usu_id != 0)
                {
                    return true;
                }else
                {
                    return false;
                }                
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
