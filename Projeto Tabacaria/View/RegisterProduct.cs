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

        private void txtQtd__TextChanged(object sender, EventArgs e)
        {
            double a = txtQtd.Texts != "" ? Convert.ToDouble(txtQtd.Texts) : 0;
            double b = txtBuyValue.Texts != "" ? Convert.ToDouble(txtBuyValue.Texts) : 0;
            double total = a * b;

            txtTotal.Texts = "R$ " + total.ToString();
        }

        private void txtBuyValue__TextChanged(object sender, EventArgs e)
        {
            double a = txtQtd.Texts != "" ? Convert.ToDouble(txtQtd.Texts) : 0;
            double b = txtBuyValue.Texts != "" ? Convert.ToDouble(txtBuyValue.Texts) : 0;
            double total = a * b;
            total = (double)System.Math.Round(total, 2);

            txtTotal.Texts = "R$ " + total.ToString();
        }
    }
}