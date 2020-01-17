using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic
{
    public partial class UpdateLogo : Form
    {
        public UpdateLogo()
        {
            InitializeComponent();
            string dirpath = @"C:\GR-App\";
            if (!Directory.Exists(dirpath)) {
                Directory.CreateDirectory(dirpath);
            }
            if (Directory.EnumerateFileSystemEntries(dirpath).Any())
            {
                string[] dirs = Directory.GetFiles(dirpath, "logo.*");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                string filePath = dirs[0];
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    stream.Dispose();
                }

                //school name show
                string txtFile = Path.Combine(dirpath, "schoolName.txt");
                if(File.Exists(txtFile))
                {
                    using (StreamReader sr = File.OpenText(txtFile))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            schoolName.Text = s;
                        }
                    }
                }
            }
        }

        private void changeLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg; *.png"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //check for any previous logo
                string dirpath = @"C:\GR-App\";
                if (Directory.EnumerateFileSystemEntries(dirpath).Any()) {
                    string filePath = Path.Combine(dirpath, "logo.png");
                    string filePath2 = Path.Combine(dirpath, "logo.jpg");
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    if (File.Exists(filePath2))
                    {
                        File.Delete(filePath2);
                    }
                }

                    String path = dialog.FileName; // get name of file
                string fileName = "logo" + Path.GetExtension(path);
                String newpath = Path.Combine(dirpath, fileName);

                //copy logo in the directory
                File.Copy(path, newpath);

                //display picture
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                using (FileStream stream = new FileStream(newpath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    stream.Dispose();
                }


            }
        }

        private void changeName_Click(object sender, EventArgs e)
        {
            string name = schoolName.Text;
            if(name == "")
            {
                MessageBox.Show("Error! Please Enter School Name!!");
            } else {
                string file = @"C:\GR-App\schoolName.txt";
                if(File.Exists(file))
                {
                    File.Delete(file);
                }
                using (FileStream fs = File.Create(file)) {
                    Byte[] title = new UTF8Encoding(true).GetBytes(name);
                    fs.Write(title, 0, title.Length);
                }
                MessageBox.Show("School Name Updated");
            }
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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
