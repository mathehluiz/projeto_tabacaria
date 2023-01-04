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
    public partial class RegisterBarcodeCup : Form
    {
        DBConnections dbConnections = new();
        public RegisterBarcodeCup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegisterBarcodeCup_Load(object sender, EventArgs e)
        {
            txtBarcode.Select();
            lblReturnDB.Visible = false;
            dbConnections.OpenConnection();
            try
            {
                string selectGarrafa = "select prod_nome from tb_unidade";
                MySqlDataAdapter da = new MySqlDataAdapter(selectGarrafa, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_unidade");
                this.cmbGarrafa.DisplayMember = "prod_nome";
                this.cmbGarrafa.ValueMember = "cod_unidade";
                this.cmbGarrafa.DataSource = ds.Tables["tb_unidade"];
                //cmbGarrafa.Text = lblSendBrandProduct.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
        }

        private void cmbGarrafa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            //Seleciona o código do copo
            string selectCodCup = "SELECT cod_unidade from tb_unidade where prod_nome = '" + cmbGarrafa.Text + "'";
            MySqlCommand cmd_GetCodCupp= new MySqlCommand(selectCodCup, dbConnections.connection);
            var CodCup = Convert.ToInt32(cmd_GetCodCupp.ExecuteScalar());

            
            //Seleciona o produto pelo código da marca.
            string selectProdNome = "SELECT unidade_nome from tb_unidade where prod_nome= '" + cmbGarrafa.Text + "'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(selectProdNome, dbConnections.connection);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_unidade");
            this.cmbCopo.DisplayMember = "unidade_nome";
            this.cmbCopo.ValueMember = "cod_unidade";
            this.cmbCopo.DataSource = ds1.Tables["tb_unidade"];
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }


            //obter cod do produto
            MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT cod_unidade FROM tb_unidade where prod_nome = '" + cmbGarrafa.Text + "'", dbConnections.connection);
            var codprod = cmdSelectProdCod.ExecuteScalar();

            //pega a quantidade de códigos de barra
            string quantityProd = "SELECT COUNT(cod_barra) FROM tb_codigo_barra WHERE cod_barra_copo = '" + codprod + "'";
            MySqlCommand cmdQuantityProd = new MySqlCommand(quantityProd, dbConnections.connection);
            lblQuantityBarcode.Text = "Existem " + Convert.ToString(cmdQuantityProd.ExecuteScalar()) + " códigos de barra deste produto";


            dbConnections.CloseConnection();
            //cmbSearchProduct.Text = lblSendNameProduct.Text;
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

                    //selecionar cod da garrafa
                    MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT cod_unidade FROM tb_unidade where prod_nome = '" + cmbGarrafa.Text + "'", dbConnections.connection);
                    var codprod = cmdSelectProdCod.ExecuteScalar();

                    //registrar codigo de barra
                    MySqlCommand cmdRegisterBarcode = new MySqlCommand("insert into tb_codigo_barra (cod_barra,cod_barra_copo) values (@BarCode,@Cod_prod)", dbConnections.connection);
                    cmdRegisterBarcode.Parameters.Add("@BarCode", MySqlDbType.VarChar, 20).Value = txtBarcode.Text;
                    cmdRegisterBarcode.Parameters.Add("@Cod_prod", MySqlDbType.Int32, 10).Value = codprod;
                    cmdRegisterBarcode.ExecuteNonQuery();


                    //pega a quantidade de códigos de barra
                    string quantityProd = "SELECT COUNT(cod_barra) FROM tb_codigo_barra WHERE cod_barra_copo = '" + codprod + "'";
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
                    MessageBox.Show("Erro ao registrar produto.");

                }

            }
            else
            {
                string consultProduct = "select unidade_nome from tb_unidade where prod_nome = '" + cmbGarrafa.Text + "'";
                MySqlCommand nameProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                var name = nameProduct.ExecuteScalar();
                MessageBox.Show("O produto ['" + name + "] está registrado com esse código");
                dbConnections.CloseConnection();
            }

        }
    }
}
