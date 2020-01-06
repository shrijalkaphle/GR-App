using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            display(null);
        }

        private void ViewStudent_Load(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void display(string id) {
            var sql = "";
            string sid = "%" + id + "%";
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult())
            {
                bool stat = conn.OpenConnection();
                if (id == null) {
                    sql = String.Format("SELECT name,uname,doj,mobile,currentaddress,empid FROM student");
                } else {
                    sql = String.Format("SELECT name,uname,doj,mobile,currentaddress,empid FROM student WHERE uname LIKE '{0}'",sid);
                }
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (rdr.Read())
                        {
                            youlayOut.RowCount = youlayOut.RowCount + i;
                            Label lbl1 = new Label();
                            lbl1.Font = new Font("Myanmar Text", 10);
                            lbl1.Text = rdr.GetString(0);
                            youlayOut.Controls.Add(lbl1, 0, i);

                            Label lbl2 = new Label();
                            lbl2.Font = new Font("Myanmar Text", 10);
                            lbl2.Text = rdr.GetString(1);
                            youlayOut.Controls.Add(lbl2, 1, i);

                            Label lbl3 = new Label();
                            lbl3.Font = new Font("Myanmar Text", 10);
                            lbl3.Text = rdr.GetString(2);
                            youlayOut.Controls.Add(lbl3, 2, i);

                            Label lbl4 = new Label();
                            lbl4.Font = new Font("Myanmar Text", 10);
                            lbl4.Text = rdr.GetString(3);
                            youlayOut.Controls.Add(lbl4, 3, i);

                            Label lbl5 = new Label();
                            lbl5.Font = new Font("Myanmar Text", 10);
                            lbl5.Text = rdr.GetString(4);
                            youlayOut.Controls.Add(lbl5, 4, i);

                            string uid = rdr.GetString(5);
                            Button viewbtn = new Button();
                            viewbtn.Text = "View";
                            viewbtn.Click += (sender2, e2) => viewbtnClick(sender2, e2, uid);
                            youlayOut.Controls.Add(viewbtn, 5, i);

                            Button delbtn = new Button();
                            delbtn.Name = "delbtn" + uid;
                            delbtn.Text = "Delete";
                            delbtn.Click += (sender2, e2) => delbtnClick(sender2, e2, uid);
                            youlayOut.Controls.Add(delbtn, 6, i);

                            i++;
                        }
                        rdr.Close();
                    }
                    cmd.Cancel();
                }
            }
        }
        private void viewbtnClick(object sender, EventArgs e, string id) {
            string uid = id;
            StudentDetails std = new StudentDetails(uid);
            std.Show();
            this.Close();
        }

        private void delbtnClick(object sender, EventArgs e, string id) {
            string uid = id;
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult()) {
                bool stat = conn.OpenConnection();
                var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    var sql = String.Format("DELETE FROM student WHERE empid = {0}", uid);
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Delete successful");
                        youlayOut.Controls.Clear();
                        youlayOut.RowStyles.Clear();
                        display(null);                       
                    }
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string uname = textBox1.Text.ToUpper();
            youlayOut.Controls.Clear();
            youlayOut.RowStyles.Clear();
            if (uname == null) {
                display(null);
            } else {
                display(uname);
            }
        }
        private void signout(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Close();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent std = new ViewStudent();
            std.Show();
            this.Close();
        }

        private void addMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarks add = new AddMarks();
            add.Show();
            this.Close();
        }
    }
}
