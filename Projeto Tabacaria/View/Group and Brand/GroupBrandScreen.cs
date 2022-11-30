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
    }
}
