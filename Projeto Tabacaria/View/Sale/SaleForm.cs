using Projeto_Tabacaria.DB;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using Projeto_Tabacaria.Validations;
using System;


namespace Projeto_Tabacaria.View
{


    public partial class SaleForm : Form
    {
        DBConnections dbConnections = new();
        BuildTotalPrice totalPrice = new();
        ValidateQuantity valQtd = new();

        
        public SaleForm()
        {
            InitializeComponent();

            
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            lblReturnQuantity.Visible = false;
            cmbCostumer.Items.Clear();
            cmbSaleProduct.Items.Clear();
            cmbSaleProduct.Enabled = false;
            txtQtd.Enabled = false;
            txtSubtotal.Enabled = false;
            txtDiscount.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEndSale.Enabled = false;
            picSearchIcon_Sale.Enabled = false;
            btnEndSale.Enabled = false;
            btnCancelSale.Enabled = false;
            dgvProducts.Columns[2].HeaderText = "Valor Unitário";



            dbConnections.OpenConnection();
            string queryClient = "select cli_nome from tb_clientes order by cli_nome";
            MySqlDataAdapter da = new MySqlDataAdapter(queryClient, dbConnections.connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_clientes");
            this.cmbCostumer.DisplayMember = "cli_nome";
            this.cmbCostumer.ValueMember = "cli_cod";
            this.cmbCostumer.DataSource = ds.Tables["tb_clientes"];
            dbConnections.CloseConnection();
            txtSubtotal.Texts = "0";
            txtDiscount.Texts = "0";


        }

        private void picSearchIcon_Sale_Click(object sender, EventArgs e)
        {
            btnDeleteItem.Enabled = true;
            btnEndSale.Enabled = true;
            
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            double parsedValue;
            if (!double.TryParse(txtQtd.Texts, out parsedValue))
            {
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Quantidade não pode ser nula";
                txtQtd.Focus();
            }
            else
            {
                lblReturnDB.Visible = false;
                string searchCodProduct = "SELECT prod_cod FROM tb_produtos where prod_nome = '" + cmbSaleProduct.Text + "'";
                MySqlCommand cmdsearchCodProduct = new MySqlCommand(searchCodProduct, dbConnections.connection);
                var codProduct = Convert.ToInt32(cmdsearchCodProduct.ExecuteScalar());

                string selectQuantityInInventory = "SELECT estoque_quantidade FROM tb_estoque WHERE estoque_cod = '" + codProduct + "'";
                MySqlCommand cmdSelectQuantityInInventory = new MySqlCommand(selectQuantityInInventory, dbConnections.connection);
                var quantityInv = Convert.ToDouble(cmdSelectQuantityInInventory.ExecuteScalar());

                string selectQuantityMinInInventory = "SELECT estoque_minimo FROM tb_estoque WHERE estoque_cod = '" + codProduct + "'";
                MySqlCommand cmdselectQuantityMinInInventory = new MySqlCommand(selectQuantityMinInInventory, dbConnections.connection);
                var quantityMin = Convert.ToDouble(cmdselectQuantityMinInInventory.ExecuteScalar());

                
                
                int intQtd = Convert.ToInt32(txtQtd.Texts);

                if(cmbSaleProduct.Text == "Selecione um Produto")
                {
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Selecione um produto";
                    cmbSaleProduct.Select();
                }
                else
                {
                    if (quantityInv <= quantityMin)
                    {
                        lblReturnDB.Visible = true;
                        lblReturnQuantity.Visible = true;
                        lblReturnDB.Text = "'" + cmbSaleProduct.Text + "' está abaixo do estoque mínimo";
                        lblReturnQuantity.Text = "Estoque: " + quantityInv + "";
                        if (quantityInv == 0)
                        {
                            lblReturnQuantity.Visible = false;
                            lblReturnDB.Text = "Estoque do produto " + cmbSaleProduct.Text + " está zerado";
                        }

                    }
                    else
                    {
                        lblReturnQuantity.Visible = false;
                    }
                    if (valQtd.CanUse(intQtd, codProduct))
                    {
                        MySqlCommand updateInvetory = new MySqlCommand("update tb_estoque set estoque_quantidade='" + valQtd.CalculateCurrentQuantity(intQtd, codProduct) + "' where estoque_cod = '" + codProduct + "'", dbConnections.connection);
                        updateInvetory.ExecuteNonQuery();


                        try
                        {
                            string consultProduct = "select prod_nome,preco_unit_venda from tb_produtos,tb_precos where prod_nome = '" + cmbSaleProduct.Text + "' AND id_produto = prod_cod";
                            MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                            MySqlDataReader reader = cmdInsertProduct.ExecuteReader();

                            while (reader.Read())
                            {

                                double price = double.Parse(txtQtd.Texts) * double.Parse(reader[1].ToString());
                                dgvProducts.Rows.Add(reader[0], txtQtd.Texts.Trim(), reader[1], price);
                                dgvProducts.Columns[2].DefaultCellStyle.Format = "c2";
                                dgvProducts.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");



                            }
                            double SumAmounts = 0;
                            foreach (DataGridViewRow row in dgvProducts.Rows)
                            {
                                double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[3].Index].Value);
                                SumAmounts += amount;
                                SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                                txtSubtotal.Texts = SumAmounts.ToString();
                            }

                        }
                        catch
                        {
                            lblReturnDB.Visible = true;
                            lblReturnDB.Text = "Quantidade não pode ser nula";
                            txtQtd.Select();
                            dbConnections.CloseConnection();
                        }

                        dbConnections.CloseConnection();


                    }
                    else
                    {
                        MessageBox.Show("Quantidade maior do que o existente no estoque, verifique o estoque!");
                        lblReturnQuantity.Text = "Estoque: " + quantityInv + "";
                        dbConnections.CloseConnection();
                    }

                }

             
                
            }
            dbConnections.CloseConnection();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            { 
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                double SumAmounts = 0;
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[3].Index].Value);
                    SumAmounts += amount;
                    SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                    txtSubtotal.Texts = SumAmounts.ToString();
                }
            }
        }

        public void txtSubtotal__TextChanged(object sender, EventArgs e)
        {
            txtDiscount.Texts = "0";
            double returnClass = totalPrice.SumPrice(txtSubtotal.Texts, txtDiscount.Texts);
            if (returnClass == -12345)
            {
                txtDiscount.Texts = "0";
            }
            else
            {
               
               txtTotalValue.Texts = "R$" + returnClass.ToString();
            }
        }
        private void txtDiscount__TextChanged(object sender, EventArgs e)
        {
            double returnClass = totalPrice.SumPrice(txtSubtotal.Texts, txtDiscount.Texts);
            if (returnClass == -12345)
            {
                txtDiscount.Texts = "0";
            }
            else
            {
                txtTotalValue.Texts = "R$" + returnClass.ToString();
            }
        }

        public void btnEndSale_Click(object sender, EventArgs e)
        {
            btnEndSale.Enabled = false;
            lblReturnDB.Visible = false;
            lblReturnQuantity.Visible = false;

            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {  //Seleciona o código do cliente
                string searchCodClient = "select cli_cod from tb_clientes where cli_nome = '"+cmbCostumer.Text+"'";
                MySqlCommand cmdsearcCodClient = new MySqlCommand(searchCodClient, dbConnections.connection);
                var codClient1 = Convert.ToInt32(cmdsearcCodClient.ExecuteScalar());

                //Seleciona o total de debitos do cliente.
                string getCostDebts = "select cli_total from tb_clientes where cli_cod = '" + codClient1 + "'";
                MySqlCommand cmdGetCostDebts = new MySqlCommand(getCostDebts, dbConnections.connection);
                var costDebts = Convert.ToString(cmdGetCostDebts.ExecuteScalar());


                string cost = totalPrice.SumTotalValue(txtTotalValue.Texts, costDebts);

                string returnCost = cost.Replace(",", ".");
                
                foreach (var row in this.dgvProducts.Rows)
                {
                    var dataGridViewRow = row as DataGridViewRow;
                    var cellName = dataGridViewRow.Cells[0]; 
                    var valueName = cellName.Value;
                    string valueConverted = valueName.ToString();

                    var cellQtd = dataGridViewRow.Cells[1];
                    var intQtd = Convert.ToInt32(cellQtd.Value);

                    var cellAmount = dataGridViewRow.Cells[3];
                    var decAmount = Convert.ToDecimal(cellAmount.Value);

                    string searchCodProd = "SELECT prod_cod FROM tb_produtos WHERE prod_nome = '" + valueConverted + "'";
                    MySqlCommand cmdsearchCodProd = new MySqlCommand(searchCodProd, dbConnections.connection);
                    int codProd = Convert.ToInt32(cmdsearchCodProd.ExecuteScalar());

                    //Seleciona o codigo da venda para inserir na tabela itens vendidos
                    string searchCodSale = "SELECT venda_cod FROM tb_vendas,tb_clientes WHERE id_venda_cliente = cli_cod AND cli_nome = '" + cmbCostumer.Text + "' ORDER BY venda_cod DESC LIMIT 1";
                    MySqlCommand cmdsearchCodSale = new MySqlCommand(searchCodSale, dbConnections.connection);
                    var codSale = Convert.ToInt32(cmdsearchCodSale.ExecuteScalar());
                    DateTime dateSale = DateTime.Now;
                    var dateSaleDate = DateOnly.FromDateTime(dateSale);
                    string registerProductSale = "INSERT INTO tb_itens_vendidos(iv_cod_venda,iv_cod_prod,iv_valor_total_item,iv_quantidade,iv_data) VALUES (@Id_Venda,@Id_Produto,@valorTotalItem,@Quantidade,@Data)";
                    MySqlCommand cmdregisterProductSale = new MySqlCommand(registerProductSale, dbConnections.connection);
                    cmdregisterProductSale.Parameters.Add("@Id_Venda", MySqlDbType.Int32, 10).Value = codSale;
                    cmdregisterProductSale.Parameters.Add("@Id_Produto", MySqlDbType.Int32, 10).Value = codProd;
                    cmdregisterProductSale.Parameters.Add("@valorTotalItem", MySqlDbType.Decimal, 9).Value = decAmount;
                    cmdregisterProductSale.Parameters.Add("@Quantidade", MySqlDbType.Int32, 10).Value = intQtd;
                    cmdregisterProductSale.Parameters.Add("@Data", MySqlDbType.Date).Value = dateSaleDate;
                    cmdregisterProductSale.ExecuteNonQuery();

                    string updateTotalDebt = "Update tb_clientes set cli_total ='" + returnCost + "' where cli_cod ='" + codClient1 + "'";
                    MySqlCommand cmdRegisterTotalDebt = new MySqlCommand(updateTotalDebt, dbConnections.connection);
                    cmdRegisterTotalDebt.ExecuteNonQuery();

                    string saleTotalValue = totalPrice.DimTotalValue(txtSubtotal.Texts, txtDiscount.Texts);
                    string returnSale = saleTotalValue.Replace(",", ".");

                    string updateTotalSale = "UPDATE tb_vendas set venda_valor_total = '" + returnSale + "' where venda_cod = '" + codSale + "'";
                    MySqlCommand cmdUpdateTotalSale = new MySqlCommand(updateTotalSale, dbConnections.connection);
                    cmdUpdateTotalSale.ExecuteNonQuery();
                    codSale = 0;

                }
                
                MessageBox.Show("Venda realizada");
                txtDiscount.Text = "0";
                txtTotalValue.Texts = "0";
                txtSubtotal.Texts ="0";
                cmbSaleProduct.Text = "";
                cmbSaleProduct.Enabled = false;
                txtQtd.Texts = "";
                txtQtd.Enabled = false;
                btnEndSale.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnCancelSale.Enabled = false;
                picSearchIcon_Sale.Enabled = false;
                btnNewSale.Enabled = true;
                dbConnections.CloseConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnections.CloseConnection();
            }
            dgvProducts.Rows.Clear();
            cmbCostumer.Enabled = true;
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            btnNewSale.Enabled = false;
            btnCancelSale.Enabled = true;
            cmbCostumer.Enabled = false;
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            cmbSaleProduct.Enabled = true;
            txtQtd.Enabled = true;
            txtDiscount.Enabled = true;
            picSearchIcon_Sale.Enabled = true;

                try
                {
                    string cmd_sale_products = "select prod_nome from tb_produtos";
                    MySqlDataAdapter da_products = new MySqlDataAdapter(cmd_sale_products, dbConnections.connection);
                    DataSet ds_products = new DataSet();
                    da_products.Fill(ds_products, "tb_produtos");
                    this.cmbSaleProduct.DisplayMember = "prod_nome";
                    this.cmbSaleProduct.ValueMember = "prod_cod";
                    this.cmbSaleProduct.DataSource = ds_products.Tables["tb_produtos"];
                    cmbSaleProduct.Text = "Selecione um Produto";
                    dgvProducts.Columns[2].HeaderText = "Valor Unitário";


                    if (string.IsNullOrEmpty(cmbCostumer.Text))
                    {
                        cmbCostumer.Text = "Selecione o cliente";
                    }
                    else
                    {
                        //Busca o codigo do cliente para registrar na tabela de vendas
                        string searchCodClient = "SELECT cli_cod FROM tb_clientes where cli_nome = '" + cmbCostumer.Text + "'";
                        MySqlCommand cmdsearchCodClient = new MySqlCommand(searchCodClient, dbConnections.connection);
                        var codClient = Convert.ToInt32(cmdsearchCodClient.ExecuteScalar());
                        //Insere 1 registro na tabela de vendas.
                        DateTime dateSale = DateTime.Now;
                        var dateSaleDate = DateOnly.FromDateTime(dateSale);
                        string registerSale = "INSERT INTO tb_vendas(id_venda_cliente,venda_data, venda_valor_total) VALUES ('" + codClient + "',@Data, '" + 00.00 + "')";
                        MySqlCommand cmdregisterSale = new MySqlCommand(registerSale, dbConnections.connection);
                        cmdregisterSale.Parameters.Add("@Data", MySqlDbType.Date).Value = dateSaleDate;
                        cmdregisterSale.ExecuteNonQuery();
                        dbConnections.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                    dbConnections.CloseConnection();
                }
                dbConnections.CloseConnection();

            

             
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            lblReturnQuantity.Enabled = false;
            btnEndSale.Enabled = false;
            btnCancelSale.Enabled = false;
            btnNewSale.Enabled = true;
            cmbSaleProduct.Enabled = false;
            cmbCostumer.Enabled = true;
            txtQtd.Enabled = false;
            txtSubtotal.Enabled = false;
            txtDiscount.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEndSale.Enabled = false;
            picSearchIcon_Sale.Enabled = false;
            lblReturnDB.Visible = false;
            if(dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();

            }
            
            try
            {
                if (dgvProducts.Rows.Count >= 1)
                {
                    
                  
                    foreach (var row in this.dgvProducts.Rows)
                    {
                        var dataGridViewRow = row as DataGridViewRow;
                        var cellQtd = dataGridViewRow.Cells[1];
                        var intQtd = Convert.ToInt32(cellQtd.Value);

                        var cellName = dataGridViewRow.Cells[0];
                        var valueName = cellName.Value;
                        string valueConverted = valueName.ToString();

                        string searchCodProd = "SELECT prod_cod FROM tb_produtos WHERE prod_nome = '" + valueConverted + "'";
                        MySqlCommand cmdsearchCodProd = new MySqlCommand(searchCodProd, dbConnections.connection);
                        int codProd = Convert.ToInt32(cmdsearchCodProd.ExecuteScalar());

                        string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(intQtd, codProd) + "' where estoque_cod = '" + codProd + "'";
                        MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                        cmdupdateInvetory.ExecuteNonQuery();

                    }
                    dgvProducts.Rows.Clear();


                    //Busca o codigo da ultima venda e deleta o registro.
                    string searchcodLastSale = "SELECT venda_cod FROM tb_vendas ORDER BY venda_cod DESC LIMIT 1";
                    MySqlCommand cmdsearchcodLastSale = new MySqlCommand(searchcodLastSale, dbConnections.connection);
                    var codlastSale = Convert.ToInt32(cmdsearchcodLastSale.ExecuteScalar());
                    //Deleta o último registro na tabela de vendas.
                    string registerSale = "DELETE FROM tb_vendas where venda_cod = ('" + codlastSale + "')";
                    MySqlCommand cmdregisterSale = new MySqlCommand(registerSale, dbConnections.connection);
                    cmdregisterSale.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    MessageBox.Show("Venda Cancelada!");
                    txtSubtotal.Texts = "";
                    txtTotalValue.Texts = "";
                    cmbSaleProduct.Text = "Selecione um Produto";
                    cmbCostumer.Items.Clear();
                    cmbSaleProduct.Items.Clear();
                    txtQtd.Texts = "";
                }
                else
                {
                    string searchcodLastSale = "SELECT venda_cod FROM tb_vendas ORDER BY venda_cod DESC LIMIT 1";
                    MySqlCommand cmdsearchcodLastSale = new MySqlCommand(searchcodLastSale, dbConnections.connection);
                    var codlastSale = Convert.ToInt32(cmdsearchcodLastSale.ExecuteScalar());
                    //Deleta o último registro na tabela de vendas.
                    string registerSale = "DELETE FROM tb_vendas where venda_cod = ('" + codlastSale + "')";
                    MySqlCommand cmdregisterSale = new MySqlCommand(registerSale, dbConnections.connection);
                    cmdregisterSale.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    txtSubtotal.Texts = "";
                    txtTotalValue.Texts = "";
                    cmbCostumer.Items.Clear();
                    cmbSaleProduct.Items.Clear();
                    txtQtd.Texts = "";
                }
            }
            catch
            {
                dbConnections.CloseConnection();
            }
            dbConnections.OpenConnection();

        }

        private void SaleForm_Leave_1(object sender, EventArgs e)
        {
            if (btnNewSale.Enabled == false)
            {
                if (MessageBox.Show("Deseja cancelar a venda em aberto?", "Venda",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnCancelSale_Click(sender, e);
                }
                else
                {
                    cmbSaleProduct.Select();
                }
            }


        }
    }
}
