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
    }
}

