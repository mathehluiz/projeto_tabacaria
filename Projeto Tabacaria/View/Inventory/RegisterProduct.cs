using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Projeto_Tabacaria.View
{
    public partial class RegisterProduct : Form
    {
        MySqlConnection conn = new MySqlConnection("server = 192.168.1.104; port = 3306; database = schema_tabacaria; uid = tabacaria; pwd = Vi@r.1851");

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
            double a = txtQtd.Texts != "" ? Convert.ToDouble(txtQtd.Texts) : 0;
            double b = txtBuyValue.Texts != "" ? Convert.ToDouble(txtBuyValue.Texts) : 0;
            double total = a * b;

            txtTotal.Texts = "R$ " + total.ToString();
        }

        private void txtBuyValue__TextChanged(object sender, EventArgs e)
        {
            double a = txtQtd.Texts != "" ? Convert.ToDouble(txtQtd.Texts) : 0;
            double b = txtBuyValue.Texts != "" ? Convert.ToDouble(txtBuyValue.Texts) : 0;
            double total = a * b;
            total = (double)System.Math.Round(total, 2);

            txtTotal.Texts = "R$ " + total.ToString();
        }

        private void butRegisterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd_GetGroup = new MySqlCommand("SELECT grupo_id from tb_grupos where grupo_nome='" + cmbGrupo.Text + "'", conn);
                MySqlCommand cmd_GetBrand = new MySqlCommand("SELECT marca_cod from tb_marca where marca_nome='" + cmbMarca.Text + "'", conn);

                var GroupQueryResult = Convert.ToInt32(cmd_GetGroup.ExecuteScalar());
                var brandQueryResult = Convert.ToInt32(cmd_GetBrand.ExecuteScalar());


                double a = txtQtd.Texts != "" ? Convert.ToDouble(txtQtd.Texts) : 0;
                double b = txtBuyValue.Texts != "" ? Convert.ToDouble(txtBuyValue.Texts) : 0;
                double total = a * b;

                MySqlCommand cmd = new MySqlCommand("insert into tb_produtos (prod_nome,prod_unidade,prod_id_grupo,prod_id_marca) values (@Nome,@Unidade, @Id_grupo, @Id_marca);" +
                    "insert into tb_estoque(estoque_cod,estoque_quantidade) values (@Id_Prod,@Quantidade);" +
                    "insert into tb_precos(id_produto,preco_unit_compra,preco_unit_venda,preco_total_gasto) values (@Id_Prod,@Valor_Unitario_Compra,@Valor_Unitario_Venda,@Valor_Total)", conn);

                cmd.Parameters.Add("@Id_Grupo", MySqlDbType.Int32, 10).Value = GroupQueryResult;
                cmd.Parameters.Add("@Id_Marca", MySqlDbType.Int32, 10).Value = brandQueryResult;
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = txtProdName.Texts;
                cmd.Parameters.Add("@Quantidade", MySqlDbType.Float, 10).Value = Convert.ToDouble(txtQtd.Texts);
                cmd.Parameters.Add("@Id_Prod", MySqlDbType.Int32, 10).Value = Convert.ToInt32(txtProdCod.Texts);
                cmd.Parameters.Add("@Unidade", MySqlDbType.VarChar, 10).Value = cmbUnidade_De_Medida.Text;
                cmd.Parameters.Add("@Valor_Unitario_Compra", MySqlDbType.Float, 10).Value = Convert.ToDouble(txtBuyValue.Texts);
                cmd.Parameters.Add("@Valor_Unitario_Venda", MySqlDbType.Float, 10).Value = Convert.ToDouble(txtSaleValue.Texts);
                cmd.Parameters.Add("@Valor_Total", MySqlDbType.Float, 10).Value = total;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produto registrado!!");
                txtProdName.Texts = "";
                txtQtd.Texts = "";
                txtBuyValue.Texts = "";
                txtSaleValue.Texts = "";
                txtTotal.Texts = "";
                this.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!!" + ex);
                conn.Close();
            }
        }

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query_groups = "select grupo_nome from tb_grupos";
            MySqlDataAdapter da = new MySqlDataAdapter(query_groups, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_grupos");
            this.cmbGrupo.DisplayMember = "GRUPO_NOME";
            this.cmbGrupo.ValueMember = "GRUPO_ID";
            this.cmbGrupo.DataSource = ds.Tables["tb_grupos"];


            string query_marca = "select marca_nome from tb_marca";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query_marca, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "tb_marca");
            this.cmbMarca.DisplayMember = "MARCA_NOME";
            this.cmbMarca.ValueMember = "MARCA_COD";
            this.cmbMarca.DataSource = ds1.Tables["tb_marca"];

            string query_next_prod = "SELECT COUNT(prod_cod)+1 FROM tb_produtos";
            MySqlCommand cmd = new MySqlCommand(query_next_prod,conn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            txtProdCod.Texts = reader.GetString(0);
            conn.Close();
        }
    }
}