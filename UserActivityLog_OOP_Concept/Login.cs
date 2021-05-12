using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UserActivityLog_OOP_Concept
{
    class Login
    {
        static string userid;
        static string password;
        static string ip;
        public string EmpNo = string.Empty;
        SqlConnection con = Main.GetDBConnection();


        //Constructor
        public Login()
        {

        }

        public Login(string _userid,string _password,string _ip)
        {
            userid = _userid;
            password = _password;
            ip = _ip;
        }

        public string getidinfo
        {
            get
            {
                return userid;
            }

        }

        public string getpassinfo
        {
            get
            {
                return password;
            }
        }

        public string getinfoip
        {
            get
            {
                return ip;
            }
        }

        public string Validation()
        {
            try
            {
                DataTable ConsultantTable = new DataTable();
                string SQL = @"SELECT LON_Employee_No FROM Login_Client where LON_Login_Name ='" + userid + "' AND LON_Login_Password ='" + password + "'";
                SqlDataAdapter ConsultantDataAdapter = new SqlDataAdapter(SQL, con);
                ConsultantDataAdapter.Fill(ConsultantTable);
                foreach (DataRow myrow in ConsultantTable.Rows)
                {
                    EmpNo = (myrow[0].ToString());

                }
            } catch(InvalidCastException e)
            {
                throw (e);
            }
            return EmpNo;
        }

    }
}
