using System.Runtime.InteropServices;

namespace Projeto_Tabacaria.View
{
    public partial class MenuScreen : Form
    {
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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            DashboardForm dashboardForm = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardForm);
            dashboardForm.Show();
            btnDashboard.BackColor = Color.FromArgb(150, 75, 0);
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(150, 75, 0);

            this.PnlFormLoader.Controls.Clear();
            DashboardForm dashboardForm = new() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardForm);
            dashboardForm.Show();
            
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.FromArgb(150, 75, 0);
            pnlNav.Height = btnSale.Height;
            pnlNav.Top = btnSale.Top;
            pnlNav.Left = btnDashboard.Left;
            btnSale.BackColor = Color.FromArgb(150, 75, 0);

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
            btnStock.BackColor = Color.FromArgb(150, 75, 0);

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
            btnReport.BackColor = Color.FromArgb(150, 75, 0);
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCostumer.Height;
            pnlNav.Top = btnCostumer.Top;
            btnCostumer.BackColor = Color.FromArgb(150, 75, 0);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(37, 34, 9);

        }

        private void btnSale_Leave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.FromArgb(37, 34, 9);
        }

        private void btnStock_Leave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(37, 34, 9);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(37, 34, 9);
        }

        private void btnCostumer_Leave(object sender, EventArgs e)
        {
            btnCostumer.BackColor = Color.FromArgb(37, 34, 9);
        }

        private void picCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
