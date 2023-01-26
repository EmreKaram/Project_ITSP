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
    public partial class UC_Company : UserControl
    {
        public UC_Company()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<EntityCompany> companyList = LogicCompany.LogicLayerCompanyList();
            dgvCompany.DataSource = companyList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityCompany ent = new EntityCompany();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicCompany.LogicLayerCompanyDelete(ent.Id);
            List<EntityCompany> companyList = LogicCompany.LogicLayerCompanyList();
            dgvCompany.DataSource = companyList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntityCompany entity = new EntityCompany();
            entity.Name = txtName.Text;
            entity.Phone = mtxtPhone.Text;
            entity.Descr = rtxtDesc.Text;
            LogicCompany.LogicLayerCompanyAdd(entity);
            List<EntityCompany> companyList = LogicCompany.LogicLayerCompanyList();
            dgvCompany.DataSource = companyList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityCompany ent = new EntityCompany();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Name = txtName.Text;
            ent.Phone = mtxtPhone.Text;
            ent.Descr = rtxtDesc.Text;
            LogicCompany.LogicLayerCompanyUpdate(ent);
            List<EntityCompany> companyList = LogicCompany.LogicLayerCompanyList();
            dgvCompany.DataSource = companyList;
        }

        private void dgvCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCompany.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvCompany.SelectedRows[0].Cells[1].Value.ToString();
            mtxtPhone.Text = dgvCompany.SelectedRows[0].Cells[2].Value.ToString();
            rtxtDesc.Text = dgvCompany.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntityCompany company = new EntityCompany();
            company.Name = txtSearch.Text;
            dgvCompany.DataSource = LogicCompany.LogicLayerCopmanySearch(txtSearch.Text);
        }
    }
}
