using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tabacaria.View.Costumer
{
    public partial class DebitPaymentCostumer : Form
    {
        DBConnections dbConnections = new();
        public DebitPaymentCostumer(string name, string total)
        {
           

            InitializeComponent();
            txtNameCostumer.ReadOnly = true;
            txtTotalDebit.ReadOnly = true;
            txtTotalDebit.Enabled = false;
            txtNameCostumer.Text = name;
            txtTotalDebit.Text = total;
        }

        private void DebitPaymentCostumer_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            txtNameCostumer.Enabled = false;


        }

        private void picCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayDebit_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(txtTotalDebit.Text) - Convert.ToDecimal(txtTotalPay.Text);
            string result = total.ToString().Replace(",", ".");
           
            dbConnections.OpenConnection();
            if(total < 0)
            {
                MessageBox.Show("Pagamento maior que a dívida");
                txtTotalPay.Text = "";
                dbConnections.CloseConnection();
            }
            else
            {
                string selectCodClient = "Select cli_cod from tb_clientes where cli_nome = '" + txtNameCostumer.Text + "'";
                MySqlCommand cmdselectCodClient = new MySqlCommand(selectCodClient, dbConnections.connection);
                int codClient = Convert.ToInt32(cmdselectCodClient.ExecuteScalar());

                string querySaveDebit = "UPDATE tb_clientes set cli_total = '"+ result + "' where cli_cod = '"+codClient+"'";
                MySqlCommand cmdquerySaveDebit = new MySqlCommand(querySaveDebit, dbConnections.connection);
                cmdquerySaveDebit.ExecuteNonQuery();
                dbConnections.CloseConnection();
                lblReturnDB.Visible = true;
                lblReturnDB.Text = "Debitado";

            }

        }

        private void txtTotalDebit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotalDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTotalPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
