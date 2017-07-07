﻿using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class AutorDao
    {
        public Autor Inserir(Autor autor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "insert into autor(aut_nome) values (@aut_nome)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@aut_nome", autor.aut_nome);
                cn.Open();
                cmd.ExecuteNonQuery();
                return autor;
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
        public Autor Alterar(Autor autor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringConexao());
            try
            {
                string sql = "update autor set aut_nome = @aut_nome where aut_id = @aut_id";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@aut_id", autor.aut_id);
                cmd.Parameters.AddWithValue("@aut_nome", autor.aut_nome);
                cn.Open();
                cmd.ExecuteNonQuery();
                return autor;
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
        public void Excluir(int codigo)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
