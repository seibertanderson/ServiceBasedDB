namespace Servico
{
    public class Conexao
    {
        public static string StringConexao()
        {
            //caminho do arquivo do banco
            string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anderson.seibert\documents\visual studio 2015\Projects\ServiceBasedDBExample\Dados\DB.mdf;Integrated Security=True";
            return conexao;
        }
    }
}
