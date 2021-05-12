using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserActivityLog_OOP_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected string CIP = "5";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(258, 200);
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(host);
            CIP = (ip.AddressList[0].ToString());
            label5.Text = (ip.AddressList[0].ToString());
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Your Name","Varifaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please Enter Your Password", "Varifaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Login LG = new Login(textBox1.Text, textBox2.Text, CIP);
                LG.Validation();
                if (LG.EmpNo == string.Empty)
                {
                    MessageBox.Show("Invalid UserName Or Password", "Varifaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserActivityLog alog = new UserActivityLog(textBox1.Text, textBox2.Text, "Action", CIP);
                    alog.Task("Login");
                    //login Successfull
                    frmActivity f = new frmActivity();
                    f.Show();
                }
            }
        }
    }
}
