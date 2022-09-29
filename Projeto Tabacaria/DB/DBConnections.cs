using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.DB
{
    public class DBConnections
    {
        public MySqlConnection? conn;

        public void OpenConnection()
        {
            string connectionString = "server=191.5.50.157;database=schema_barbearia;uid=tabacaria;pwd=Vi@r.1851;";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        public void CloseConnection()
        {
            string connectionString = "server=191.5.50.157;database=schema_barbearia;uid=tabacaria;pwd=Vi@r.1851;";
            conn = new MySqlConnection(connectionString);
            conn.Close();
        }

        public string SelectUser(string user, string password)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.CommandText = "SELECT USER from schema_tabacaria WHERE user = @user";
                cmd.Parameters.AddWithValue("@nome", user);
                cmd.CommandText = "SELECT PASSWORD from schema_tabacaria WHERE password = @password";
                cmd.Parameters.AddWithValue("@password", password);
                return "Conectado com sucesso";
            }
            catch (Exception e)
            {
                return $"Usuário ou senha inválidos {e}";
            }
        }
    }
}