using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DBIFAP;Integrated Security=True");
    }
}
