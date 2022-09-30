using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.DB
{
    public class DBConnections
    {
        public MySqlConnection? conn;

        public void OpenConnection()
        {
            string connectionString = "server=191.5.50.157;database=schema_tabacaria;uid=tabacaria;pwd=Vi@r.1851;";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        public void CloseConnection()
        {
            string connectionString = "server=191.5.50.157;database=schema_tabacaria;uid=tabacaria;pwd=Vi@r.1851;";
            conn = new MySqlConnection(connectionString);
            conn.Close();
        }

        public string SelectUser(string user, string password)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandText = "select * from tb_user where Username=@user and Password=@password";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return ("Conectado com sucesso");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return ($"Usuário ou senha inválidos{e}");
            }
        }
    }
}