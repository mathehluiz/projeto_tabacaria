using Projeto_Tabacaria.DB;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria.View
{
    public partial class DashboardForm : Form
    {
        DBConnections dbConnections = new();
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            try
            {
                lblCostumerName.Visible = false;
                lblCostumerValue.Visible = false;

                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;

                string selectCodNoClient = "select cli_cod from tb_clientes where cli_nome = '[A] Sem cliente'";
                MySqlCommand cmdSelectCodNoClient = new MySqlCommand(selectCodNoClient, dbConnections.connection);
                var noClient = Convert.ToInt32(cmdSelectCodNoClient.ExecuteScalar());

                string strQueryTotalSaledToday = "SELECT SUM(venda_valor_total) FROM tb_vendas WHERE DAY(venda_data) = '" + day + "' and MONTH(venda_data)= '" + month + "' and YEAR(venda_data) = '" + year + "' AND id_venda_cliente = '" + noClient + "'";
                MySqlCommand cmd = new MySqlCommand(strQueryTotalSaledToday, dbConnections.connection);
                lblTotalSaleTodayValue.Text = "R$ " + Convert.ToString(cmd.ExecuteScalar());

                string strQueryTotalSaledMonth = "SELECT SUM(venda_valor_total) FROM tb_vendas WHERE MONTH(venda_data)= '" + month + "' and YEAR(venda_data) = '" + year + "' AND id_venda_cliente = '" + noClient + "'";
                MySqlCommand cmdMonth = new MySqlCommand(strQueryTotalSaledMonth, dbConnections.connection);
                lblTotalSaleMonthValue.Text = "R$ " + Convert.ToString(cmdMonth.ExecuteScalar());

                string strQueryTotalSaled = "SELECT SUM(venda_valor_total) FROM tb_vendas where id_venda_cliente = '" + noClient + "'";
                MySqlCommand cmdTotalSaled = new MySqlCommand(strQueryTotalSaled, dbConnections.connection);
                lblTotalSaledValue.Text = "R$ " + Convert.ToString(cmdTotalSaled.ExecuteScalar());

                string strQueryCostumer = "SELECT MAX(cli_total) FROM tb_clientes WHERE cli_nome != '[A] Sem cliente'";
                MySqlCommand cmdCostumer = new MySqlCommand(strQueryCostumer, dbConnections.connection);
                var value = Convert.ToString(cmdCostumer.ExecuteScalar());

                var name = value.Replace(",", ".");
                string strQueryCostumerName = "SELECT cli_nome FROM tb_clientes WHERE cli_total ='" + name + "'";
                MySqlCommand cmdCostumerName = new MySqlCommand(strQueryCostumerName, dbConnections.connection);
                var costumerName = Convert.ToString(cmdCostumerName.ExecuteScalar());

                string strQueryTotalSpun = "SELECT SUM(cli_total) FROM tb_clientes WHERE cli_nome != '[A] Sem cliente'";
                MySqlCommand cmdTotalSpun = new MySqlCommand(strQueryTotalSpun, dbConnections.connection);
                var valueSpun = Convert.ToString(cmdTotalSpun.ExecuteScalar());

                string strQueryBiggestProfit = "SELECT id_produto FROM tb_precos ORDER BY preco_lucro DESC LIMIT 1";
                MySqlCommand cmdBiggestProfit = new MySqlCommand(strQueryBiggestProfit, dbConnections.connection);
                int valueBiggestProfit = Convert.ToInt32(cmdBiggestProfit.ExecuteScalar());

                string strQueryNameBiggProfit = "SELECT prod_nome FROM tb_produtos WHERE prod_cod = '" + valueBiggestProfit + "'";
                MySqlCommand cmdNameBiggestProfit = new MySqlCommand(strQueryNameBiggProfit, dbConnections.connection);
                var nameBiggestProfit = Convert.ToString(cmdNameBiggestProfit.ExecuteScalar());

                string strQueryMinProfit = "SELECT id_produto FROM tb_precos ORDER BY preco_lucro LIMIT 1;";
                MySqlCommand cmdMinProfit = new MySqlCommand(strQueryMinProfit, dbConnections.connection);
                int valueMinProfit = Convert.ToInt32(cmdMinProfit.ExecuteScalar());

                string strQueryNameMinProfit = "SELECT prod_nome FROM tb_produtos WHERE prod_cod = '" + valueMinProfit + "'";
                MySqlCommand cmdNameMinProfit = new MySqlCommand(strQueryNameMinProfit, dbConnections.connection);
                var valueNameMinProfit = Convert.ToString(cmdNameMinProfit.ExecuteScalar());

                string strQueryMaxSale = "SELECT iv_cod_prod FROM tb_itens_vendidos GROUP BY iv_cod_prod ORDER BY sum(iv_quantidade) DESC LIMIT 1;";
                MySqlCommand cmdstrQueryMaxSale = new MySqlCommand(strQueryMaxSale, dbConnections.connection);
                var valuestrQueryMaxSale = Convert.ToString(cmdstrQueryMaxSale.ExecuteScalar());

                string strQueryNameProd = "SELECT prod_nome FROM tb_produtos WHERE prod_cod = '" + valuestrQueryMaxSale + "'";
                MySqlCommand cmdQueryNameProd = new MySqlCommand(strQueryNameProd, dbConnections.connection);
                var valueNameMaxProd = Convert.ToString(cmdQueryNameProd.ExecuteScalar());

                string strQueryMinSale = "SELECT iv_cod_prod FROM tb_itens_vendidos GROUP BY iv_cod_prod ORDER BY sum(iv_quantidade) ASC LIMIT 1;";
                MySqlCommand cmdstrQueryMinSale = new MySqlCommand(strQueryMinSale, dbConnections.connection);
                var valuestrQueryMinSale = Convert.ToString(cmdstrQueryMinSale.ExecuteScalar());

                string strQueryNameProdMin = "SELECT prod_nome FROM tb_produtos WHERE prod_cod = '" + valuestrQueryMinSale + "'";
                MySqlCommand cmdQueryNameProdMin = new MySqlCommand(strQueryNameProdMin, dbConnections.connection);
                var valueNameMinProd = Convert.ToString(cmdQueryNameProdMin.ExecuteScalar());

                lblCostumerName.Visible = true;
                lblCostumerValue.Visible = true;
                lblCostumerName.Text = costumerName;
                lblCostumerValue.Text = "R$ " + value;
                lblTotalSpunValue.Visible = true;
                lblTotalSpunValue.Text = "R$ " + valueSpun;
                lblProdProfit.Text = "Produto com o maior lucro: " + nameBiggestProfit;
                lblProdMinProfit.Text = "Produto com o menor lucro: " + valueNameMinProfit;
                lblMaxSale.Text = "Produto mais vendido: " + valueNameMaxProd;
                lblMinSale.Text = "Produto menos vendido: " + valueNameMinProd;
                dbConnections.CloseConnection();

                if (String.IsNullOrEmpty(lblCostumerName.Text))
                {
                    lblCostumerName.Text = "Nenhum cliente foi adicionado";
                    lblCostumerName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    lblCostumerName.Location = new Point(35, 116);
                }
                else if(lblCostumerName.Text.Length < 15 && lblCostumerName.Text.Length > 7)
                {
                    lblCostumerName.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                    lblCostumerName.Location = new Point(60, 116);
                }
                else if (lblCostumerName.Text.Length > 15)
                {
                    lblCostumerName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    lblCostumerName.Location = new Point(40, 116);
                }


                lblDateTimeToday.Text = "Posição do dia " + day.ToString() + "/" +month.ToString()+ "/" + year.ToString();
                lblDateMonthValue.Text = "Posição do mes " +month.ToString() + "/" + year.ToString();
                lblDateSpunToday.Text = lblDateTimeToday.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                dbConnections.CloseConnection();
            }


        }
    }
}