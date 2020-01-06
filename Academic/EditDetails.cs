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
    public partial class EditDetails : Form
    {
        public EditDetails(string id)
        {
            InitializeComponent();
            display(id);
        }
        string uid;
        private void display(string id)
        {
            uid = id;
            var sql = String.Format("SELECT * FROM student WHERE empid = {0}", id);
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult()) {
                bool stat = conn.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(sql, con)) {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
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

        private void update_Click(object sender, EventArgs e) {
            var sql = String.Format("UPDATE student SET name='{0}',uname='{1}',mobile='{2}',dob='{3}',email='{4}',nationality='{5}',currentaddress='{6}',gender='{7}',doj='{8}',grade='{9}',guardianname='{10}',guardiannum='{11}',father='{12}',fathernum='{13}',mother='{14}',mothernum='{15}',peraddress='{16}',sibling='{17}' WHERE empid = {18}",name.Text,addNum.Text,mobile.Text,dob.Text,email.Text,nationality.Text,address.Text,gender.Text,doj.Text,grade.Text,guardianName.Text,guardianNumber.Text,fatherName.Text,fatherNumber.Text,motherName.Text,motherNumber.Text,paddress.Text,sibling.Text,uid);
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult()) {
                bool stat = conn.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(sql, con)) {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!!");
                    StudentDetails std = new StudentDetails(uid);
                    std.Show();
                    this.Close();
                    
                }
            }
        }
    }
}
