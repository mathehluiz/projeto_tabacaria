using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System.Data;

namespace Projeto_Tabacaria.View.Client
{
    public partial class DeleteCostumer : Form
    {
        int contador = 0;
        DBConnections dbConnections = new();
        public DeleteCostumer()
        {
            InitializeComponent();
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteClient_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }


            try
            {
                DataTable dt = new DataTable();
                string searchClient = "SELECT cli_nome FROM tb_clientes";
                MySqlDataAdapter adapterSearchClient = new MySqlDataAdapter(searchClient, dbConnections.connection);
                DataSet datasetSearchClient = new DataSet();
                adapterSearchClient.Fill(datasetSearchClient, "tb_clientes");
                this.cmbSearchClient.DisplayMember = "cli_nome";
                this.cmbSearchClient.ValueMember = "cli_cod";
                this.cmbSearchClient.DataSource = datasetSearchClient.Tables["tb_clientes"];
                cmbSearchClient.Text = "Selecione um cliente";

                dbConnections.CloseConnection();         

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            try
            {
                string deletClient = "DELETE FROM tb_clientes where cli_nome = '" + cmbSearchClient.Text + "'";
                MySqlCommand cmdDeleteClient = new MySqlCommand(deletClient, dbConnections.connection);
                cmdDeleteClient.CommandType = CommandType.Text;
                cmdDeleteClient.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Cliente deletado";
                refreshDeleteClient.Enabled = true;
                this.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void refreshDeleteClient_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                contador = 0;
                refreshDeleteClient.Enabled = false;
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string queryClient = "select cli_nome from tb_clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_clientes");
                this.cmbSearchClient.DisplayMember = "cli_nome";
                this.cmbSearchClient.ValueMember = "cli_cod";
                this.cmbSearchClient.DataSource = ds.Tables["tb_clientes"];
                dbConnections.CloseConnection();

                cmbSearchClient.Text = "Selecione o cliente";
            }
        }

        private void lblReturnDB_Click(object sender, EventArgs e)
        {

        }
    }
}
