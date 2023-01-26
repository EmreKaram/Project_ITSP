using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicCompany
    {
        public static List<EntityCompany> LogicLayerCompanyList()
        {
            return DalCompany.CompanyList();
        }
        public static int LogicLayerCompanyAdd(EntityCompany company)
        {
            if (company.Name!="")
            {
                return DalCompany.AddCompany(company);
            }
            else
            {
                return -1;
            }
        }
        public static bool LogicLayerCompanyDelete(int c)
        {
            if  (c >= 1)
            {
                return DalCompany.DeleteCompany(c);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerCompanyUpdate(EntityCompany ent)
        {
            if (ent.Name!="")
            {
                return DalCompany.UpdateCompany(ent);
            }
            else
            {
                return false;
            }
        }
        public static List<EntityCompany> LogicLayerCopmanySearch(string CompanyName)
        {
            return DalCompany.SearchCompany(CompanyName);
        }
    }
}
