using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using Projeto_Tabacaria.View.Group_and_Brand;
using System.Runtime.InteropServices;

namespace Projeto_Tabacaria.View
{
    public partial class MenuScreen : Form
    {
        DBConnections dbConnections = new DBConnections();
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

        public MenuScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            DashboardForm dashboardForm = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            this.PnlFormLoader.Controls.Add(dashboardForm);
            dashboardForm.Show();


            dbConnections.OpenConnection();
            string selectUser = "Select Nome from tb_user";
            MySqlCommand cmdSelectUser = new MySqlCommand(selectUser, dbConnections.connection);
            MySqlDataReader readerUser;
            readerUser = cmdSelectUser.ExecuteReader();
            readerUser.Read();
            lblUsername.Text = readerUser.GetString(0);
            dbConnections.CloseConnection();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            DashboardForm dashboardForm = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardForm);
            dashboardForm.Show(); 
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSale.Height;
            pnlNav.Top = btnSale.Top;
            btnSale.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            SaleForm saleForm = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            saleForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(saleForm);
            saleForm.Show();
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStock.Height;
            pnlNav.Top = btnStock.Top;
            btnStock.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            InventoryScreen iventoryScreen = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            iventoryScreen.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(iventoryScreen);
            iventoryScreen.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReport.Height;
            pnlNav.Top = btnReport.Top;
            btnReport.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCostumer.Height;
            pnlNav.Top = btnCostumer.Top;
            btnCostumer.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            CostumerScreen clienteScreen = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            clienteScreen.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(clienteScreen);
            clienteScreen.Show();
            
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnSale_Leave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStock_Leave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCostumer_Leave(object sender, EventArgs e)
        {
            btnCostumer.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void picCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGroupAndBrand_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStock.Height;
            pnlNav.Top = btnStock.Top;
            btnStock.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            GroupBrandScreen groupbrandScreen = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            groupbrandScreen.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(groupbrandScreen);
            groupbrandScreen.Show();

        }
    }
}
