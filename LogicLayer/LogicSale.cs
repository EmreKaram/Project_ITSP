using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Windows.Forms;

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
        public static int LogicLayerSaleAdd(EntitySale sale)
        {
            if (sale.SalesCustomerId > -1)
            {
                return DalSale.AddSale(sale);
            }
            else
            {
                return -1;
            }
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
        public static String LogicLayerSaleMakeSale(ListView.ListViewItemCollection listView)

            MySqlConnection mySqlConnection = new MySqlConnection(CONNECTION_STRING);
            mySqlConnection.Open();
            List<string> queryList = new List<string>();
            bool failed = false;

            foreach (ListViewItem item in listView)
            {
                if (failed) break;

                string selectQuery = "select ProductQuantity from Product where ProductID = " + item.SubItems[0].Text;
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, mySqlConnection);
                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int pq = Int32.Parse(reader.GetString(0));
                        int iq = Int32.Parse(item.SubItems[2].Text);
                        int total = (pq - iq);
                        if (total < 0)
                        {
                            MessageBox.Show(item.SubItems[1].Text + " İsimli ürün'den elinizde yeteri kadar yoktur! ", "Stok yok!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            failed = true;
                            break;
                        }
                        else
                        {
                            string updateQuery = "UPDATE Product SET ProductQuantity = '" + total + "' WHERE ProductID = " + item.SubItems[0].Text;
                            queryList.Add(updateQuery);

                        }
                    }
                }
            }
            if (!failed)
            {
                foreach (String query in queryList)
                {
                    MySqlCommand updateCmd = new MySqlCommand(query, mySqlConnection);
                    updateCmd.ExecuteNonQuery();
                }

                UpdateSalesData();
                lviBasket.Items.Clear();
                mySqlConnection.Close();
            }
        }
        UpdateBasketCost();
        lviCustomer.Items.Clear();
    }
}
