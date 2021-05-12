using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserActivityLog_OOP_Concept
{
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            this.Location = new Point(258, 200);
            this.Size = new Size(389,230);
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            UserActivityLog alog = new UserActivityLog(lg.getidinfo, lg.getpassinfo, "Action", lg.getinfoip);
            alog.Task("Add new Record");
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            UserActivityLog alog = new UserActivityLog(lg.getidinfo, lg.getpassinfo, "Action", lg.getinfoip);
            alog.Task("Save Record");

        }

        private void Discard_Btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            UserActivityLog alog = new UserActivityLog(lg.getidinfo, lg.getpassinfo, "Action", lg.getinfoip);
            alog.Task("Discard Record");
        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            UserActivityLog alog = new UserActivityLog(lg.getidinfo, lg.getpassinfo, "Action", lg.getinfoip);
            alog.Task("Logout");
            Close();

        }
    }
}
