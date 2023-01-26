using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;
using Microsoft.VisualBasic;

namespace IFAP_FINAL
{
    public partial class UC_Sale : UserControl
    {
        public UC_Sale()
        {
            InitializeComponent();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            List<EntityProduct> productList = LogicProduct.LogicLayerProductList();
            dgvProduct.DataSource = productList;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            List<EntityCustomer> customerList = LogicCustomer.LogicLayerCustomerList();
            dgvCustomer.DataSource = customerList;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pID = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            bool doesExistInCart = LogicSale.LogicLayerSaleCartContains(pID, lviBasket.Items);
            if (!doesExistInCart)
            {
                string SaleAmount = Interaction.InputBox("Satış Adeti: ", "Satış Ekranı", "");
                if(!string.IsNullOrWhiteSpace(SaleAmount) && int.TryParse(SaleAmount, out int value))
                {
                    string pName = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
                    string pPrice = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
                    string pCompany = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();
                    string[] row = { pID, pName, SaleAmount, pPrice, pCompany };
                    var ListViewItem = new ListViewItem(row);
                    lviBasket.Items.Add(ListViewItem);
                }
                else
                {
                    MessageBox.Show("Boş veya harfsel değer giremezsiniz!", "Geçersiz Değer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lviCustomer.Items.Count == 0)
            {
                string cID = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                string cName = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                string cSurname = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                string cPhone = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                string[] row = { cID, cName, cSurname, cPhone };
                var ListViewItem = new ListViewItem(row);
                lviCustomer.Items.Add(ListViewItem);
            }
            else
            {
                MessageBox.Show("Birden fazla müşteri seçemezsiniz!");
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            lviCustomer.Items.Clear();
            lviCustomer.Refresh(); //Emin olmak için lviCustomer a refresh atıyoruz.
        }

        private void btnSaleSold_Click(object sender, EventArgs e)
        {
            if (lviBasket.Items.Count == 0)
            {
                MessageBox.Show("Sepet boş", "Ürün seçin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (lviCustomer.Items.Count == 0)
            {
                MessageBox.Show("Lütfen müşteri seçiniz!", "Müşteri seçin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog = MessageBox.Show("Satışı Onaylıyor musunuz ?", "Satışı Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

            }

                DialogResult dialog = MessageBox.Show("Satışı Onaylıyor musunuz ?", "Satışı Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (lviBasket.Items.Count == 0)
            //{
            //    MessageBox.Show("Sepet boş!", "Ürün seçiniz.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    return;
            //}
            //if (lviCustomer.Items.Count == 0)
            //{
            //    MessageBox.Show("Müşteri seçilmedi!", "Müşteri seçiniz.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    return;
            //}

            //EntitySale sale = new EntitySale();

            //sale.SalesProductId = int.Parse(lviBasket.Items[0].SubItems[0].Text);
            //sale.SalesProductName = lviBasket.Items[0].SubItems[1].Text;
            //sale.SalesProductCompany = lviBasket.Items[0].SubItems[4].Text;
            //sale.SalesCustomerId = int.Parse(lviCustomer.Items[0].SubItems[0].Text);
            //sale.SalesTotalEarning = int.Parse(lblTotalPrice.Text);
            //sale.SalesQuantitySold = 1;
            //LogicSale.LogicLayerSaleAdd(sale);
            //MessageBox.Show("Satış başarılı!");
        }

        private void lviBasket_DoubleClick(object sender, EventArgs e)
        {
            string newSalesAmount = Interaction.InputBox("Yeni satış adeti: ", "Satış Adetini Düzenle", "");

            if (!string.IsNullOrWhiteSpace(newSalesAmount) && int.TryParse(newSalesAmount, out int value))
            {
                lviBasket.SelectedItems[0].SubItems[2].Text = newSalesAmount;
            }
            else
            {
                MessageBox.Show("Boş veya harfsel değer giremezsin!", "Geçersiz değer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
