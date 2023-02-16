using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityUser
    {
        private int id;
        private string userName;
        private string userPassword;
        private string userType;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserType { get => userType; set => userType = value; }

        public static EntityUser From(SqlDataReader reader)
        {
            EntityUser entityUser = new EntityUser
            {
                Id = int.Parse(reader["ID"].ToString()),
                UserName = reader["UserName"].ToString(),
                UserPassword = reader["UserPassword"].ToString(),
                UserType = reader["UserType"].ToString()
            };
            return entityUser;
        }
    }
}
