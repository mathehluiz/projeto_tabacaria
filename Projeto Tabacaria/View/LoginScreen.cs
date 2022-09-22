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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    }
}