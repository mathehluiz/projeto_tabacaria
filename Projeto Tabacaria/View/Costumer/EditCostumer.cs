using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tabacaria.View.Client
{
    public partial class EditCostumer : Form
    {
        int contador = 0;
        DBConnections dbConnections = new DBConnections();
        public EditCostumer()
        {
            InitializeComponent();
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            dbConnections.OpenConnection();
            lblReturnDB.Visible = false;

            string queryClient = "select cli_nome from tb_clientes";
            MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_clientes");
            this.cmbSelectClient.DisplayMember = "cli_nome";
            this.cmbSelectClient.ValueMember = "cli_cod";
            this.cmbSelectClient.DataSource = ds.Tables["tb_clientes"];
            dbConnections.CloseConnection();

            cmbSelectClient.Text = "Selecione o cliente";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                string querySelectClient = "select cli_nome,cli_telefone from tb_clientes where cli_nome = '"+cmbSelectClient.Text+"'";
                MySqlCommand selectClient = new  MySqlCommand(querySelectClient, dbConnections.connection);
                MySqlDataReader readerClient;
                readerClient = selectClient.ExecuteReader();
                readerClient.Read();
                txtNameClient.Text = readerClient.GetString(0);
                txtPhoneClient.Text = readerClient.GetString(1);
                dbConnections.CloseConnection();
                
            }
            catch
            {
                MessageBox.Show("Erro");
                dbConnections.CloseConnection();

            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                string querySelectCodClient = "SELECT cli_cod FROM tb_clientes WHERE cli_nome = '"+cmbSelectClient.Text+"'";
                MySqlCommand cmdSelectCod = new MySqlCommand(querySelectCodClient, dbConnections.connection);
                MySqlDataReader reader;
                reader = cmdSelectCod.ExecuteReader();
                reader.Read();
                var cliCod = reader.GetString(0);
                Convert.ToInt32(cliCod);
                dbConnections.CloseConnection();

                dbConnections.OpenConnection();
                string querySaveEdit = "update tb_clientes set cli_nome = '" + txtNameClient.Text + "',cli_telefone = '" + txtPhoneClient.Text +"' where cli_cod = '"+cliCod+"'";
                MySqlCommand cmdSaveEdit = new MySqlCommand(querySaveEdit, dbConnections.connection);
                cmdSaveEdit.ExecuteNonQuery();
                dbConnections.CloseConnection();
                txtNameClient.Text = "";
                txtPhoneClient.Text = "";
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Cliente alterado";
                RefreshCmbClient.Enabled = true;

            }
            catch
            {
                lblReturnDB.Text = "Erro";
            }
            

        }

        private void RefreshCmbClient_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                contador = 0;
                RefreshCmbClient.Enabled = false;
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string queryClient = "select cli_nome from tb_clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_clientes");
                this.cmbSelectClient.DisplayMember = "cli_nome";
                this.cmbSelectClient.ValueMember = "cli_cod";
                this.cmbSelectClient.DataSource = ds.Tables["tb_clientes"];
                dbConnections.CloseConnection();

                cmbSelectClient.Text = "Selecione o cliente";
            }

        }
    }
}
