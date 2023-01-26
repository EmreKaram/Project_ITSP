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
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntityCustomer customer = new EntityCustomer();
            customer.Name = txtSearch.Text;
            dgvCustomer.DataSource = LogicCustomer.LogicLayerCustomerSearch(txtSearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityCustomer ent = new EntityCustomer();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Name = txtName.Text;
            ent.Surname = txtSurname.Text;
            ent.Phone = mtxtPhone.Text;
            LogicCustomer.LogicLayerCustomerUpdate(ent);
            List<EntityCustomer> customerList = LogicCustomer.LogicLayerCustomerList();
            dgvCustomer.DataSource = customerList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityCustomer ent = new EntityCustomer();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicCustomer.LogicLayerCustomerDelete(ent.Id);
            List<EntityCustomer> customerList = LogicCustomer.LogicLayerCustomerList();
            dgvCustomer.DataSource = customerList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntityCustomer entity = new EntityCustomer();
            entity.Name = txtName.Text;
            entity.Surname = txtSurname.Text;
            entity.Phone = mtxtPhone.Text;
            LogicCustomer.LogicLayerCustomerAdd(entity);
            List<EntityCustomer> customerList = LogicCustomer.LogicLayerCustomerList();
            dgvCustomer.DataSource = customerList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<EntityCustomer> customerList = LogicCustomer.LogicLayerCustomerList();
            dgvCustomer.DataSource = customerList;
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtSurname.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            mtxtPhone.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
