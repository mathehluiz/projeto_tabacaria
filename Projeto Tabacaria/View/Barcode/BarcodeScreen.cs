using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using Projeto_Tabacaria.View.Inventory;
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
    public partial class BarcodeScreen : Form
    {
        DBConnections dbConnections = new();
        public BarcodeScreen()
        {
            InitializeComponent();
        }

        private void btnRegBarcode_Click(object sender, EventArgs e)
        {
            RegisterBarcode registerBarcode = new RegisterBarcode();
            registerBarcode.Show();
        }

        private void btnRegBarcodeCup_Click(object sender, EventArgs e)
        {
            RegisterBarcodeCup registerBarcodeCup = new RegisterBarcodeCup();
            registerBarcodeCup.Show();
        }

        private void BarcodeScreen_Load(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadBarCodeProducts = "Select tb_produtos.prod_nome,tb_codigo_barra.cod_barra FROM tb_produtos " +
                "INNER JOIN tb_codigo_barra ON tb_codigo_barra.cod_barra_prod = tb_produtos.prod_cod ";

            MySqlDataAdapter daLoadBarCode = new MySqlDataAdapter(loadBarCodeProducts, dbConnections.connection);
            DataTable dtLoadBarCode = new DataTable();
            daLoadBarCode.Fill(dtLoadBarCode);
            dgvBarCodeProducts.DataSource = dtLoadBarCode;
            dgvBarCodeProducts.Columns["prod_nome"].HeaderText = "Produto";
            dgvBarCodeProducts.Columns["cod_barra"].HeaderText = "Código";

            string loadBarCodeCups = "Select tb_unidade.unidade_nome,tb_codigo_barra.cod_barra FROM tb_unidade " +
                "INNER JOIN tb_codigo_barra ON tb_codigo_barra.cod_barra_copo = tb_unidade.cod_unidade";

            MySqlDataAdapter daLoadBarCodeCup = new MySqlDataAdapter(loadBarCodeCups, dbConnections.connection);
            DataTable dtLoadBarCodeCup = new DataTable();
            daLoadBarCodeCup.Fill(dtLoadBarCodeCup);
            dgvBarCodeCups.DataSource = dtLoadBarCodeCup;
            dgvBarCodeCups.Columns["unidade_nome"].HeaderText = "Copo";
            dgvBarCodeCups.Columns["cod_barra"].HeaderText = "Código";

            dbConnections.CloseConnection();
        }

        private void dgvBarCodeProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarCodeProducts.Columns[e.ColumnIndex] == dgvBarCodeProducts.Columns["editar"])
            {
                string nameProd = dgvBarCodeProducts.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                string numberBarCode = dgvBarCodeProducts.Rows[e.RowIndex].Cells["cod_barra"].Value.ToString();
                //lblSendNameProduct.Text = nameProd;
                //lblSendBrandProduct.Text = nameBrand;

                //abrir o menu para editar barcode

                //EditProduct editProduct = new EditProduct(nameProd, numberBarCode);
                //editProduct.Show();

            }
            if (dgvBarCodeProducts.Columns[e.ColumnIndex] == dgvBarCodeProducts.Columns["excluir"])
            {

                string nameProd = dgvBarCodeProducts.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                //string nameBrand = dgvProducts.Rows[e.RowIndex].Cells["marca_nome"].Value.ToString();
                string selectGroupName = "SELECT grupo_nome from tb_grupos,tb_produtos WHERE prod_nome = '" + nameProd + "' AND prod_id_grupo = grupo_id";
                dbConnections.OpenConnection();

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                try
                {
                    MySqlCommand cmd_delete_product = new MySqlCommand("DELETE FROM tb_produtos WHERE prod_nome = '" + nameProd + "'", dbConnections.connection);
                    cmd_delete_product.CommandType = CommandType.Text;
                    cmd_delete_product.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    //timer1_Tick(sender, e);

                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void dgvBarCodeProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvBarCodeProducts.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvBarCodeProducts.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }
    }
}
