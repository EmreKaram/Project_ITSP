using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalCustomer
    {
        public static List<EntityCustomer> CustomerList()
        {
            List<EntityCustomer> entityCustomers = new List<EntityCustomer>();

            SqlCommand cmd1 = new SqlCommand("Select * from Customer", Connection.connection);

            if (cmd1.Connection.State!=ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityCustomer entityCustomer = new EntityCustomer();
                entityCustomer.Id = int.Parse(dr["ID"].ToString());
                entityCustomer.Name = dr["Name"].ToString();
                entityCustomer.Surname = dr["Surname"].ToString();
                entityCustomer.Phone = dr["Phone"].ToString();
                entityCustomers.Add(entityCustomer);
            }
            dr.Close();
            return entityCustomers;
        }

        public static int AddCustomer(EntityCustomer customer)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Customer (Name,Surname,Phone) VALUES (@P1,@P2,@P3)",Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@P1", customer.Name);
            cmd2.Parameters.AddWithValue("@P2", customer.Surname);
            cmd2.Parameters.AddWithValue("@P3", customer.Phone);
            return cmd2.ExecuteNonQuery();
        }
        public static bool DeleteCustomer(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Customer where ID=@P1", Connection.connection);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P1", p);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static bool UpdateCustomer(EntityCustomer ent)
        {
            SqlCommand cmd4 = new SqlCommand("Update Customer SET Name=@P1, Surname=@P2, Phone=@P3 WHERE ID=@P4", Connection.connection);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@P1", ent.Name);
            cmd4.Parameters.AddWithValue("@P2", ent.Surname);
            cmd4.Parameters.AddWithValue("@P3", ent.Phone);
            cmd4.Parameters.AddWithValue("@P4", ent.Id);
            return cmd4.ExecuteNonQuery() > 0;
        }
        public static List<EntityCustomer> SearchCustomer(string CustomerName)
        {
            SqlCommand cmd5 = new SqlCommand("Select * from Customer WHERE Name LIKE '" + CustomerName + "%'", Connection.connection);

            List<EntityCustomer> list = new List<EntityCustomer>();

            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            SqlDataReader dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                EntityCustomer entityCustomer = new EntityCustomer();
                entityCustomer.Id = int.Parse(dr["ID"].ToString());
                entityCustomer.Name = dr["Name"].ToString();
                entityCustomer.Surname = dr["Surname"].ToString();
                entityCustomer.Phone = dr["Phone"].ToString();
                list.Add(entityCustomer);
            }
            dr.Close();
            return list;
        }
    }
}
