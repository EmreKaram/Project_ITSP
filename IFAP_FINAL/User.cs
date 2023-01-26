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
    public partial class User : Form
    {
        public User()
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

        private void btnSale_Click(object sender, EventArgs e)
        {
            UC_Sale uC_Sale = new UC_Sale();
            addUserControl(uC_Sale);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customer uC_Customer = new UC_Customer();
            addUserControl(uC_Customer);
        }
    }
}
