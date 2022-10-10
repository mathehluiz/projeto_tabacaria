﻿using Projeto_Tabacaria.View.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Tabacaria.View
{
    public partial class InventoryScreen : Form
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
        public InventoryScreen()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {

            RegisterProduct registerProduct = new RegisterProduct();
            registerProduct.FormBorderStyle = FormBorderStyle.None;
            registerProduct.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new();
            editProduct.FormBorderStyle = FormBorderStyle.None;
            editProduct.Show();
        }
    }
}