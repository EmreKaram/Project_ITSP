using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalSale
    {
        public static List<EntitySale> SaleList()
        {
            List<EntitySale> entitySales = new List<EntitySale>();

            SqlCommand cmd1 = new SqlCommand("Select * from Sales",Connection.connection);
            if (cmd1.Connection.State!=ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntitySale entitySale = new EntitySale();
                entitySale.Id = int.Parse(dr["ID"].ToString());
                entitySale.SalesProductName = dr["SalesProductName"].ToString();
                entitySale.SalesProductCompany = dr["SalesProductCompany"].ToString();
                entitySale.SalesCustomerId = int.Parse(dr["SalesCustomerID"].ToString());
                entitySale.SalesProductId = int.Parse(dr["SalesProductID"].ToString());
                entitySale.SalesTotalEarning = int.Parse(dr["SalesTotalEarning"].ToString());
                entitySale.SalesQuantitySold = int.Parse(dr["SalesQuantitySold"].ToString());
                entitySales.Add(entitySale);
            }
            dr.Close();
            return entitySales;
        }

        public static bool DeleteSale(int s)
        {
            SqlCommand cmd2 = new SqlCommand("Delete from Sales where ID=@P1", Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@P1", s);
            return cmd2.ExecuteNonQuery() > 0;
        }

        public static int AddSale(EntitySale sale)
        {
            SqlCommand cmd3 = new SqlCommand("insert into Sales (SalesProductID,SalesProductName,SalesProductCompany,SalesQuantitySold,SalesCustomerId,SalesTotalEarning) VALUES (@P4,@P5,@P6,@P7,@P8,@P9)",Connection.connection);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P4", sale.SalesProductId);
            cmd3.Parameters.AddWithValue("@P5", sale.SalesProductName);
            cmd3.Parameters.AddWithValue("@P6", sale.SalesProductCompany);
            cmd3.Parameters.AddWithValue("@P7", sale.SalesQuantitySold);
            cmd3.Parameters.AddWithValue("@P8", sale.SalesCustomerId);
            cmd3.Parameters.AddWithValue("@P9", sale.SalesTotalEarning);
            return cmd3.ExecuteNonQuery();
        }
    }
}
