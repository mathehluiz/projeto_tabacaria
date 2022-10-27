using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class RegisterGroup : Form
    {
        DBConnections dbConnections = new();
        public RegisterGroup()
        {
            InitializeComponent();
            lblReturnDB.Visible = false;
        }

        private void bntRegGroup_Click(object sender, EventArgs e)
        {
            dbConnections.OpenConnection();
            try
            {
                

                string registerGroup = "INSERT INTO tb_grupos(grupo_nome,grupo_last_update) values ('"+txtGroupName.Text+"',@Time)";
                MySqlCommand cmdregisterGroup = new MySqlCommand(registerGroup, dbConnections.connection);
                DateTime dateTime = DateTime.Now;
                var dateTimeDate = DateOnly.FromDateTime(dateTime);
                cmdregisterGroup.Parameters.Add("@Time", MySqlDbType.Date).Value = dateTimeDate;
                cmdregisterGroup.ExecuteNonQuery();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Grupo registrado";
                txtGroupName.Text = "";
                dbConnections.CloseConnection();

            }
            catch
            {
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Erro";
                dbConnections.CloseConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
