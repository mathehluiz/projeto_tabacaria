using System.Runtime.InteropServices;

namespace Projeto_Tabacaria.View
{
    public partial class RegisterProduct : Form
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
        public RegisterProduct()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuyValue_Leave(object sender, EventArgs e)
        {
            int a = txtQtd.Texts != "" ? Convert.ToInt32(txtQtd.Texts) : 0;
            int b = txtBuyValue.Texts != "" ? Convert.ToInt32(txtBuyValue.Texts) : 0;
            int total = a * b;

            txtTotal.Texts = total.ToString();
        }
    }
}