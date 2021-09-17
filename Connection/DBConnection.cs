using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebapiCurd.Connection
{
    public class DBConnection
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection("data source=.; database=DBEmployee; integrated security=SSPI");
            return con;
        }
    }
}