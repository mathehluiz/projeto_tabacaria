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

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class DeleteGroup : Form
    {
        DBConnections dbConnections = new();
        int contador = 0;
        public DeleteGroup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DeleteGroup_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }


            try
            {
                DataTable dt = new DataTable();
                string searchClient = "SELECT grupo_nome FROM tb_grupos";
                MySqlDataAdapter adapterSearchClient = new MySqlDataAdapter(searchClient, dbConnections.connection);
                DataSet datasetSearchClient = new DataSet();
                adapterSearchClient.Fill(datasetSearchClient, "tb_grupos");
                this.cmbGroups.DisplayMember = "grupo_nome";
                this.cmbGroups.ValueMember = "grupo_id";
                this.cmbGroups.DataSource = datasetSearchClient.Tables["tb_grupos"];
                cmbGroups.Text = "Selecione um grupo";

                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
        }

        private void bntDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            try
            {
                string deletClient = "DELETE FROM tb_grupos where grupo_nome = '" + cmbGroups.Text + "'";
                MySqlCommand cmdDeleteClient = new MySqlCommand(deletClient, dbConnections.connection);
                cmdDeleteClient.CommandType = CommandType.Text;
                cmdDeleteClient.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Grupo deletado";
                refreshDeleteGroup.Enabled = true;
                this.Refresh();

            }
            catch
            {
                MessageBox.Show("Há produtos registrados em estoque com este grupo" );
            }
        }

        private void refreshDeleteGroup_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                contador = 0;
                refreshDeleteGroup.Enabled = false;
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string queryClient = "select cli_nome from tb_clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_grupos");
                this.cmbGroups.DisplayMember = "grupo_nome";
                this.cmbGroups.ValueMember = "grupo_id";
                this.cmbGroups.DataSource = ds.Tables["tb_grupos"];
                dbConnections.CloseConnection();

                cmbGroups.Text = "Selecione o grupo";
            }
        }
    }
}
