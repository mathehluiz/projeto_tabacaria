using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System.Data;
using System.Runtime.InteropServices;

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class RegisterProduct : Form
    {
        DBConnections dbConnections = new DBConnections();
        int contador = 0;

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
        public RegisterProduct()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtQtd__TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtQuantity.Text = "0";
                txtQuantity.SelectAll();
            }
            string ml = "ML";
            if (cmbUnidade_De_Medida.Text == ml || cmbUnidade_De_Medida.Text == "LT")
            {
                txtTotal.Text = txtBuyValue.Text;
                txtTotalSale.Text = txtSaleValue.Text;
            }
            else
            {
                var buyvalue = txtBuyValue.Text.ToString().Replace(",", ".");
                var quantity = txtQuantity.Text.ToString().Replace(",", ".");

                decimal a = Convert.ToDecimal(quantity);
                decimal b = Convert.ToDecimal(buyvalue);
                decimal total = a * b;

                txtTotal.Text = total.ToString();
                txtTotalSale.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtSaleValue.Text)).ToString();
            }
            txtTotalProfit.Text = (Convert.ToDecimal(txtTotalSale.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();
        }

        private void txtBuyValue__TextChanged(object sender, EventArgs e)
        {
            if (txtBuyValue.Text == "")
            {
                txtBuyValue.Text = "0";
                txtBuyValue.SelectAll();
            }
            string ml = "ML";
            if (cmbUnidade_De_Medida.Text == ml)
            {
                txtTotal.Text = txtBuyValue.Text;
                txtTotalSale.Text = txtSaleValue.Text;
            }
            else
            {
                //parei aqui
                var buyvalue = txtBuyValue.Text.ToString().Replace(",", ".");
                var quantity = txtQuantity.Text.ToString().Replace(",", ".");

                decimal a = Convert.ToDecimal(quantity);
                decimal b = Convert.ToDecimal(buyvalue);
                decimal total = a * b;
                total = (decimal)System.Math.Round(total, 2);
                txtTotal.Text = total.ToString();
                txtTotalSale.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtSaleValue.Text)).ToString();
            }


            txtTotalProfit.Text = (Convert.ToDecimal(txtTotalSale.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();
        }
        private void txtSaleValue__TextChanged(object sender, EventArgs e)
        {
            if (txtSaleValue.Text == "")
            {
                txtSaleValue.Text = "0";
                txtSaleValue.SelectAll();
            }
            string ml = "ML";
            if (cmbUnidade_De_Medida.Text == ml)
            {
                txtTotal.Text = txtBuyValue.Text;
                txtTotalSale.Text = txtSaleValue.Text;
            }
            else
            {
                var salevalue = txtSaleValue.Text.ToString().Replace(",", ".");

                //decimal a = Convert.ToDecimal(txtQuantity.Text);
                //decimal b = Convert.ToDecimal(buyvalue);
                //decimal total = a * b;
                //total = (decimal)System.Math.Round(total, 2);
                //txtTotalSale.Text = total.ToString();
                txtTotalSale.Text = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(salevalue)).ToString();
            }


            txtTotalProfit.Text = (Convert.ToDecimal(txtTotalSale.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();
        }

        public void butRegisterProduct_Click(object sender, EventArgs e)
        {
            RefreshForm.Enabled = true;
            try
            {
                if (cmbUnidade_De_Medida.Text != "")
                {
                  
                    var quantityInventoryMin = Convert.ToDouble(txtInventoryMin.Text);
                    if (quantityInventoryMin <= 0)
                    {
                        MessageBox.Show("A quantidade mínima não pode ser 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (dbConnections.connection.State != ConnectionState.Open)
                        {
                            dbConnections.OpenConnection();
                        }


                        MySqlCommand cmdGetGroup = new MySqlCommand("SELECT grupo_id from tb_grupos where grupo_nome='" + cmbGrupo.Text + "'", dbConnections.connection);
                        MySqlCommand cmdGetBrand = new MySqlCommand("SELECT marca_cod from tb_marca where marca_nome='" + cmbMarca.Text + "'", dbConnections.connection);

                        var GroupQueryResult = Convert.ToInt32(cmdGetGroup.ExecuteScalar());
                        var brandQueryResult = Convert.ToInt32(cmdGetBrand.ExecuteScalar());



                        //registrar produto
                        MySqlCommand cmdRegisterProduct = new MySqlCommand("insert into tb_produtos (prod_nome,prod_last_update,prod_unidade,prod_id_grupo,prod_id_marca) values (@Nome,@Time,@Unidade,@Id_grupo, @Id_marca)", dbConnections.connection);
                        cmdRegisterProduct.Parameters.Add("@Id_Grupo", MySqlDbType.Int32, 10).Value = GroupQueryResult;
                        cmdRegisterProduct.Parameters.Add("@Id_Marca", MySqlDbType.Int32, 10).Value = brandQueryResult;
                        cmdRegisterProduct.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = txtProdName.Text;
                        cmdRegisterProduct.Parameters.Add("@Unidade", MySqlDbType.VarChar, 10).Value = cmbUnidade_De_Medida.Text;
                        DateTime dateTime = DateTime.Now;
                        var dateTimeDate = DateOnly.FromDateTime(dateTime);
                        cmdRegisterProduct.Parameters.Add("@Time", MySqlDbType.Date).Value = dateTimeDate;

                        cmdRegisterProduct.ExecuteNonQuery();

                        //obter cod do produto
                        MySqlCommand cmdSelectProdCod = new MySqlCommand("SELECT prod_cod FROM tb_produtos ORDER BY prod_cod DESC LIMIT 1", dbConnections.connection);
                        var codprod = cmdSelectProdCod.ExecuteScalar();

                        var buyvalue = txtBuyValue.Text.ToString().Replace(",", ".");
                        var salevalue = txtSaleValue.Text.ToString().Replace(",", ".");



                        //registar preço
                        MySqlCommand cmdRegisterPrice = new MySqlCommand("insert into tb_precos (id_produto,preco_unit_compra, preco_unit_venda,preco_lucro) values ('"+ codprod + "',@Valor_Unitario_Compra, @Valor_Unitario_Venda,@Lucro)", dbConnections.connection);
                        cmdRegisterPrice.Parameters.Add("@Valor_Unitario_Compra", MySqlDbType.Decimal, 9).Value = Convert.ToDecimal(buyvalue);
                        cmdRegisterPrice.Parameters.Add("@Valor_Unitario_Venda", MySqlDbType.Decimal, 9).Value = Convert.ToDecimal(salevalue);
                        cmdRegisterPrice.Parameters.Add("@Lucro", MySqlDbType.Decimal, 9).Value = (Convert.ToDecimal(salevalue) - Convert.ToDecimal(buyvalue));
                        cmdRegisterPrice.ExecuteNonQuery();

                        //registra estoque
                        MySqlCommand cmd2 = new MySqlCommand("insert into tb_estoque(estoque_cod,estoque_quantidade,estoque_lastupdate,estoque_minimo) values (@Cod_prod,@Quantidade,@Time,@EstoqueMin)", dbConnections.connection);
                        if (cmbUnidade_De_Medida.Text == "LT")
                        {
                            cmd2.Parameters.Add("@Quantidade", MySqlDbType.Float, 10).Value = Convert.ToDecimal(txtQuantity.Text) * 1000;
                        }
                        else
                        {
                            cmd2.Parameters.Add("@Quantidade", MySqlDbType.Float, 10).Value = txtQuantity.Text;
                        }
                        DateTime dateTime1 = DateTime.Now;
                        var dateTimeDate1 = DateOnly.FromDateTime(dateTime1);
                        cmd2.Parameters.Add("@Time", MySqlDbType.Date).Value = dateTimeDate1;
                        cmd2.Parameters.Add("@EstoqueMin", MySqlDbType.Float, 10).Value = quantityInventoryMin;
                        cmd2.Parameters.Add("@Cod_prod", MySqlDbType.Int32, 10).Value = codprod;
                        cmd2.ExecuteNonQuery();
                        dbConnections.CloseConnection();


                        if (String.IsNullOrEmpty(cmbUnidade_De_Medida.Text))
                        {
                            MessageBox.Show("O valor não pode ser nulo!");
                        }
                        else
                        {              
                      
                            lblReturnDB.Visible = true;
                            lblReturnDB.Text = "Produto Registrado";
                            txtProdName.Text = "";
                            txtQuantity.Text = "0";
                            txtBuyValue.Text = "0";
                            txtSaleValue.Text = "0";
                            txtTotal.Text = "0";
                            txtInventoryMin.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unidade de medida não pode ser nula");
                }
            }
            catch(Exception ex1)
            {
                MessageBox.Show("" + ex1);
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "ERRO";
                dbConnections.CloseConnection();
            }
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {


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
                this.cmbGrupo.DisplayMember = "grupo_nome";
                this.cmbGrupo.ValueMember = "grupo_id";
                this.cmbGrupo.DataSource = ds1.Tables["tb_grupos"];
                dbConnections.CloseConnection();


                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                MySqlCommand cmd_search_brand_groupname = new MySqlCommand("SELECT grupo_id FROM tb_grupos WHERE grupo_nome = '" + cmbGrupo.Text + "'", dbConnections.connection);
                int GroupQueryResult = Convert.ToInt32(cmd_search_brand_groupname.ExecuteScalar());
                string query_brand_group = "SELECT marca_nome, marca_cod FROM tb_marca WHERE id_grupo_marca = '" + GroupQueryResult + "'";
                var cmd = dbConnections.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query_brand_group;
                cmd.ExecuteNonQuery();
                cmbGrupo.Text = "Selecione o grupo";

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
                da2.Fill(dt);

                if (cmbMarca.Items.Count > 0)
                {
                    cmbMarca.SelectedIndex = 0;
                    cmbMarca.Items.Clear();
                }
                foreach (DataRow dr in dt.Rows)
                {
                    cmbMarca.Items.Add(dr["marca_nome"].ToString());
                    cmbMarca.Text = cmbMarca.Items[0].ToString();
                    cmbMarca.Text = "Selecione a marca";
                }

                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();

        }

        private void RefreshForm_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                contador = 0;
                RefreshForm.Enabled = false;
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string query_groups = "select grupo_nome from tb_grupos";
                MySqlDataAdapter da = new MySqlDataAdapter(query_groups, dbConnections.connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_grupos");
                this.cmbGrupo.DisplayMember = "GRUPO_NOME";
                this.cmbGrupo.ValueMember = "GRUPO_ID";
                this.cmbGrupo.DataSource = ds.Tables["tb_grupos"];


                string query_marca = "select marca_nome from tb_marca";
                MySqlDataAdapter da1 = new MySqlDataAdapter(query_marca, dbConnections.connection);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "tb_marca");
                this.cmbMarca.DisplayMember = "MARCA_NOME";
                this.cmbMarca.ValueMember = "MARCA_COD";
                this.cmbMarca.DataSource = ds1.Tables["tb_marca"];

                dbConnections.CloseConnection();

                txtSaleValue.Text = "0";
                txtTotal.Text = "0";
                txtBuyValue.Text = "0";
                txtQuantity.Text = "0";
            }

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
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
                MySqlCommand cmdsearchBrandGroupname = new MySqlCommand("SELECT grupo_id FROM tb_grupos WHERE grupo_nome = '" + cmbGrupo.Text + "'", dbConnections.connection);
                int GroupQueryResult = Convert.ToInt32(cmdsearchBrandGroupname.ExecuteScalar());
                string queryBrandGroup = "SELECT marca_nome, marca_cod FROM tb_marca WHERE id_grupo_marca = '" + GroupQueryResult + "'";
                var cmd = dbConnections.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = queryBrandGroup;
                cmd.ExecuteNonQuery();


                if (cmbMarca.Items.Count > 0)
                {
                    dt.Rows.Clear();
                    cmbMarca.Items.Clear();
                }


                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
                da2.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbMarca.Items.Add(dr["marca_nome"].ToString());

                }
                cmbMarca.SelectedIndex = 0;


                dbConnections.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            dbConnections.CloseConnection();
        }


        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtBuyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtBuyValue.Text.Contains(","))
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

        private void txtSaleValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                butRegisterProduct_Click(sender, e);
            }
                if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtSaleValue.Text.Contains(","))
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

        private void txtInventoryMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}