using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;
   

namespace IFAP_FINAL
{
    public partial class Login_SignUpcs : Form
    {
        public Login_SignUpcs()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EntityUser user = LogicUser.Login(txtLoginUsername.Text, txtLoginPassword.Text);
            if (user != null)
            {
                if (user.UserType == "user")
                {
                    User userForm = new User();
                    userForm.Show();
                } 
                else
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();

                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            EntityUser entity = new EntityUser();
            entity.UserName = txtSignUsername.Text;
            entity.UserPassword = txtSignPassword.Text;
            entity.UserType = "user";
            LogicUser.LogicLayerUserAdd(entity);
        }
    }
}
