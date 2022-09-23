using Projeto_Tabacaria.View;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace Projeto_Tabacaria
{
    public partial class LoginScreen : Form
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
            MenuScreen dashboardScreen = new();
            dashboardScreen.Show();
            this.Dispose();
        }
    }
}