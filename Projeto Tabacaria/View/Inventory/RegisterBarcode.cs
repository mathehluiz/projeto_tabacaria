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
    public partial class RegisterBarcode : Form
    {
        DBConnections dbConnections = new();
        public RegisterBarcode(string nameProduct, string nameBrand)
        {
            InitializeComponent();
            lblSendBrandProduct.Text = nameBrand;
            lblSendNameProduct.Text = nameProduct;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBarcode_Load(object sender, EventArgs e)
        {
            txtBarcode.Select();
            lblReturnDB.Visible = false;
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
                cmbMarca.Text = lblSendBrandProduct.Text;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
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
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            //obter cod do produto
            MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT prod_cod FROM tb_produtos where prod_nome = '"+cmbSearchProduct.Text+"'", dbConnections.connection);
            var codprod = cmdSelectProdCod.ExecuteScalar();

            //pega a quantidade de códigos de barra
            string quantityProd = "SELECT COUNT(cod_barra) FROM tb_codigo_barra WHERE cod_barra_prod = '"+ codprod + "'";
            MySqlCommand cmdQuantityProd = new MySqlCommand(quantityProd, dbConnections.connection);
            lblQuantityBarcode.Text = "Existem " + Convert.ToString(cmdQuantityProd.ExecuteScalar()) + " códigos de barra deste produto";


            dbConnections.CloseConnection();
            cmbSearchProduct.Text = lblSendNameProduct.Text;
        }

        private void btnRegBarcode_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string consultBarCode = "SELECT cod_barra_prod FROM tb_codigo_barra WHERE cod_barra = '" + txtBarcode.Text + "'";
            MySqlCommand cmdConsultBarcode = new MySqlCommand(consultBarCode, dbConnections.connection);
            var consult = cmdConsultBarcode.ExecuteScalar();
            if (consult == null)
            {
                try
                {
                    dbConnections.OpenConnection();
                    //selecionar cod do produto
                    MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT prod_cod FROM tb_produtos where prod_nome = '" + cmbSearchProduct.Text + "'", dbConnections.connection);
                    var codprod = cmdSelectProdCod.ExecuteScalar();

                    //registrar codigo de barra
                    MySqlCommand cmdRegisterBarcode = new MySqlCommand("insert into tb_codigo_barra (cod_barra,cod_barra_prod) values (@BarCode,@Cod_prod)", dbConnections.connection);
                    cmdRegisterBarcode.Parameters.Add("@BarCode", MySqlDbType.VarChar, 20).Value = txtBarcode.Text;
                    cmdRegisterBarcode.Parameters.Add("@Cod_prod", MySqlDbType.Int32, 10).Value = codprod;
                    cmdRegisterBarcode.ExecuteNonQuery();


                    //pega a quantidade de códigos de barra
                    string quantityProd = "SELECT COUNT(cod_barra) FROM tb_codigo_barra WHERE cod_barra_prod = '" + codprod + "'";
                    MySqlCommand cmdQuantityProd = new MySqlCommand(quantityProd, dbConnections.connection);
                    lblQuantityBarcode.Text = "Existem " + Convert.ToString(cmdQuantityProd.ExecuteScalar()) + " códigos de barra deste produto";

                    dbConnections.CloseConnection();
                    txtBarcode.Clear();
                    txtBarcode.Select();
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Código registrado";
                }
                catch
                {

                }

            }
            else
            {
                string consultProduct = "select prod_nome from tb_produtos where prod_cod = '"+ consult + "'";
                MySqlCommand nameProduct = new MySqlCommand(consultProduct,dbConnections.connection);
                var name = nameProduct.ExecuteScalar();
                MessageBox.Show("O produto ['"+name+"] está registrado com esse código");
                dbConnections.CloseConnection();
            }
            
            

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegBarcode_Click(sender, e);   
            }
        }

        private void cmbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            //selecionar cod do produto
            MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT prod_cod FROM tb_produtos where prod_nome = '" + cmbSearchProduct.Text + "'", dbConnections.connection);
            var codprod = cmdSelectProdCod.ExecuteScalar();
            //pega a quantidade de códigos de barra
            string quantityProd = "SELECT COUNT(cod_barra) FROM tb_codigo_barra WHERE cod_barra_prod = '" + codprod + "'";
            MySqlCommand cmdQuantityProd = new MySqlCommand(quantityProd, dbConnections.connection);
            lblQuantityBarcode.Text = "Existem " + Convert.ToString(cmdQuantityProd.ExecuteScalar()) + " códigos de barra deste produto";

            dbConnections.CloseConnection();
        }
    }
}
