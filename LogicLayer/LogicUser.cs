using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace LogicLayer
{
    public class LogicUser
    {
        public static List<EntityUser> LogicLayerUserList()
        {
            return DalUser.UserList();
        }
        public static int LogicLayerUserAdd(EntityUser user)
        {
            if (user.UserName!="" && DalUser.findByUserName(user.UserName) == null)
            {
                return DalUser.AddUser(user);
            }
            else
            {
                return -1;
            }
        }
        public static bool LogicLayerUserDelete(int u)
        {
            if(u >= 1)
            {
                return DalUser.DeleteUser(u);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerUserUpdate(EntityUser ent)
        {
            if (ent.UserType == "admin" || ent.UserType =="user")
            {
                return DalUser.UpdateUser(ent);
            }
            else
            {
                return false;
            }
        }
        public static List<EntityUser> LogicLayerSearchUser(string UserName)
        {
            return DalUser.SearchUser(UserName);
        }
        public static EntityUser Login(string username, string password)
        {
            EntityUser user = DalUser.findByUserName(username);
            if (user != null)
            {
                if (user.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
