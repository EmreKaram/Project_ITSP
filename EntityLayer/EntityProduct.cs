using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityProduct
    {
        private int id;
        private string name;
        private int quantity;
        private int price;
        private string company;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Company { get => company; set => company = value; }

        public static EntityProduct From(SqlDataReader reader)
        {
            EntityProduct entityProduct = new EntityProduct
            {
                Id = int.Parse(reader["ID"].ToString()),
                Name = reader["Name"].ToString(),
                Price = int.Parse(reader["Price"].ToString()),
                Quantity = int.Parse(reader["Quantity"].ToString()),
                Company = reader["SalesProductComapny"].ToString(),
            };

            return entityProduct;

        }
    }
}
