
using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System.Data;

namespace Projeto_Tabacaria.Validations
{
    public class ValidateQuantity
    {
        DBConnections dbConnections = new();

        public bool CanUse(int qtd, int cod)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string strQuery = "Select estoque_quantidade from tb_estoque where estoque_cod = '" + cod + "'";
            MySqlCommand cmdGetQtd = new MySqlCommand(strQuery, dbConnections.connection);
            int qtdReturned = Convert.ToInt32(cmdGetQtd.ExecuteScalar());
            if (qtdReturned >= qtd)
            {
                return true;
            }
            else
            {
            return false;
            }
        }
        public int CalculateCurrentQuantity(int qtd, int cod)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string strQuery = "Select estoque_quantidade from tb_estoque where estoque_cod = '" + cod + "'";
            MySqlCommand cmdGetQtd = new MySqlCommand(strQuery, dbConnections.connection);
            int qtdReturned = Convert.ToInt32(cmdGetQtd.ExecuteScalar());
            int calculatedQtt = qtdReturned - qtd;
            return calculatedQtt;
        }

        public int AddQuantity(int qtd, int cod)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string strQuery = "Select estoque_quantidade from tb_estoque where estoque_cod = '" + cod + "'";
            MySqlCommand cmdGetQtd = new MySqlCommand(strQuery, dbConnections.connection);
            int qtdReturned = Convert.ToInt32(cmdGetQtd.ExecuteScalar());
            int calculatedQtt = qtdReturned + qtd;
            return calculatedQtt;
        }
    }
    
}
