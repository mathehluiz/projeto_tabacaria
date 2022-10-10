
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using Projeto_Tabacaria.DB;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class EditProduct : Form
    {
        DBConnections dbConnections = new();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public EditProduct()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            dbConnections.OpenConnection();

            try
            {
                string query_marca = "select marca_nome from tb_marca";
                MySqlDataAdapter da = new MySqlDataAdapter(query_marca, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_marca");
                this.cmbMarca.DisplayMember = "MARCA_NOME";
                this.cmbMarca.ValueMember = "MARCA_COD";
                this.cmbMarca.DataSource = ds.Tables["tb_marca"];

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();


        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string query_marca_cod = "SELECT marca_cod from tb_marca where marca_nome = '" + cmbMarca.Text + "'";
            MySqlCommand cmd_GetBrand = new MySqlCommand(query_marca_cod, dbConnections.connection);
            var brandQueryResult = Convert.ToInt32(cmd_GetBrand.ExecuteScalar());

            string query_marca_prod = "SELECT prod_nome from tb_produtos where prod_id_marca= '" + brandQueryResult + "'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query_marca_prod, dbConnections.connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_produtos");
            this.cmbSearchProduct.DisplayMember = "prod_nome";
            this.cmbSearchProduct.ValueMember = "prod_cod";
            this.cmbSearchProduct.DataSource = ds1.Tables["tb_produtos"];
            dbConnections.CloseConnection();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                MySqlCommand cmd_table_products = new MySqlCommand("SELECT prod_nome,prod_unidade,prod_ativo,estoque_quantidade,preco_unit_compra,preco_unit_venda,preco_total_gasto FROM tb_estoque,tb_produtos,tb_precos WHERE estoque_cod = prod_cod AND id_produto = prod_cod and prod_nome = '"+cmbSearchProduct.Text+ "'", dbConnections.connection);

                
                MySqlDataReader reader_Products;
                reader_Products = cmd_table_products.ExecuteReader();
                reader_Products.Read();
                txtProdName.Texts = reader_Products.GetString(0);
                cmbUnidade_De_Medida.Text = reader_Products.GetString(1);
                cmbActiveProd.Text= reader_Products.GetString(2);
                txtQtd.Texts = reader_Products.GetString(3);
                txtBuyValue.Texts = reader_Products.GetString(4);
                txtSaleValue.Texts = reader_Products.GetString(5);
                txtTotalSpent.Texts = reader_Products.GetString(6);

                txtProdName.Enabled = true;
                cmbUnidade_De_Medida.Enabled = true;
                cmbActiveProd.Enabled = true;
                txtQtd.Enabled = true;
                txtBuyValue.Enabled = true;
                txtSaleValue.Enabled = true;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }
            

            dbConnections.CloseConnection();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            dbConnections.OpenConnection();
        }
    }
}
