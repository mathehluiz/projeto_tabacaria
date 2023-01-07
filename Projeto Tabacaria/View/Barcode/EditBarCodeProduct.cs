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

namespace Projeto_Tabacaria.View.Barcode
{
    public partial class EditBarCodeProduct : Form
    {
        DBConnections dbConnections = new();
        public EditBarCodeProduct(string nameProduct, string numberBarCode)
        {
            InitializeComponent();
            lblSendBarCodeProduct.Text = numberBarCode;
            lblSendNameProduct.Text = nameProduct;
            
        }

        private void EditBarCodeProduct_Load(object sender, EventArgs e)
        {
            lblSendBarCodeProduct.Visible = false;
            lblSendNameProduct.Visible = false;
            txtNameProduct.Text=lblSendNameProduct.Text;
            txtCodeBarProduct.Text = lblSendBarCodeProduct.Text;
            txtNameProduct.ReadOnly = true;
            txtCodeBarProduct.ReadOnly= true;
            lblReturnDB.Visible = false;



        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                string selectCodProd = "select prod_cod from tb_produtos where prod_nome = '" + txtNameProduct.Text + "'";
                MySqlCommand cmdselectCodProd = new MySqlCommand(selectCodProd, dbConnections.connection);
                var codProd = cmdselectCodProd.ExecuteScalar();


                string updateBarcodeProduct = "update tb_codigo_barra set cod_barra = '" + txtNewBarcode.Text + "' where cod_barra_prod = '" + codProd + "'";
                MySqlCommand cmdupdateBarcodeProduct = new MySqlCommand(updateBarcodeProduct, dbConnections.connection);
                cmdupdateBarcodeProduct.ExecuteNonQuery();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Código alterado";
                txtNewBarcode.Text = "";
                txtNewBarcode.Focus();
                txtNewBarcode.Select();

            }
            catch
            {
                MessageBox.Show("Erro");
                txtNewBarcode.Text = "";
                txtNewBarcode.Focus();
                txtNewBarcode.Select();
            }

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEditProduct_Click(sender, e);
            }

        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
