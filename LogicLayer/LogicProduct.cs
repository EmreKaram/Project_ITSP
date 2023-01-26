using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicProduct
    {
        public static List<EntityProduct> LogicLayerProductList()
        {
            return DalProduct.ProductList();
        }
        public static int LogicLayerProductAdd(EntityProduct product)
        {
            if (product.Name!=""/*Koşullar buraya*/)
            {
                return DalProduct.AddProduct(product);
            }
            else
            {
                return -1;
            }
        }
        public static bool LogicLayerProductDelete(int p)
        {
            if (p >= 1)
            {
                return DalProduct.DeleteProduct(p);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerProductUpdate(EntityProduct ent)
        {
            if (ent.Name!="")
            {
                return DalProduct.UpdateProduct(ent);
            }
            else
            {
                return false;
            }
        }
        public static List<string> FillCompanyBox()
        {
            List<EntityCompany> companies = DalCompany.CompanyList();
            List<string> names = new List<string>();
            foreach (EntityCompany company in companies)
            {
                names.Add(company.Name);
            }
            return names;
        }
        public static List<EntityProduct> LogicLayerSearchProduct(string ProductName)
        {
            return DalProduct.SearchProduct(ProductName);
        }
    }
}
