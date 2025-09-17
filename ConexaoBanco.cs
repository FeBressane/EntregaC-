using MySql.Data.MySqlClient;

namespace CadastroAlunos
{
    public static class ConexaoBanco
    {
        // Ajuste conforme seu ambiente:
        private const string Servidor = "localhost";
        private const string BancoDados = "dbAluno";
        private const string Usuario = "root";
        private const string Senha = "Belinha.2017";

        // Deixe público para ser acessado pelas outras classes
        public static string BancoServidor =>
            $"Server={Servidor};Database={BancoDados};Uid={Usuario};Pwd={Senha};SslMode=none;";

        public static MySqlConnection ObterConexao() => new MySqlConnection(BancoServidor);
    }
}
