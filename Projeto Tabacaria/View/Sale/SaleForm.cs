using Projeto_Tabacaria.DB;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using Projeto_Tabacaria.Validations;


namespace Projeto_Tabacaria.View
{


    public partial class SaleForm : Form
    {
        DBConnections dbConnections = new();
        BuildTotalPrice totalPrice = new();
        ValidateQuantity valQtd = new();
        int intQtd;


        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            cmbCups.Visible = false;
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
            dgvProducts.Columns[2].HeaderText = "Tamanho em ML";
            dgvProducts.Columns[3].HeaderText = "Valor Unitário";

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
            cmbSaleProduct.Text = "Selecione um produto";


        }

        private void picSearchIcon_Sale_Click(object sender, EventArgs e)
        {
            btnDeleteItem.Enabled = true;
            btnEndSale.Enabled = true;
            dgvProducts.Columns[2].HeaderText = "Tamanho em ML";
            dgvProducts.Columns[3].HeaderText = "Valor Unitário";

            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            double parsedValue;
            if (!double.TryParse(txtQtd.Text, out parsedValue))
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

                string getTam = "SELECT unidade_quantidade FROM tb_unidade where unidade_nome = '" + cmbCups.Text + "'";
                MySqlCommand getTamCmd = new MySqlCommand(getTam, dbConnections.connection);
                int tam = Convert.ToInt32(getTamCmd.ExecuteScalar());

                string getUnity = "SELECT prod_unidade FROM tb_produtos WHERE prod_nome = '" + cmbSaleProduct.Text + "'";
                MySqlCommand cmdGetUnity = new MySqlCommand(getUnity, dbConnections.connection);
                var unityDB = Convert.ToString(cmdGetUnity.ExecuteScalar());

                if (tam != 0)
                {
                    intQtd = Convert.ToInt32(txtQtd.Text) * tam;
                }
                else
                {
                    intQtd = Convert.ToInt32(txtQtd.Text);
                }

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
                            MySqlDataReader reader;
                            // Seleciona a unidade de medida do produto. ML, LT OU UN.
                            if (cmbCups.Enabled)
                            {
                                string consultProduct = "select prod_nome, unidade_quantidade,unidade_valor from tb_unidade where unidade_nome = '" + cmbCups.Text + "'";
                                MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                                reader = cmdInsertProduct.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (unityDB == "LT" || unityDB == "ML")
                                    {
                                        dgvProducts.Rows.Add(reader[0], txtQtd.Text.Trim(), reader[1], reader[2], reader[2]);
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                    else
                                    {
                                        dgvProducts.Rows.Add(reader[0], txtQtd.Text.Trim(), reader[1], reader[2], double.Parse(txtQtd.Text) * double.Parse(reader[2].ToString()));
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                }
                            }
                            else
                            {
                                string consultProduct = "select prod_nome,preco_unit_venda from tb_produtos,tb_precos where prod_nome = '" + cmbSaleProduct.Text + "' AND id_produto = prod_cod";
                                MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                                reader = cmdInsertProduct.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (unityDB == "LT" || unityDB == "ML")
                                    {
                                        double price = double.Parse(txtQtd.Text) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], txtQtd.Text.Trim(), "", reader[1], reader[1]);
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                    else
                                    {
                                        double price = double.Parse(txtQtd.Text) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], txtQtd.Text.Trim(), "", reader[1], double.Parse(txtQtd.Text) * double.Parse(reader[1].ToString()));
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                    
                                }
                            }
                            double SumAmounts = 0;
                            foreach (DataGridViewRow row in dgvProducts.Rows)
                            {
                                double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[4].Index].Value);
                                SumAmounts += amount;
                                SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                                txtSubtotal.Texts = SumAmounts.ToString();
                            }
                        }
                        catch(Exception ex)
                        {
                            lblReturnDB.Visible = true;
                            MessageBox.Show("Erro" + ex);
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
            cmbCups.Visible = false;

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
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                double SumAmounts = 0;
                foreach (var row in this.dgvProducts.Rows)
                {
                    var dataGridViewRow = row as DataGridViewRow;

                    var cellName = dataGridViewRow.Cells[0];
                    var valueName = cellName.Value;
                    string valueConverted = valueName.ToString();

                    var cellQtd = dataGridViewRow.Cells[1].Value;
                    int tet2 = Convert.ToInt32(cellQtd.ToString());
                    intQtd = tet2;


                    string searchCodProd = "SELECT prod_cod FROM tb_produtos WHERE prod_nome = '" + valueConverted + "'";
                    MySqlCommand cmdsearchCodProd = new MySqlCommand(searchCodProd, dbConnections.connection);
                    int codProd = Convert.ToInt32(cmdsearchCodProd.ExecuteScalar());

                    string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(intQtd, codProd) + "' where estoque_cod = '" + codProd + "'";
                    MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                    cmdupdateInvetory.ExecuteNonQuery();

                    dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);

                }
            }
            dbConnections.CloseConnection();
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

                    if (dataGridViewRow.Cells[2].Value != "")
                    {
                        var cellQtd = dataGridViewRow.Cells[1].Value;
                        var cellTam = dataGridViewRow.Cells[2].Value;

                        int tet = Convert.ToInt32(cellTam.ToString());
                        int tet2 = Convert.ToInt32(cellQtd.ToString());
                        intQtd = tet * tet2;
                    }
                    else
                    {
                        var cellQtd = dataGridViewRow.Cells[1].Value;
                        intQtd = Convert.ToInt32(cellQtd.ToString());
                    }

                    var cellAmount = dataGridViewRow.Cells[4];
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
                txtQtd.Text = "";
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
            cmbCups.Enabled = true;
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
                    cmbSaleProduct.Text = "Selecione um produto";





                if (string.IsNullOrEmpty(cmbCostumer.Text))
                    {
                        cmbCostumer.Text = "Selecione o cliente";
                    }
                    else
                    {
                        if (dbConnections.connection.State != ConnectionState.Open)
                        {
                        dbConnections.OpenConnection();
                        }
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
            cmbCups.Visible = false;
            lblReturnQuantity.Enabled = false;
            btnEndSale.Enabled = false;
            btnCancelSale.Enabled = false;
            btnNewSale.Enabled = true;
            cmbSaleProduct.Enabled = false;
            cmbCostumer.Enabled = true;
            cmbCups.Enabled = false;
            txtQtd.Enabled = false;
            txtSubtotal.Enabled = false;
            txtDiscount.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEndSale.Enabled = false;
            picSearchIcon_Sale.Enabled = false;
            lblReturnDB.Visible = false;

            int intQtd;

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

                        var cellName = dataGridViewRow.Cells[0];
                        var valueName = cellName.Value;
                        string valueConverted = valueName.ToString();

                        if (dataGridViewRow.Cells[2].Value != "")
                        {
                            var cellQtd = dataGridViewRow.Cells[2].Value;
                            var cellTam = dataGridViewRow.Cells[1].Value;

                            int tet = Convert.ToInt32(cellTam.ToString());
                            int tet2 = Convert.ToInt32(cellQtd.ToString());
                            intQtd = tet * tet2;
                        }
                        else
                        {
                            var cellQtd = dataGridViewRow.Cells[1].Value;
                            int tet2 = Convert.ToInt32(cellQtd.ToString());
                            intQtd = tet2;
                        }

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
                    lblReturnDB.Visible = false;
                    lblReturnQuantity.Visible = false;
                    cmbSaleProduct.Text = "Selecione um Produto";
                    cmbCostumer.Items.Clear();
                    cmbSaleProduct.Items.Clear();
                    txtQtd.Text = "0";
                    cmbCups.Visible = false;
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
                    txtQtd.Text = "";
                    cmbCups.Enabled = false;
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

        private void cmbSaleProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
        }

        private void cmbSaleProduct_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbSaleProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();

            }


            string selectProdUn = "select prod_unidade from tb_produtos where prod_nome = '" + cmbSaleProduct.Text + "'";
            MySqlCommand cmdselectProdUn = new MySqlCommand(selectProdUn, dbConnections.connection);
            string prodUn = Convert.ToString(cmdselectProdUn.ExecuteScalar());

            if (prodUn == "LT" || prodUn == "ML")
            {

                if (MessageBox.Show("Deseja vender copo?", "Venda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmbCups.Visible = true;
                    cmbCups.Enabled = true;
                    string queryCups = "select unidade_nome from tb_unidade where prod_nome = '" + cmbSaleProduct.Text + "'";
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCups, dbConnections.connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_unidade");
                    this.cmbCups.DisplayMember = "unidade_nome";
                    this.cmbCups.ValueMember = "cod_unidade";
                    this.cmbCups.DataSource = ds.Tables["tb_unidade"];

                }
                dbConnections.CloseConnection();
            }
        }
    }
}
