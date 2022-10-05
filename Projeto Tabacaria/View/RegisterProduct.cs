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

        private void mnButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta_marca = "SELECT marca_cod FROM tb_marca WHERE marca_nome='@Id_Marca'";
            string consulta_grupo = "SELECT grupo_id FROM tb_grupos WHERE grupo_nome='@Id_Grupo";

            MySqlCommand cmd = new MySqlCommand("insert into tb_produtos (prod_nome,prod_unidade,prod_id_grupo,prod_id_marca) values (@Nome,@Unidade')",conn);
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = txtProdName.Texts;
            cmd.Parameters.Add("@Unidade", MySqlDbType.VarChar, 10).Value = cmbUnidade_De_Medida.Text;
            cmd.Parameters.Add("@Id_Grupo", MySqlDbType.Int32, 10).Value = cmbGrupo.Text;    
            cmd.Parameters.Add("@Id_Marca", MySqlDbType.Int32, 10).Value = cmbMarca.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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