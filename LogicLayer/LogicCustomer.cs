using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicCustomer
    {
        public static List<EntityCustomer> LogicLayerCustomerList()
        {
            return DalCustomer.CustomerList();
        }
        public static int LogicLayerCustomerAdd(EntityCustomer customer)
        {
            if (customer.Name!="")
            {
                return DalCustomer.AddCustomer(customer);
            }
            else
            {
                return -1;
            }
        }
        public static bool LogicLayerCustomerDelete(int c)
        {
            if (c >= 1)
            {
                return DalCustomer.DeleteCustomer(c);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerCustomerUpdate(EntityCustomer ent)
        {
            if (ent.Name.Length >= 3)
            {
                return DalCustomer.UpdateCustomer(ent);
            }
            else
            {
                return false;
            }
        }
        public static List<EntityCustomer> LogicLayerCustomerSearch(string CustomerName)
        {
            return DalCustomer.SearchCustomer(CustomerName);
        }
    }
}
