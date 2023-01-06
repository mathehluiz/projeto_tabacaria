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

namespace Projeto_Tabacaria.View.Barcode
{
    public partial class BarcodeScreen : Form
    {
        public BarcodeScreen()
        {
            InitializeComponent();
        }

        private void btnRegBarcode_Click(object sender, EventArgs e)
        {
            RegisterBarcode registerBarcode = new RegisterBarcode();
            registerBarcode.Show();
        }

        private void btnRegBarcodeCup_Click(object sender, EventArgs e)
        {
            RegisterBarcodeCup registerBarcodeCup = new RegisterBarcodeCup();
            registerBarcodeCup.Show();
        }
    }
}
