using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using Projeto_Tabacaria.View.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tabacaria.View.Group_and_Brand
{
    public partial class GroupBrandScreen : Form
    {
        DBConnections dbConnections = new();
        public GroupBrandScreen()
        {
            InitializeComponent();
        }

        private void btnRegGroup_Click(object sender, EventArgs e)
        {
            RegisterGroup registerGroup = new RegisterGroup();
            registerGroup.Show();
        }

        private void btnRegBrand_Click(object sender, EventArgs e)
        {
            RegisterBrand registerBrand = new RegisterBrand();
            registerBrand.Show();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteGroup deleteGroup = new DeleteGroup();
            deleteGroup.Show();
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            DeleteBrand deleteBrand = new DeleteBrand();
            deleteBrand.Show();
        }

        private void dgvGroups_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {     
            dgvGroups.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroups.Columns[e.ColumnIndex] == dgvGroups.Columns["excluir"])
            {

                string Group = dgvGroups.Rows[e.RowIndex].Cells["grupo_nome"].Value.ToString();

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                try
                {
                    MySqlCommand cmdDeleteBarcode = new MySqlCommand("DELETE FROM tb_grupos WHERE grupo_nome = '" + Group + "'", dbConnections.connection);
                    cmdDeleteBarcode.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    if (MessageBox.Show("Grupo excluído", "Grupo",
          MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        picRefresh_Click(sender, e);
                    }           
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadGroups = "select grupo_nome from tb_grupos";
            MySqlDataAdapter daloadGroups = new MySqlDataAdapter(loadGroups, dbConnections.connection);
            DataTable dtloadGroups = new DataTable();
            daloadGroups.Fill(dtloadGroups);
            dgvGroups.DataSource = dtloadGroups;
            dgvGroups.Columns["grupo_nome"].HeaderText = "Grupo";

            string loadMarcas = "select marca_nome from tb_marca";
            MySqlDataAdapter daloadMarcas = new MySqlDataAdapter(loadMarcas, dbConnections.connection);
            DataTable dtloadMarcas = new DataTable();
            daloadMarcas.Fill(dtloadMarcas);
            dgvMarcas.DataSource = dtloadMarcas;
            dgvMarcas.Columns["marca_nome"].HeaderText = "Marca";
            dbConnections.CloseConnection();

        }

        private void GroupBrandScreen_Load(object sender, EventArgs e)
        {
            if (dbConnections.connection.State != ConnectionState.Open)
            {
                dbConnections.OpenConnection();
            }

            string loadGroups =  "select grupo_nome from tb_grupos";
            MySqlDataAdapter daloadGroups = new MySqlDataAdapter(loadGroups, dbConnections.connection);
            DataTable dtloadGroups = new DataTable();
            daloadGroups.Fill(dtloadGroups);
            dgvGroups.DataSource = dtloadGroups;
            dgvGroups.Columns["grupo_nome"].HeaderText = "Grupo";

            string loadMarcas = "select marca_nome from tb_marca";
            MySqlDataAdapter daloadMarcas = new MySqlDataAdapter(loadMarcas, dbConnections.connection);
            DataTable dtloadMarcas = new DataTable();
            daloadMarcas.Fill(dtloadMarcas);
            dgvMarcas.DataSource = dtloadMarcas;
            dgvMarcas.Columns["marca_nome"].HeaderText = "Marca";
            dbConnections.CloseConnection();
        }

        private void dgvMarcas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvMarcas.Rows[e.RowIndex].Cells["excluir1"].ToolTipText = "Clique aqui para excluir";

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMarcas.Columns[e.ColumnIndex] == dgvMarcas.Columns["excluir1"])
            {

                string Marca = dgvMarcas.Rows[e.RowIndex].Cells["marca_nome"].Value.ToString();

                if (dbConnections.connection.State != ConnectionState.Open)
                {
                    dbConnections.OpenConnection();
                }

                try
                {
                    MySqlCommand cmdDeleteMarca = new MySqlCommand("DELETE FROM tb_marca WHERE marca_nome = '" + Marca + "'", dbConnections.connection);
                    cmdDeleteMarca.ExecuteNonQuery();
                    dbConnections.CloseConnection();
                    if (MessageBox.Show("Marca excluída", "Marca",
          MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        picRefresh_Click(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }

        }
    }
}
