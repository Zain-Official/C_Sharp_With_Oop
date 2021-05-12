using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace UserActivityLog_OOP_Concept
{
    class UserActivityLog
    {
        protected string UserID;
        protected string IP;

        public UserActivityLog(string _UserId,string _IP)
        {
            UserID = _UserId;

            IP = _IP;
        }

        public void Task(string action)
        {
            string SQL = @"Insert into User_Activity_Log Values('" + UserID + "',getData(),'" + action + "','','" + this.IP + "')";
            SqlConnection con = Main.GetDBConnection();
            DataTable tb = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(SQL, con);
            dp.Fill(tb);

        }

    }
}
