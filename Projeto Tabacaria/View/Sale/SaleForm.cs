using Projeto_Tabacaria.DB;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using Projeto_Tabacaria.Validations;
using System.Windows.Forms;
using Org.BouncyCastle.Cms;
using System.Reflection.Metadata;

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
            lblReturnDB.Visible = false;
            lblReturnQuantity.Visible = false;
            cmbCostumer.Items.Clear();
            dgvProducts.Rows.Clear();
            txtSubtotal.Enabled = false;
            txtTroco.Enabled = false;
            txtDiscount.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEndSale.Enabled = false;
            btnEndSale.Enabled = false;
            btnCancelSale.Enabled = false;
            dgvProducts.Columns[2].HeaderText = "Tamanho em ML";
            dgvProducts.Columns[3].HeaderText = "Valor Unitário";
            txtBarCode.Enabled = false;

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

        
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            double SumAmounts = 0;

            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvProducts.SelectedRows.Count >= 1)
            {
                
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                var getNameProduct = dgvProducts.SelectedCells[0];
                var nameProduct = getNameProduct.Value;
                


                string searchCodProd = "SELECT prod_cod FROM tb_produtos WHERE prod_nome = '" + nameProduct + "'";
                MySqlCommand cmdsearchCodProd = new MySqlCommand(searchCodProd, dbConnections.connection);
                int codProd = Convert.ToInt32(cmdsearchCodProd.ExecuteScalar());

                string unidade = "SELECT prod_unidade FROM tb_produtos WHERE prod_cod = '" + codProd + "'";
                MySqlCommand cmdUnidade = new MySqlCommand(unidade, dbConnections.connection);
                string unidadeProd = cmdUnidade.ExecuteScalar().ToString();

                //devolvendo a quantidade de produtos removidos.
                if (unidadeProd == "LT" && txtBarCode.Enabled == true)
                {
                    var CellQtd = dgvProducts.SelectedCells[1];
                    var valueQtd = CellQtd.Value;
                    int Qtd = Convert.ToInt32(valueQtd);
                    intQtd = Qtd;

                    string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(intQtd, codProd) + "' where estoque_cod = '" + codProd + "'";
                    MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                    cmdupdateInvetory.ExecuteNonQuery();

                }
                else
                {
                    string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(1, codProd) + "' where estoque_cod = '" + codProd + "'";
                    MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                    cmdupdateInvetory.ExecuteNonQuery();
              
                }
                
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                

            }
            else
            {
                MessageBox.Show("Mais que um produto selecionado, delete 1 por vez");
                dbConnections.CloseConnection();
            }
            if(dgvProducts.RowCount == 0)
            {
                txtTotalValue.Texts = "";
                txtSubtotal.Texts = "";
            }

            dbConnections.CloseConnection();
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[3].Index].Value);
                SumAmounts += amount;
                SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                txtSubtotal.Texts = SumAmounts.ToString();
            }

        }

        public void txtSubtotal__TextChanged(object sender, EventArgs e)
        {
            if (txtSubtotal.Text == "")
            {
                txtSubtotal.Text = "0";
                txtSubtotal.Select();
            }
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
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
                txtDiscount.Select();
            }
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

            
            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                //Seleciona o código do cliente
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

                    if (dataGridViewRow.Cells[2].Value == "")
                    {
                        MessageBox.Show("Erro no código");
                        //var cellQtd = 1;
                        //var cellTam = dataGridViewRow.Cells[2].Value;

                        //int tet = Convert.ToInt32(cellTam.ToString());
                        //int tet2 = Convert.ToInt32(cellQtd.ToString());
                        //intQtd = tet * tet2;
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
                btnEndSale.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnCancelSale.Enabled = false;
                cmbCostumer.Enabled = true;

                btnNewSale.Enabled = true;
                txtBarCode.Visible = false;
                txtBarCode.Enabled = false;
                dbConnections.CloseConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnections.CloseConnection();
            }
            dgvProducts.Rows.Clear();
            txtDiscount.Text = "0";
            txtTotalValue.Texts = "0";
            txtSubtotal.Texts = "0";
            btnEndSale.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnCancelSale.Enabled = false;

            btnNewSale.Enabled = true;

        }

     

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            string Barcode = txtBarCode.Text;
            lblReturnQuantity.Enabled = false;
            btnEndSale.Enabled = false;
            btnCancelSale.Enabled = false;
            btnNewSale.Enabled = true;
            cmbCostumer.Enabled = true;
            txtSubtotal.Enabled = false;
            txtDiscount.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnEndSale.Enabled = false;

            lblReturnDB.Visible = false;
            txtBarCode.Visible = false;
            txtDiscount.Text = "0";
            txtTotalValue.Texts = "0";
            txtSubtotal.Texts = "0";
            btnEndSale.Enabled = false;
            btnDeleteItem.Enabled = false;
            btnCancelSale.Enabled = false;
            btnNewSale.Enabled = true;
            dgvProducts.AllowUserToAddRows = false;

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

                        if (dataGridViewRow.Cells[2].Value == "")
                        {
                            MessageBox.Show("Erro no código de barras");
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

                        string unidade = "SELECT prod_unidade FROM tb_produtos WHERE prod_cod = '" + codProd + "'";
                        MySqlCommand cmdUnidade = new MySqlCommand(unidade, dbConnections.connection);
                        string unidadeProd = cmdUnidade.ExecuteScalar().ToString();

                        //devolvendo a quantidade de produtos cancelados.
                        if (unidadeProd == "LT" && txtBarCode.Enabled == true)
                        {
                            var CellQtd = dataGridViewRow.Cells[1];
                            var valueQtd = CellQtd.Value;
                            int Qtd = Convert.ToInt32(valueQtd);
                            intQtd = Qtd;

                            string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(intQtd, codProd) + "' where estoque_cod = '" + codProd + "'";
                            MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                            cmdupdateInvetory.ExecuteNonQuery();

                          

                        }
                        else
                        {
                            string updateInventory = "update tb_estoque set estoque_quantidade='" + valQtd.AddQuantity(1, codProd) + "' where estoque_cod = '" + codProd + "'";
                            MySqlCommand cmdupdateInvetory = new MySqlCommand(updateInventory, dbConnections.connection);
                            cmdupdateInvetory.ExecuteNonQuery();

                            var cellQ = dataGridViewRow.Cells[2];
                            var value = cellQ.Value;
                            string value1 = value.ToString();
                        }
                        
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
                    SaleForm_Load(sender, e);
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
                    SaleForm_Load(sender, e);
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
                    
                }
            }


        }


        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if(e.KeyChar== (char)Keys.Enter)
                {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();

                }
                try
                {
                    intQtd = 1;
                    //Seleciona o código de barra do produto
                    string searchCodProduct = "SELECT cod_barra_prod,cod_barra_copo FROM tb_codigo_barra where cod_barra = '" + txtBarCode.Text + "'";
                    MySqlCommand cmdSearchProductOrCup = new MySqlCommand(searchCodProduct, dbConnections.connection);
                    MySqlDataReader readerProductOrCup;
                    readerProductOrCup = cmdSearchProductOrCup.ExecuteReader();
                    readerProductOrCup.Read();
                    var codProduct1 = readerProductOrCup.IsDBNull(0) ? null : readerProductOrCup.GetString(0);//cod barra do produto
                    var codCup1 = readerProductOrCup.IsDBNull(1) ? null : readerProductOrCup.GetString(1);//cod barra do copo

                    var codProduct = Convert.ToInt32(codProduct1);
                    var codCup = Convert.ToInt32(codCup1);
                    dbConnections.CloseConnection();

                    if (codProduct != 0)//0 representa nulo
                    {
                        if (dbConnections.connection.State != ConnectionState.Open)
                        {
                            dbConnections.OpenConnection();

                        }
                        //aqui vai o reader para pegar possição do DGV

                        string getUnity = "SELECT prod_unidade FROM tb_produtos WHERE prod_cod = '" + codProduct + "'";
                        MySqlCommand cmdGetUnity = new MySqlCommand(getUnity, dbConnections.connection);
                        var unityDB = Convert.ToString(cmdGetUnity.ExecuteScalar());
                        if (unityDB == "LT")
                        {
                            string selectQuantityInInventory = "SELECT estoque_quantidade FROM tb_estoque WHERE estoque_cod = '" + codProduct + "'";
                            MySqlCommand cmdSelectQuantityInInventory = new MySqlCommand(selectQuantityInInventory, dbConnections.connection);
                            var quantityInv = Convert.ToDouble(cmdSelectQuantityInInventory.ExecuteScalar());
                            var aa = quantityInv - 1000;
                            var retInventory = quantityInv - aa;

                            if (quantityInv <= 0)
                            {
                                MessageBox.Show("Quantidade zerada");
                                txtBarCode.Text = "";
                                txtBarCode.Focus();
                                txtBarCode.Select();
                                dbConnections.CloseConnection();
                            }
                            else if (quantityInv < retInventory)
                            {
                                MessageBox.Show("Quantidade inserida é maior do que o estoque");
                                txtBarCode.Text = "";
                                txtBarCode.Focus();
                                txtBarCode.Select();
                            }
                            else
                            {
                                MySqlCommand updateInvetory = new MySqlCommand("update tb_estoque set estoque_quantidade='" + aa + "' where estoque_cod = '" + codProduct + "'", dbConnections.connection);
                                updateInvetory.ExecuteNonQuery();

                                MySqlDataReader reader;
                                //Seleciona o nome e o preço unitário de venda do produto
                                string consultProduct = "select prod_nome,preco_unit_venda from tb_produtos,tb_precos where prod_cod = '" + codProduct + "' AND id_produto = prod_cod";
                                MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                                reader = cmdInsertProduct.ExecuteReader();
                                while (reader.Read())
                                {
                                    //Faz a validação se o produto é LT ou ML.
                                    if (unityDB == "LT")
                                    {
                                        double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], 1000, txtBarCode.Text, reader[1], reader[1]);
                                        dgvProducts.Columns[2].HeaderText = "Código";
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                    else
                                    {
                                        double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], intQtd.ToString().Trim(), txtBarCode.Text, reader[1], double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString()));
                                        dgvProducts.Columns[2].HeaderText = "Código";
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }

                                }
                                btnDeleteItem.Enabled = true;
                                btnEndSale.Enabled = true;
                                dbConnections.CloseConnection();
                                double SumAmounts = 0;
                                foreach (DataGridViewRow row in dgvProducts.Rows)
                                {
                                    double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[4].Index].Value);
                                    SumAmounts += amount;
                                    SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                                    txtSubtotal.Texts = SumAmounts.ToString();
                                }
                                txtBarCode.Clear();
                                txtBarCode.Select();

                            }



                        }
                        else
                        {
                            string selectQuantityInInventory = "SELECT estoque_quantidade FROM tb_estoque WHERE estoque_cod = '" + codProduct + "'";
                            MySqlCommand cmdSelectQuantityInInventory = new MySqlCommand(selectQuantityInInventory, dbConnections.connection);
                            var quantityInv = Convert.ToDouble(cmdSelectQuantityInInventory.ExecuteScalar());
                            var aa = quantityInv - 1;

                            if (quantityInv <= 0)
                            {
                                MessageBox.Show("Quantidade zerada");
                                txtBarCode.Text = "";
                                txtBarCode.Focus();
                                txtBarCode.Select();
                                dbConnections.CloseConnection();
                            }
                            else
                            {
                                MySqlCommand updateInvetory = new MySqlCommand("update tb_estoque set estoque_quantidade='" + aa + "' where estoque_cod = '" + codProduct + "'", dbConnections.connection);
                                updateInvetory.ExecuteNonQuery();

                                MySqlDataReader reader;
                                //Seleciona o nome e o preço unitário de venda do produto
                                string consultProduct = "select prod_nome,preco_unit_venda from tb_produtos,tb_precos where prod_cod = '" + codProduct + "' AND id_produto = prod_cod";
                                MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                                reader = cmdInsertProduct.ExecuteReader();
                                while (reader.Read())
                                {
                                    //Faz a validação se o produto é LT ou ML.
                                    if (unityDB == "LT")
                                    {
                                        double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], 1000, txtBarCode.Text, reader[1], reader[1]);
                                        dgvProducts.Columns[2].HeaderText = "Código";
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }
                                    else
                                    {
                                        double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                        dgvProducts.Rows.Add(reader[0], intQtd.ToString().Trim(), txtBarCode.Text, reader[1], double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString()));
                                        dgvProducts.Columns[2].HeaderText = "Código";
                                        dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                        dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                        dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    }

                                }
                                btnDeleteItem.Enabled = true;
                                btnEndSale.Enabled = true;
                                dbConnections.CloseConnection();
                                double SumAmounts = 0;
                                foreach (DataGridViewRow row in dgvProducts.Rows)
                                {
                                    double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[4].Index].Value);
                                    SumAmounts += amount;
                                    SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                                    txtSubtotal.Texts = SumAmounts.ToString();
                                }
                                txtBarCode.Clear();
                                txtBarCode.Select();

                            }


                        }
                    }
                    else
                    {
                        if (dbConnections.connection.State != ConnectionState.Open)
                        {
                            dbConnections.OpenConnection();

                        }

                        //busca o nome do produto vinculado ao código do copo
                        string nameProdCup = "select prod_nome from tb_unidade where cod_unidade='" + codCup + "'";
                        MySqlCommand cmdNameProdCup = new MySqlCommand(nameProdCup, dbConnections.connection);
                        var getNameProdCup = cmdNameProdCup.ExecuteScalar();

                        //Busca o o código do produto através do nome do produto
                        string selectCodProd = "Select prod_cod from tb_produtos where prod_nome = '" + getNameProdCup + "'";
                        MySqlCommand cmdSelectProdCod = new MySqlCommand(selectCodProd, dbConnections.connection);
                        var codigoProduto = Convert.ToInt32(cmdSelectProdCod.ExecuteScalar());

                        //Seleciona quantidade em estoque deste produto.
                        string selectQuantityInInventory = "SELECT estoque_quantidade FROM tb_estoque WHERE estoque_cod = '" + codigoProduto + "'";
                        MySqlCommand cmdSelectQuantityInInventory = new MySqlCommand(selectQuantityInInventory, dbConnections.connection);
                        var quantityInv = Convert.ToDouble(cmdSelectQuantityInInventory.ExecuteScalar());

                        string selectQuantityCup = "select unidade_quantidade from tb_unidade where cod_unidade = '" + codCup + "'";
                        MySqlCommand cmdselectQuantityCup = new MySqlCommand(selectQuantityCup, dbConnections.connection);
                        var QuantityCup = Convert.ToInt32(cmdselectQuantityCup.ExecuteScalar());


                        var aa = quantityInv - QuantityCup;

                        if (quantityInv <= 0)
                        {
                            MessageBox.Show("Quantidade Zerada");
                            dbConnections.CloseConnection();
                        }
                        else
                        {
                            //Seleciona o tipo de unidade do produto
                            string getUnity = "SELECT prod_unidade FROM tb_produtos WHERE prod_cod = '" + codigoProduto + "'";
                            MySqlCommand cmdGetUnity = new MySqlCommand(getUnity, dbConnections.connection);
                            var unityDB = Convert.ToString(cmdGetUnity.ExecuteScalar());

                            //Remove o produto do estoque pelo código.
                            if (unityDB == "LT")
                            {
                                MySqlCommand updateInvetory = new MySqlCommand("update tb_estoque set estoque_quantidade='" + aa + "' where estoque_cod = '" + codigoProduto + "'", dbConnections.connection);
                                updateInvetory.ExecuteNonQuery();

                            }
                            else
                            {
                                MySqlCommand updateInvetory = new MySqlCommand("update tb_estoque set estoque_quantidade='" + valQtd.CalculateCurrentQuantity(intQtd, codigoProduto) + "' where estoque_cod = '" + codigoProduto + "'", dbConnections.connection);
                                updateInvetory.ExecuteNonQuery();
                            }


                            MySqlDataReader reader;

                            //Seleciona o nome e o preço unitário de venda do produto
                            string consultProduct = "select unidade_quantidade,unidade_valor,prod_nome from tb_unidade where prod_nome = '" + getNameProdCup + "'";
                            MySqlCommand cmdInsertProduct = new MySqlCommand(consultProduct, dbConnections.connection);
                            reader = cmdInsertProduct.ExecuteReader();
                            while (reader.Read())
                            {
                                //Faz a validação se o produto é LT ou ML.
                                if (unityDB == "LT")
                                {
                                    //reader 2 = nome do produto
                                    //reader 0 = quantidade do copo
                                    //reader 1 = valor da unidade
                                    double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                    dgvProducts.Rows.Add(reader[2], reader[0], txtBarCode.Text, reader[1], reader[1]);
                                    dgvProducts.Columns[2].HeaderText = "Código";
                                    dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                    dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                    dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                }
                                else
                                {
                                    double price = double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString());
                                    dgvProducts.Rows.Add(reader[0], intQtd.ToString().Trim(), txtBarCode.Text, reader[1], double.Parse(intQtd.ToString()) * double.Parse(reader[1].ToString()));
                                    dgvProducts.Columns[2].HeaderText = "Código";
                                    dgvProducts.Columns[3].DefaultCellStyle.Format = "c2";
                                    dgvProducts.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                    dgvProducts.Columns[4].DefaultCellStyle.Format = "c2";
                                    dgvProducts.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                                }

                            }
                            btnDeleteItem.Enabled = true;
                            btnEndSale.Enabled = true;
                            dbConnections.CloseConnection();
                            double SumAmounts = 0;
                            foreach (DataGridViewRow row in dgvProducts.Rows)
                            {
                                double amount = Convert.ToDouble(row.Cells[dgvProducts.Columns[4].Index].Value);
                                SumAmounts += amount;
                                SumAmounts = (double)System.Math.Round(SumAmounts, 2);
                                txtSubtotal.Texts = SumAmounts.ToString();
                            }


                        }
                        txtBarCode.Clear();
                        txtBarCode.Select();

                    }

                }
                catch
                {
                    MessageBox.Show("Código de barra não encontado!");
                    dbConnections.CloseConnection();

                }
           }
            
        }

        private void txtMoneyPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtMoneyPay.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                char[] amount = { 'R', '$' };
                string outAmount = txtTotalValue.Texts.Trim(amount);
                string outAmountDiscount = txtMoneyPay.Texts.Trim(amount);
                double price = Convert.ToDouble(outAmountDiscount) - Convert.ToDouble(outAmount);
                txtTroco.Texts = price.ToString();

            }

        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            btnNewSale.Enabled = false;
            btnCancelSale.Enabled = true;
            cmbCostumer.Enabled = false;
            txtBarCode.Enabled = true;
            txtBarCode.Visible = true;         
            txtBarCode.Text = "";
            txtDiscount.Enabled = true;
            txtBarCode.Focus();

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

        private void SaleForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnNewSale_Click(sender, e);
            }

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtDiscount.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
