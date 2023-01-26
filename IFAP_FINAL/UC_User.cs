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
using DataAccessLayer;

namespace IFAP_FINAL
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<EntityUser> userList = LogicUser.LogicLayerUserList();
            dgvUser.DataSource = userList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntityUser entity = new EntityUser();
            entity.UserName = txtUsername.Text;
            entity.UserPassword = txtUserpassword.Text;
            entity.UserType = cmbUsertype.Text;
            LogicUser.LogicLayerUserAdd(entity);
            List<EntityUser> userList = LogicUser.LogicLayerUserList();
            dgvUser.DataSource = userList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityUser ent = new EntityUser();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.UserName = txtUsername.Text;
            ent.UserPassword = txtUserpassword.Text;
            ent.UserType = cmbUsertype.Text;
            LogicUser.LogicLayerUserUpdate(ent);
            List<EntityUser> userList = LogicUser.LogicLayerUserList();
            dgvUser.DataSource = userList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityUser ent = new EntityUser();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicUser.LogicLayerUserDelete(ent.Id);
            List<EntityUser> userList = LogicUser.LogicLayerUserList();
            dgvUser.DataSource = userList;
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            txtUsername.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtUserpassword.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            cmbUsertype.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntityUser user = new EntityUser();
            user.UserName = txtSearch.Text;
            dgvUser.DataSource = LogicUser.LogicLayerSearchUser(txtSearch.Text);
        }
    }
}
