using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System.Data;


namespace Projeto_Tabacaria.View.Inventory
{
    public partial class DeleteProduct : Form
    {
        
        DBConnections dbConnections = new();
        public DeleteProduct(string nameProduct, string nameBrand, string nameGroup)
        {
            InitializeComponent();
            lblSendGroupName.Text = nameGroup;
            lblSendBrandProduct.Text = nameBrand;
            lblSendNameProduct.Text = nameProduct;
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            lblSendNameProduct.Visible = false;
            lblSendGroupName.Visible = false;
            lblSendBrandProduct.Visible = false;
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            

            try
            {
                DataTable dt = new DataTable();
                string cmd_search_brand_group = "SELECT grupo_nome FROM tb_grupos";
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd_search_brand_group, dbConnections.connection);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tb_grupos");
                this.cmbGroup.DisplayMember = "grupo_nome";
                this.cmbGroup.ValueMember = "grupo_id";
                this.cmbGroup.DataSource = ds1.Tables["tb_grupos"];
                cmbGroup.Text = lblSendGroupName.Text;
                dbConnections.CloseConnection();


                dbConnections.OpenConnection();
                MySqlCommand cmd_search_brand_groupname = new MySqlCommand("SELECT grupo_id FROM tb_grupos WHERE grupo_nome = '" + cmbGroup.Text + "'", dbConnections.connection);
                int GroupQueryResult = Convert.ToInt32(cmd_search_brand_groupname.ExecuteScalar());
                string query_brand_group = "SELECT marca_nome, marca_cod FROM tb_marca WHERE id_grupo_marca = '" + GroupQueryResult + "'";
                var cmd = dbConnections.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query_brand_group;
                cmd.ExecuteNonQuery();          

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
                da2.Fill(dt);

                if (cmbBrand.Items.Count > 0)
                {
                    cmbBrand.SelectedIndex = 0;
                    cmbBrand.Items.Clear();
                }
                foreach (DataRow dr in dt.Rows)
                {
                    cmbBrand.Items.Add(dr["marca_nome"].ToString());
                    cmbBrand.Text = cmbBrand.Items[0].ToString();

                }


                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
   
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string query_marca_cod = "SELECT marca_cod from tb_marca where marca_nome = '" + cmbBrand.Text + "'";
            MySqlCommand cmd_GetBrand = new MySqlCommand(query_marca_cod, dbConnections.connection);
            var brandQueryResult = Convert.ToInt32(cmd_GetBrand.ExecuteScalar());

            string query_marca_prod = "SELECT prod_nome from tb_produtos where prod_id_marca= '" + brandQueryResult + "'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query_marca_prod, dbConnections.connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_produtos");
            this.cmbProductName.DisplayMember = "prod_nome";
            this.cmbProductName.ValueMember = "prod_cod";
            this.cmbProductName.DataSource = ds1.Tables["tb_produtos"];
            dbConnections.CloseConnection();

            cmbProductName.Text = lblSendNameProduct.Text;
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            DataTable dt = new DataTable();

            try
            {
               
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                MySqlCommand cmd_search_brand_groupname1 = new MySqlCommand("SELECT grupo_id FROM tb_grupos WHERE grupo_nome = '" + cmbGroup.Text + "'", dbConnections.connection);
                int GroupQueryResult = Convert.ToInt32(cmd_search_brand_groupname1.ExecuteScalar());
                string query_brand_group = "SELECT marca_nome, marca_cod FROM tb_marca WHERE id_grupo_marca = '" + GroupQueryResult + "'";
                var cmd = dbConnections.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query_brand_group;
                cmd.ExecuteNonQuery();
                cmbBrand.Text = lblSendBrandProduct.Text;

                if (cmbBrand.Items.Count > 0)
                {
                    dt.Rows.Clear();
                    cmbBrand.Items.Clear();
                }
                

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
                da2.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbBrand.Items.Add(dr["marca_nome"].ToString());
                    
                }
                cmbBrand.SelectedIndex = 0;


                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            try
            {
                MySqlCommand cmd_delete_product = new MySqlCommand("DELETE FROM tb_produtos WHERE prod_nome = '" + cmbProductName.Text + "'",dbConnections.connection);
                cmd_delete_product.CommandType = CommandType.Text;
                cmd_delete_product.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Produto deletado";
                this.Refresh();
                
            }
            catch
            {
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Erro";
            }
            
           
            

        }
    }
}
