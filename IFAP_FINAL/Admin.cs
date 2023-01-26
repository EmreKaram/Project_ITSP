using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFAP_FINAL
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UC_User uC_User = new UC_User();
            addUserControl(uC_User);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            UC_Product uC_Product = new UC_Product();
            addUserControl(uC_Product);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            UC_Company uC_Company = new UC_Company();
            addUserControl(uC_Company);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customer uC_Customer = new UC_Customer();
            addUserControl(uC_Customer);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            UC_Sale uC_Sale = new UC_Sale();
            addUserControl(uC_Sale);
        }
    }
}
