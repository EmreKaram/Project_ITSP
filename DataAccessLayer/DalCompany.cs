using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalCompany
    {
        public static List<EntityCompany> CompanyList()
        {
            List<EntityCompany> entityCompanies = new List<EntityCompany>();

            SqlCommand cmd1 = new SqlCommand("Select * from Company", Connection.connection);

            if (cmd1.Connection.State!= ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityCompany entityCompany = new EntityCompany();
                entityCompany.Id = int.Parse(dr["ID"].ToString());
                entityCompany.Name = dr["Name"].ToString();
                entityCompany.Phone = dr["Phone"].ToString();
                entityCompany.Descr = dr["Descr"].ToString();
                entityCompanies.Add(entityCompany);
            }
            dr.Close();
            return entityCompanies;
        }

        public static int AddCompany(EntityCompany company)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Company (Name,Phone,Descr) VALUES (@P1,@P2,@P3)",Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@P1", company.Name);
            cmd2.Parameters.AddWithValue("@P2", company.Phone);
            cmd2.Parameters.AddWithValue("@P3", company.Descr);
            return cmd2.ExecuteNonQuery();
        }
        public static bool DeleteCompany(int c)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Company where ID=@P1", Connection.connection);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P1", c);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static bool UpdateCompany(EntityCompany ent)
        {
            SqlCommand cmd4 = new SqlCommand("Update Company SET Name=@P1, Phone=@P2, Descr=@P3 WHERE ID=@P4", Connection.connection);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@P1", ent.Name);
            cmd4.Parameters.AddWithValue("@P2", ent.Phone);
            cmd4.Parameters.AddWithValue("@P3", ent.Descr);
            cmd4.Parameters.AddWithValue("@P4", ent.Id);
            return cmd4.ExecuteNonQuery() > 0;
        }
        public static List<EntityCompany> SearchCompany(string CompanyName)
        {
            SqlCommand cmd5 = new SqlCommand("Select * from Company WHERE Name LIKE '" + CompanyName + "%'", Connection.connection);

            List<EntityCompany> list = new List<EntityCompany>();

            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            SqlDataReader dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                EntityCompany entityCompany = new EntityCompany();
                entityCompany.Id = int.Parse(dr["ID"].ToString());
                entityCompany.Name = dr["Name"].ToString();
                entityCompany.Phone = dr["Phone"].ToString();
                entityCompany.Descr = dr["Descr"].ToString();
                list.Add(entityCompany);
            }
            dr.Close();
            return list;
        }
    }
}
