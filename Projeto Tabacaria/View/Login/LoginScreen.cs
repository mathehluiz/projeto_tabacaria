using Projeto_Tabacaria.View;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_Tabacaria
{
    
    public partial class LoginScreen : Form
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

        public LoginScreen()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string query = "select Username,Password from tb_user where Username='" + txtUsername.Texts + "' and Password='" + txtPassword.Texts + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MenuScreen menuScreen = new MenuScreen();
                    menuScreen.Show();
                    this.Close();
                    conn.Close();
                }
                else
                {
                    lblReturnDB.Text = ("Usuário ou senha incorretos");
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + Convert.ToString(ex));
            }
            conn.Close();
        }
    }
}