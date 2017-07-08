namespace Servico
{
    public class Conexao
    {
        public static string StringConexao()
        {
            //caminho do arquivo do banco            
            string caminhoBanco = @"C:\Users\Anderson\Documents\GitHub\ServiceBasedDB\Dados\DB.mdf";
            string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+caminhoBanco+";Integrated Security=True";
            return conexao;
        }
    }
}
