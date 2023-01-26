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
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
            cmbCompany.DataSource = LogicProduct.FillCompanyBox();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<EntityProduct> productList = LogicProduct.LogicLayerProductList();
            dgvProduct.DataSource = productList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntityProduct entity = new EntityProduct();
            entity.Name = txtName.Text;
            entity.Quantity = int.Parse(txtQuantity.Text);
            entity.Price = int.Parse(txtPrice.Text);
            entity.Company = cmbCompany.Text;
            LogicProduct.LogicLayerProductAdd(entity);
            List<EntityProduct> productList = LogicProduct.LogicLayerProductList();
            dgvProduct.DataSource = productList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityProduct ent = new EntityProduct();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Name = txtName.Text;
            ent.Quantity = int.Parse(txtQuantity.Text);
            ent.Price = int.Parse(txtPrice.Text);
            ent.Company = cmbCompany.Text;
            LogicProduct.LogicLayerProductUpdate(ent);
            List<EntityProduct> productList = LogicProduct.LogicLayerProductList();
            dgvProduct.DataSource = productList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityProduct ent = new EntityProduct();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicProduct.LogicLayerProductDelete(ent.Id);
            List<EntityProduct> productList = LogicProduct.LogicLayerProductList();
            dgvProduct.DataSource = productList;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            cmbCompany.Text = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntityProduct product = new EntityProduct();
            product.Name = txtSearch.Text;
            dgvProduct.DataSource = LogicProduct.LogicLayerSearchProduct(txtSearch.Text);
        }
    }
}
