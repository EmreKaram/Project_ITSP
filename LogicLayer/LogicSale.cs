using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Windows.Forms;
using MySqlConnector;

namespace LogicLayer
{
    public class LogicSale
    {
        public static List<EntitySale> LogicLayerSaleList()
        {
            return DalSale.SaleList();
        }
        public static bool LogicLayerSaleDelete(int s)
        {
            if (s >= 1)
            {
                return DalSale.DeleteSale(s);
            }
            else
            {
                return false;
            }
        }
        public static int makeSale(EntitySale sale)
        {
            EntityProduct product = DalProduct.ProductFindById(sale.SalesProductId.ToString());
            if (product != null)
            {
                int quantitySold = sale.SalesQuantitySold;
                int quantityAvailable = product.Quantity;
                int total = quantityAvailable - quantitySold;
                if(total >= 0)
                {
                    product.Quantity = total;
                    DalProduct.UpdateProduct(product);
                    DalSale.AddSale(sale);
                } else
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
            return 0;
        }

        public static EntitySale dataRowToEntitySale (DataGridViewRow viewRow)
        {
            EntitySale entitySale = new EntitySale
            {
                Id = int.Parse(viewRow.Cells[0].Value.ToString()),
                SalesProductId = int.Parse(viewRow.Cells[1].Value.ToString()),
                SalesProductName = viewRow.Cells[2].Value.ToString(),
                SalesProductCompany = viewRow.Cells[3].Value.ToString(),
                SalesQuantitySold = int.Parse(viewRow.Cells[4].Value.ToString()),
                SalesCustomerId = int.Parse(viewRow.Cells[5].Value.ToString()),
                SalesTotalEarning = int.Parse(viewRow.Cells[6].Value.ToString())
            };

            return entitySale;
        }

        public static int calculateTotalPrice(int amountIndex, int priceIndex, ListView.ListViewItemCollection listView)
        {
            int totalAmount = 0;
            foreach (ListViewItem item in listView)
            {
                totalAmount += int.Parse(item.SubItems[priceIndex].Text) * int.Parse(item.SubItems[amountIndex].Text);
            }
            return totalAmount;

        }

        public static int calculateTotalQuantity(int amountIndex, ListView.ListViewItemCollection listView)
        {
            int totalAmount = 0;
            foreach (ListViewItem item in listView)
            {
                totalAmount += int.Parse(item.SubItems[amountIndex].Text);
            }
            return totalAmount;

        }

        public static bool LogicLayerSaleCartContains(string itemID, ListView.ListViewItemCollection listView)
        {
            foreach (ListViewItem item in listView)
            {
                if (item.SubItems[0].Text.Equals(itemID))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

