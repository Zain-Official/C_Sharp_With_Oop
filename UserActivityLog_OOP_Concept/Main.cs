using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;


namespace UserActivityLog_OOP_Concept
{
    
   public class Main
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-N43NUMQ\ZAIN_SINDHI; Integrated Security = true; Initial Catalog =Practice");        
            return con;
        }
    }
}
