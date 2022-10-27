using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tabacaria.View.Client
{
    public partial class RegisterCostumer : Form
    {
        DBConnections dbConnections = new();
        public RegisterCostumer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }
                string registerClient = "insert into tb_clientes(cli_nome,cli_telefone) values (@Nome,@Telefone)";
                MySqlCommand cmdRegisterClient = new MySqlCommand(registerClient,dbConnections.connection);
                cmdRegisterClient.Parameters.Add("@Nome", MySqlDbType.VarChar, 100).Value = txtNameClient.Texts;
                cmdRegisterClient.Parameters.Add("@Telefone", MySqlDbType.VarChar, 25).Value = txtPhoneClient.Texts;
                cmdRegisterClient.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Cliente registrado!";
            }
            catch
            {
                lblReturnDB.Text = "Não foi possivel registrar o cliente";
                dbConnections.CloseConnection();
            }
        }

        private void RegisterCostumer_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
        }
    }
}
