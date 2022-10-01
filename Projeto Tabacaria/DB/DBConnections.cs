using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.DB
{
    public class DBConnections
    {

        public MySqlConnection? conn;

        testDB testDB1 = new testDB();
        private string strSQL;
        private string? Username { get; set; }
        private string? Password { get; set; }

        public DBConnections(string? username, string? password)
        {
            Username = username;
            Password = password;

            strSQL = "server = 192.168.1.104; port = 3306; database = schema_tabacaria; uid = tabacaria; pwd = Vi@r.1851";
        }

        public string testes()
        {
            MySqlConnection conn = new MySqlConnection(strSQL);
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_user WHERE User=@user and Password=@password", conn);  
                return "teste funcionou";
            }
            catch (Exception e)
            {
                return $"teste n funfo {e}";
            }
            
        }  
    }
}