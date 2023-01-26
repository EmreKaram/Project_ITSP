using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DalProduct
    {
        public static List<EntityProduct> ProductList()
        {
            List<EntityProduct> entityProducts = new List<EntityProduct>();

            SqlCommand cmd1 = new SqlCommand("Select * from Product", Connection.connection);

            if (cmd1.Connection.State!=ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityProduct entityProduct = new EntityProduct();
                entityProduct.Id = int.Parse(dr["ID"].ToString());
                entityProduct.Name = dr["Name"].ToString();
                entityProduct.Price = int.Parse(dr["Price"].ToString());
                entityProduct.Quantity = int.Parse(dr["Quantity"].ToString());
                entityProduct.Company = dr["Company"].ToString();
                entityProducts.Add(entityProduct);
            }
            dr.Close();
            return entityProducts;
        }

        public static int AddProduct(EntityProduct product)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Product (Name,Price,Quantity,Company) VALUES (@P1,@P2,@P3,@P4)",Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@P1",product.Name);
            cmd2.Parameters.AddWithValue("@P2", product.Price);
            cmd2.Parameters.AddWithValue("@P3", product.Quantity);
            cmd2.Parameters.AddWithValue("@P4", product.Company);
            return cmd2.ExecuteNonQuery();
        }
        public static bool DeleteProduct(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Product where ID=@P1",Connection.connection);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P1", p);
            return cmd3.ExecuteNonQuery() > 0;
            // > 0 Yukarıdaki şartları sağlayan bir değer varsa büyüktür 0 yani 1 oda true ya denk geliyor. Bool yaptığımız için.
        }
        public static bool UpdateProduct(EntityProduct ent)
        {
            SqlCommand cmd4 = new SqlCommand("Update Product SET Name=@P1, Price=@P2, Quantity=@P3, Company=@P4 WHERE ID=@P5", Connection.connection);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@P1", ent.Name);
            cmd4.Parameters.AddWithValue("@P2", ent.Price);
            cmd4.Parameters.AddWithValue("@P3", ent.Quantity);
            cmd4.Parameters.AddWithValue("@P4", ent.Company);
            cmd4.Parameters.AddWithValue("@P5", ent.Id);
            return cmd4.ExecuteNonQuery() > 0;
        }
        public static List<EntityProduct> SearchProduct(string ProductName)
        {
            SqlCommand cmd5 = new SqlCommand("Select * from Product WHERE Name LIKE '" + ProductName + "%'",Connection.connection);

            List<EntityProduct> list = new List<EntityProduct>();

            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            SqlDataReader dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                EntityProduct entityProduct = new EntityProduct();
                entityProduct.Id = int.Parse(dr["ID"].ToString());
                entityProduct.Name = dr["Name"].ToString();
                entityProduct.Price = int.Parse(dr["Price"].ToString());
                entityProduct.Quantity = int.Parse(dr["Quantity"].ToString());
                entityProduct.Company = dr["Company"].ToString();
                list.Add(entityProduct);
            }
            dr.Close();
            return list;
        }

        public static EntityProduct ProductFindById(string id)
        {
            string query = "Select * from Product WHERE ID = " + id;

            using (SqlCommand cmd6 = new SqlCommand(query, Connection.connection))
            {
                if (cmd6.Connection.State != ConnectionState.Open)
                {
                    cmd6.Connection.Open();
                }

                var reader = cmd6.ExecuteReader();

                if (!reader.Read())
                    return null;

                EntityProduct entityProduct = new EntityProduct();
                entityProduct.Id = int.Parse(reader["ID"].ToString());
                entityProduct.Name = reader["Name"].ToString();
                entityProduct.Price = int.Parse(reader["Price"].ToString());
                entityProduct.Quantity = int.Parse(reader["Quantity"].ToString());
                entityProduct.Company = reader["Company"].ToString();

                return entityProduct;

            }
        }
    }
}
