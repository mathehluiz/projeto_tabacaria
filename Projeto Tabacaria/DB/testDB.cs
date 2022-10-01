using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.DB
{
    internal class testDB
    {
        public static MySqlConnection? conn;
        public void OpenConnection()
        {
            string connectionString = "server=192.168.1.104;port=3306;database=schema_tabacaria;uid=tabacaria;pwd=Vi@r.1851;";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
    }
}
