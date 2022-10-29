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

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class DeteCup : Form
    {
        DBConnections dbConnections = new();
        public DeteCup()
        {
            InitializeComponent();
        }

        private void DeteCup_Load(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            string queryCups = "select unidade_nome from tb_unidade";
            MySqlDataAdapter da = new MySqlDataAdapter(queryCups, dbConnections.connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_unidade");
            this.cmbCupName.DisplayMember = "unidade_nome";
            this.cmbCupName.ValueMember = "cod_unidade";
            this.cmbCupName.DataSource = ds.Tables["tb_unidade"];
            dbConnections.CloseConnection();
        }

        private void mnButton1_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }
            try
            {
                MySqlCommand cmd_delete_product = new MySqlCommand("DELETE FROM tb_unidade WHERE unidade_nome = '" + cmbCupName.Text + "'", dbConnections.connection);
                cmd_delete_product.CommandType = CommandType.Text;
                cmd_delete_product.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Copo deletado";
                this.Refresh();
                cmbCupName.Text = "";
                System.Threading.Thread.Sleep(2);
                DeteCup_Load(sender, e);

            }
            catch
            {
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Erro";
            }
            dbConnections.CloseConnection();
        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
