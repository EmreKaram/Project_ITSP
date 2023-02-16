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
    public class DalUser
    {
        public static List<EntityUser> UserList()
        {
            List<EntityUser> entityUsers = new List<EntityUser>();

            SqlCommand cmd1 = new SqlCommand("Select * from [User]", Connection.connection);

            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityUser entityUser = new EntityUser();
                entityUser.Id = int.Parse(dr["ID"].ToString());
                entityUser.UserName = dr["UserName"].ToString();
                entityUser.UserPassword = dr["UserPassword"].ToString();
                entityUser.UserType = dr["UserType"].ToString();
                entityUsers.Add(entityUser);
            }
            dr.Close();
            return entityUsers;
        }

        public static int AddUser(EntityUser user)
        {
            SqlCommand cmd2 = new SqlCommand("insert into [User] (UserName,UserPassword,UserType) VALUES (@P1,@P2,@P3)", Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@P1", user.UserName);
            cmd2.Parameters.AddWithValue("@P2", user.UserPassword);
            cmd2.Parameters.AddWithValue("@P3", user.UserType);
            return cmd2.ExecuteNonQuery();
        }

        public static bool DeleteUser(int u)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from [User] where ID=@P1", Connection.connection);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P1", u);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static bool UpdateUser(EntityUser ent)
        {
            SqlCommand cmd4 = new SqlCommand("Update [User] SET UserName=@P1, UserPassword=@P2,UserType=@P3 WHERE ID=@P4", Connection.connection);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@P1", ent.UserName);
            cmd4.Parameters.AddWithValue("@P2", ent.UserPassword);
            cmd4.Parameters.AddWithValue("@P3", ent.UserType);
            cmd4.Parameters.AddWithValue("@P4", ent.Id);
            return cmd4.ExecuteNonQuery() > 0;
        }
        public static List<EntityUser> SearchUser(string UserName)
        {
            SqlCommand cmd5 = new SqlCommand("Select * from [User] WHERE UserName LIKE '" + UserName + "%'", Connection.connection);

            List<EntityUser> list = new List<EntityUser>();

            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            SqlDataReader dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                EntityUser entityUser = new EntityUser();
                entityUser.Id = int.Parse(dr["ID"].ToString());
                entityUser.UserName = dr["UserName"].ToString();
                entityUser.UserPassword = dr["UserPassword"].ToString();
                entityUser.UserType = dr["UserType"].ToString();
                list.Add(entityUser);
            }
            dr.Close();
            return list;
        }
        public static EntityUser findByUserName(string UserName)
        {
            SqlCommand cmd6 = new SqlCommand("Select * from [User] WHERE UserName = @P1", Connection.connection);
            if (cmd6.Connection.State != ConnectionState.Open)
            {
                cmd6.Connection.Open();
            }
            cmd6.Parameters.AddWithValue("@P1", UserName);
            SqlDataReader dr = cmd6.ExecuteReader();


            while (dr.Read())
            {
                if (dr["ID"] != DBNull.Value)
                {
                    EntityUser user = new EntityUser();
                    user = EntityUser.From(dr);
                    dr.Close();
                    return user;
                }
            }
            dr.Close();
            return null;
        }

    }
}
