using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.DB
{
    public class DBConnections
    {
        public MySqlConnection connection = new MySqlConnection("server = 192.168.1.104; port = 3306; database = schema_tabacaria; uid = tabacaria; pwd = Vi@r.1851");

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

    }
}