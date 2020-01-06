using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic
{
    public partial class StudentDetails : Form
    {
        public StudentDetails(string uid)
        {
            InitializeComponent();
            display(uid);
            string id = uid;
            marks.Click += (sender2, e2) => marks_Click(sender2, e2, id);
            editDetails.Click += (sender2, e2) => editDetails_Click(sender2, e2, id);
        }

        private void display(string uid) {
            string id = uid;
            var imgLnk = "";
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult()) {
                bool stat = conn.OpenConnection();
                var sql = String.Format("SELECT * FROM student WHERE empid = {0}", id);
                using (MySqlCommand cmd = new MySqlCommand(sql, con)) {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {
                        while(rdr.Read())
                        {
                            imgLnk = rdr.GetString(4);
                            Image img, imgs;
                            var url = WebRequest.Create("https://www.ai-interf.com/academic/profile_photos/photoid@1577686503.jpg");
                            using (var response = url.GetResponse()) {
                                using (var stream = response.GetResponseStream()) {
                                    imgs = Bitmap.FromStream(stream);
                                }
                            }   
                            pictureBox1.Image = imgs;
                            fname.Text = rdr.GetString(2);
                            doj.Text = rdr.GetString(11);
                            addNum.Text = rdr.GetString(3);
                            name.Text = rdr.GetString(2);
                            dob.Text = rdr.GetString(6);
                            gender.Text = rdr.GetString(10);
                            mobile.Text = rdr.GetString(5);
                            email.Text = rdr.GetString(7);
                            address.Text = rdr.GetString(9);
                            grade.Text = rdr.GetString(12);
                            nationality.Text = rdr.GetString(8);

                            guardianName.Text = rdr.GetString(13);
                            guardianNumber.Text = rdr.GetString(14);
                            fatherName.Text = rdr.GetString(15);
                            motherName.Text = rdr.GetString(17);
                            fatherNumber.Text = rdr.GetString(16);
                            motherNumber.Text = rdr.GetString(18);
                            paddress.Text = rdr.GetString(19);
                            sibling.Text = rdr.GetString(20);
                        }
                    }


                }
            }
        }

        private void editDetails_Click(object sender, EventArgs e, string id)
        {
            EditDetails edt = new EditDetails(id);
            edt.Show();
            this.Close();
        }

        private void marks_Click(object sender, EventArgs e, string id) {
            viewMarks view = new viewMarks(id);
            view.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
