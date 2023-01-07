using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System.Data;

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
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string selectGroupsNames = "select grupo_nome from tb_grupos where grupo_nome = '" + txtGroupName.Text + "'";
            MySqlCommand cmdselectGroupsNames = new MySqlCommand(selectGroupsNames, dbConnections.connection);
            var consultGroups = cmdselectGroupsNames.ExecuteScalar();

            if (consultGroups == null) 
            {
                try
                {


                    string registerGroup = "INSERT INTO tb_grupos(grupo_nome,grupo_last_update) values ('" + txtGroupName.Text + "',@Time)";
                    MySqlCommand cmdregisterGroup = new MySqlCommand(registerGroup, dbConnections.connection);
                    DateTime dateTime = DateTime.Now;
                    var dateTimeDate = DateOnly.FromDateTime(dateTime);
                    cmdregisterGroup.Parameters.Add("@Time", MySqlDbType.Date).Value = dateTimeDate;
                    cmdregisterGroup.ExecuteNonQuery();
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Grupo registrado";
                    txtGroupName.Text = "";
                    dbConnections.CloseConnection();
                    txtGroupName.Focus();
                    txtGroupName.Select();

                }
                catch
                {
                    lblReturnDB.Visible = true;
                    lblReturnDB.Text = "Erro";
                    dbConnections.CloseConnection();
                }

            }
            else
            {
                MessageBox.Show("Este grupo já está registrado");
                txtGroupName.Text = "";
                txtGroupName.Focus();
                txtGroupName.Select();
                dbConnections.CloseConnection();
            }
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bntRegGroup_Click(sender, e);
            }
        }
    }

}
