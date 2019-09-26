using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmcacy1.App_Data
{
    class sqlcon
    {
        public static SqlConnection con = null;
        public void Connection_Today()
        {
            con = new SqlConnection(@"Data Source=SIDSYS-LAP-22\SQLEXPRESS;Initial Catalog=mypharmacy;Integrated Security=True");
            con.Open();
        }


    }
}
