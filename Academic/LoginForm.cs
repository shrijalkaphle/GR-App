using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Academic.Connect;

namespace Academic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string username;
        string password;

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Int32 Count = 0;
            Connect conn = new Connect();
            MySqlConnection con;
            MySqlCommand cmd;
            try {
                con = conn.connectionResult();
                bool stat = conn.OpenConnection();
                username = uname.Text;
                password = pwd.Text;
                var sql = String.Format("SELECT COUNT(id) FROM `user` WHERE username='{0}' AND password='{1}'",username,password);
                cmd = new MySqlCommand(sql, con);
                object count = cmd.ExecuteScalar();
                Count = int.Parse(count.ToString());
            } catch(NullReferenceException ex) {
                MessageBox.Show(ex.ToString());
            } catch(InvalidCastException ex) {
                MessageBox.Show(ex.ToString());
            } catch(MySqlException ex) {
                MessageBox.Show(ex.ToString());
            }
            if (Count > 0)
            {
                MessageBox.Show("Successfully loged in");
                //after successful it will redirect  to next page .
                Homepage add = new Homepage();
                add.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pwdlabel_Click(object sender, EventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
