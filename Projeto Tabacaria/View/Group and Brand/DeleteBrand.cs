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
    public partial class DeleteBrand : Form
    {
        DBConnections dbConnections = new();
        int contador = 0;
        public DeleteBrand()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bntDeleteBrand_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            try
            {
                string deleteBrand = "DELETE FROM tb_marca where marca_nome = '" + cmbBrands.Text + "'";
                MySqlCommand cmdDeleteClient = new MySqlCommand(deleteBrand, dbConnections.connection);
                cmdDeleteClient.CommandType = CommandType.Text;
                cmdDeleteClient.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Marca deletada";
                refreshBrand.Enabled = true;
                this.Refresh();

            }
            catch
            {
                MessageBox.Show("Há produtos registrados com essa marca");
            }
        }

        private void DeleteBrand_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }


            try
            {
                DataTable dt = new DataTable();
                string searchBrand = "SELECT marca_nome FROM tb_marca";
                MySqlDataAdapter adapterSearchBrand = new MySqlDataAdapter(searchBrand, dbConnections.connection);
                DataSet datasetSearchBrand = new DataSet();
                adapterSearchBrand.Fill(datasetSearchBrand, "tb_marca");
                this.cmbBrands.DisplayMember = "marca_nome";
                this.cmbBrands.ValueMember = "marca_cod";
                this.cmbBrands.DataSource = datasetSearchBrand.Tables["tb_marca"];
                cmbBrands.Text = "Selecione uma marca";

                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
        }

        private void refreshBrand_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                contador = 0;
                refreshBrand.Enabled = false;
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string queryClient = "select marca_nome from tb_marca";
                MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_marca");
                this.cmbBrands.DisplayMember = "marca_nome";
                this.cmbBrands.ValueMember = "marca_cod";
                this.cmbBrands.DataSource = ds.Tables["tb_marca"];
                dbConnections.CloseConnection();

                cmbBrands.Text = "Selecione uma marca";
            }
        }
    }
}
