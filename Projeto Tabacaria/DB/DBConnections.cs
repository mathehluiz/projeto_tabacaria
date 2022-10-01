using Microsoft.VisualBasic.ApplicationServices;
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

            strSQL = "INSERT INTO tb_user(Username, Password, Nome, Descricao) VALUES (@username, @password, @nome, @descricao";
        }

        public string testes()
        {
            try
            {
                testDB1.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(strSQL, conn);
                //cmd.connection = conn;
                //string connectionString = "server=192.168.1.104;port=3306;database=schema_tabacaria;uid=tabacaria;pwd=Vi@r.1851;";
                //conn = new MySqlConnection(connectionString);
                //cmd.ExecuteReader();
                //cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@nome", Password);
                cmd.Parameters.AddWithValue("@descricao", Password);


                cmd.ExecuteNonQuery();
                return "teste funcionou";
            }
            catch (Exception e)
            {
                return $"teste n funfo {e}";

            }
            
        }
       
           

                
        }
    }