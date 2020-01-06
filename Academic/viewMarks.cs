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
    public partial class viewMarks : Form
    {
        public viewMarks(string id)
        {
            InitializeComponent();
            display(id);
        }

        private void display(string id)
        {
            Connect conn = new Connect();
            using (MySqlConnection con = conn.connectionResult())
            {
                var sqly = String.Format("SELECT name,uname,grade FROM student WHERE empid = {0}", id);
                bool stat = conn.OpenConnection();
                bool status = checkMarks(id);
                using(MySqlCommand cmd = new MySqlCommand(sqly, con)) {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            name.Text = rdr.GetString(0);
                            grade.Text = rdr.GetString(2);
                            addNum.Text = rdr.GetString(1);
                        }
                    }
                }
                if(status) {
                    var sql = String.Format("SELECT * FROM marks WHERE sid = {0}", id);
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
                                lbl1.Text = rdr.GetString(2);
                                youlayOut.Controls.Add(lbl1, 0, i);

                                Label lbl2 = new Label();
                                lbl2.Font = new Font("Myanmar Text", 10);
                                lbl2.Text = rdr.GetString(3);
                                youlayOut.Controls.Add(lbl2, 1, i);

                                Label lbl3 = new Label();
                                lbl3.Font = new Font("Myanmar Text", 10);
                                lbl3.Text = "100";
                                youlayOut.Controls.Add(lbl3, 2, i);

                                Label lbl4 = new Label();
                                lbl4.Font = new Font("Myanmar Text", 10);
                                lbl4.Text = rdr.GetString(4);
                                youlayOut.Controls.Add(lbl4, 3, i);

                                Label lbl5 = new Label();
                                lbl5.Font = new Font("Myanmar Text", 10);
                                lbl5.Text = rdr.GetString(5);
                                youlayOut.Controls.Add(lbl5, 4, i);

                                i++;
                            }
                            rdr.Close();
                        }
                        cmd.Cancel();
                    }
                } else {
                    error.Text = "No marks Record Found";
                }
            }
        }

        private bool checkMarks(string id) {
            int Count;
            var sql = String.Format("SELECT count(sid) FROM marks WHERE sid={0}",id);
            Connect conn = new Connect();
            bool stat = conn.OpenConnection();
            using (MySqlConnection con = conn.connectionResult()){
                using (MySqlCommand cmd = new MySqlCommand(sql, con)) {
                    object count = cmd.ExecuteScalar();
                    Count = int.Parse(count.ToString());
                }
            }
            if (Count == 0) {
                return false;
            } else {
                return true;
            }
        }
    }
}
