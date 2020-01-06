using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academic
{
    public partial class Homepage : Form
    {
        public Homepage() {
            InitializeComponent();
        }

       private void Homepage_Load(object sender, EventArgs e) {}

        private void label2_Click(object sender, EventArgs e) {}

        private void marksheet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddMarks add = new AddMarks();
            add.Show();
            this.Close();
        }

        private void stddetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewStudent view = new ViewStudent();
            view.Show();
            this.Close();
        }

        private void logoUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateLogo upL = new UpdateLogo();
            upL.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
