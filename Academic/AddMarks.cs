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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Academic
{
    public partial class AddMarks : Form
    {

        Connect conn = new Connect();
        MySqlConnection con;
        MySqlCommand cmd;
        float gtotal1 = 0;
        float gtotal2 = 0;
        float gtotal3 = 0;
        float comb_gtotal = 0;

        public AddMarks()
        {
            InitializeComponent();
            english20.Controls[0].Visible = false;
            english80.Controls[0].Visible = false;
            nepali20.Controls[0].Visible = false;
            nepali80.Controls[0].Visible = false;
            science20.Controls[0].Visible = false;
            science80.Controls[0].Visible = false;
            socialngk20.Controls[0].Visible = false;
            socialngk80.Controls[0].Visible = false;
            maths20.Controls[0].Visible = false;
            maths80.Controls[0].Visible = false;
            computer20.Controls[0].Visible = false;
            computer80.Controls[0].Visible = false;
            sambhota20.Controls[0].Visible = false;
            sambhota80.Controls[0].Visible = false;
            healthnphysical20.Controls[0].Visible = false;
            healthnphysical80.Controls[0].Visible = false;
            obt20.Controls[0].Visible = false;
            obt80.Controls[0].Visible = false;
            moralscience20.Controls[0].Visible = false;
            moralscience80.Controls[0].Visible = false;
            drawing20.Controls[0].Visible = false;
            drawing80.Controls[0].Visible = false;
            examid.Controls[0].Visible = false;

            english20.Text = "";
            english80.Text = "";
            nepali20.Text = "";
            nepali80.Text = "";
            science20.Text = "";
            science80.Text = "";
            socialngk20.Text = "";
            socialngk80.Text = "";
            maths20.Text = "";
            maths80.Text = "";
            computer20.Text = "";
            computer80.Text = "";
            sambhota20.Text = "";
            sambhota80.Text = "";
            healthnphysical20.Text = "";
            healthnphysical80.Text = "";
            moralscience20.Text = "";
            moralscience80.Text = "";
            obt20.Text = "";
            obt80.Text = "";
            drawing20.Text = "";
            drawing80.Text = "";
            examid.Text = "";
        }

        private void Term_Load(object sender, EventArgs e) {}
        private void label12_Click(object sender, EventArgs e) {}
        private void label14_Click(object sender, EventArgs e) {}
        private void uid_TextChanged(object sender, EventArgs e) {}
        List<string> info = new List<string>();
        private void validate_Click(object sender, EventArgs e)
        {
            string uname = uid.Text.ToUpper();
            using (MySqlConnection con = conn.connectionResult())
            {
                bool stat = conn.OpenConnection();
                var sql = String.Format("SELECT empid,name,grade FROM student WHERE uname = '{0}'", uname);
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            id = rdr.GetString(0);
                            info.Add(rdr.GetString(1));
                            info.Add(rdr.GetString(2));
                        }
                        rdr.Close();
                    }
                    cmd.Cancel();
                }
            }
            fname.Text = info[0];
            grade.Text = info[1];
        }

        private void english80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(english20.Text) + float.Parse(english80.Text);
            english.Text = marks.ToString();
            englishGrade.Text = checkGrade(marks);
        }

        private void nepali80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(nepali20.Text) + float.Parse(nepali80.Text);
            nepali.Text = marks.ToString();
            nepaliGrade.Text = checkGrade(marks);
        }

        private void science80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(science20.Text) + float.Parse(science80.Text);
            science.Text = marks.ToString();
            scienceGrade.Text = checkGrade(marks);
        }

        private void socialngk80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(socialngk20.Text) + float.Parse(socialngk80.Text);
            socialngk.Text = marks.ToString();
            socialngkGrade.Text = checkGrade(marks);
        }

        private void maths80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(maths20.Text) + float.Parse(maths80.Text);
            maths.Text = marks.ToString();
            mathsGrade.Text = checkGrade(marks);
        }

        private void computer80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(computer20.Text) + float.Parse(computer80.Text);
            computer.Text = marks.ToString();
            computerGrade.Text = checkGrade(marks);
        }

        private void sambhota80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(sambhota20.Text) + float.Parse(sambhota80.Text);
            sambhota.Text = marks.ToString();
            sambhotaGrade.Text = checkGrade(marks);
        }

        private void healthnphysical80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(healthnphysical20.Text) + float.Parse(healthnphysical80.Text);
            healthnphysical.Text = marks.ToString();
            healthnphysicalGrade.Text = checkGrade(marks);
        }

        private void obt80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(obt20.Text) + float.Parse(obt80.Text);
            obt.Text = marks.ToString();
            obtGrade.Text = checkGrade(marks);
        }

        private void moralscience80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(moralscience20.Text) + float.Parse(moralscience80.Text);
            moralscience.Text = marks.ToString();
            moralscienceGrade.Text = checkGrade(marks);
        }

        private void drawing80_ValueChanged(object sender, EventArgs e)
        {
            float marks = float.Parse(drawing20.Text) + float.Parse(drawing80.Text);
            drawing.Text = marks.ToString();
            drawingGrade.Text = checkGrade(marks);
        }

        string[,] marks = new string[11, 2];
        float[,] first = new float[11, 2];
        float[,] second = new float[11, 2];
        float[,] third = new float[11, 2];
        int exam;
        string id;
        List<string> combined = new List<string>();
        
        private void addToDB_Click(object sender, EventArgs e) {

            string adminNum = uid.Text;
            exam = int.Parse(examid.Text);
            marks[0, 0] = checkDecimal(decimal.Parse(english20.Text));
            marks[0, 1] = checkDecimal(decimal.Parse(english80.Text));
            marks[1, 0] = checkDecimal(decimal.Parse(nepali20.Text));
            marks[1, 1] = checkDecimal(decimal.Parse(nepali80.Text));
            marks[2, 0] = checkDecimal(decimal.Parse(science20.Text));
            marks[2, 1] = checkDecimal(decimal.Parse(science80.Text));
            marks[3, 0] = checkDecimal(decimal.Parse(socialngk20.Text));
            marks[3, 1] = checkDecimal(decimal.Parse(socialngk80.Text));
            marks[4, 0] = checkDecimal(decimal.Parse(maths20.Text));
            marks[4, 1] = checkDecimal(decimal.Parse(maths80.Text));
            marks[5, 0] = checkDecimal(decimal.Parse(computer20.Text));
            marks[5, 1] = checkDecimal(decimal.Parse(computer80.Text));
            marks[6, 0] = checkDecimal(decimal.Parse(healthnphysical20.Text));
            marks[6, 1] = checkDecimal(decimal.Parse(healthnphysical80.Text));
            marks[7, 0] = checkDecimal(decimal.Parse(sambhota20.Text));
            marks[7, 1] = checkDecimal(decimal.Parse(sambhota80.Text));
            marks[8, 0] = checkDecimal(decimal.Parse(obt20.Text));
            marks[8, 1] = checkDecimal(decimal.Parse(obt80.Text));
            marks[9, 0] = checkDecimal(decimal.Parse(moralscience20.Text));
            marks[9, 1] = checkDecimal(decimal.Parse(moralscience80.Text));
            marks[10, 0] = checkDecimal(decimal.Parse(drawing20.Text));
            marks[10, 1] = checkDecimal(decimal.Parse(drawing80.Text));

            if (exam == 1) {
                for(int i=0;i<11;i++) {
                    for(int j=0;j<2;j++) {
                        first[i, j] = float.Parse(marks[i, j]);
                    }
                }
            } else if (exam == 2) {
                for (int i = 0; i < 11; i++) {
                    for (int j = 0; j < 2; j++) {
                        second[i, j] = float.Parse(marks[i, j]);
                    }
                }
            }
            else if (exam == 3) {
                for (int i = 0; i < 11; i++) {
                    for (int j = 0; j < 2; j++) {
                        third[i, j] = float.Parse(marks[i, j]);
                    }
                }
            }

            try
            {
                con = conn.connectionResult();
                bool stat = conn.OpenConnection();
                
                for(int i = 0;i < 11;i++) {
                    var practical = marks[i, 0];
                    var theory = marks[i, 1];
                    var subid = i + 1;
                    var sql2 = String.Format("INSERT INTO `marks`(`sid`,`examid`, `subjectid`, `practical`, `theory`) VALUES ('{0}','{1}','{2}','{3}','{4}')", id, exam, subid, practical, theory);
                    cmd = new MySqlCommand(sql2, con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Marks has been added to Database!!");
                createPDF();
                english20.Text = "";
                english80.Text = "";
                nepali20.Text = "";
                nepali80.Text = "";
                science20.Text = "";
                science80.Text = "";
                socialngk20.Text = "";
                socialngk80.Text = "";
                maths20.Text = "";
                maths80.Text = "";
                computer20.Text = "";
                computer80.Text = "";
                sambhota20.Text = "";
                sambhota80.Text = "";
                healthnphysical20.Text = "";
                healthnphysical80.Text = "";
                moralscience20.Text = "";
                moralscience80.Text = "";
                obt20.Text = "";
                obt80.Text = "";
                drawing20.Text = "";
                drawing80.Text = "";
                examid.Text = "";
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void createPDF()
        {
            string total;
            using (MemoryStream memoryStream = new MemoryStream()) {

                Document document = new Document(PageSize.A4);
                document.SetMargins(-30,-30,5,5);
                var fileName = "D:/result.pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                document.Open();

                document.Add(Chunk.NEWLINE);
                document.Add(Chunk.NEWLINE);

                Paragraph p = new Paragraph();
                string file = @"C:\Users\Shrijal Kaphle\Documents\Visual Studio 2015\Projects\Academic\Academic\Information\schoolName.txt";
                string txt = "";
                using (StreamReader sr = File.OpenText(file)) {
                    string s = "";
                    while ((s = sr.ReadLine()) != null) {
                        txt = s;
                    }
                }
                p.SpacingBefore = 10;
                p.SpacingAfter = 10;
                p.Alignment = Element.ALIGN_CENTER;
                p.Font = FontFactory.GetFont(FontFactory.HELVETICA, 24f, BaseColor.BLACK);
                p.Add(txt);
                document.Add(p);

                document.Add(Chunk.NEWLINE);
                document.Add(Chunk.NEWLINE);

                string dirpath = @"C:\Users\Shrijal Kaphle\Documents\Visual Studio 2015\Projects\Academic\Academic\Information\";
                string[] dirs = Directory.GetFiles(dirpath, "logo.*");
                iTextSharp.text.Image imgJpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromFile(dirs[0]), new BaseColor(System.Drawing.Color.White));
                imgJpg.SetDpi(300, 300);
                imgJpg.ScaleToFit(100f, 100f);
                imgJpg.Alignment = Element.ALIGN_CENTER;
                document.Add(imgJpg);

                document.Add(Chunk.NEWLINE);
                document.Add(Chunk.NEWLINE);

                BaseFont bf = BaseFont.CreateFont(
                        BaseFont.TIMES_ROMAN,
                        BaseFont.CP1252,
                        BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 9);
                string text = "Eximination Result Card";
                Paragraph paragraph = new Paragraph();
                paragraph.SpacingBefore = 10;
                paragraph.SpacingAfter = 10;
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 24f, BaseColor.BLACK);
                paragraph.Add(text);
                document.Add(paragraph);

                PdfPTable table = new PdfPTable(19);
                float[] setWidth = new float[] {5f,5f,4f,4f,4f,4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f };
                table.SetWidths(setWidth);

                PdfPCell cell = new PdfPCell(new Phrase("Subject",font));
                cell.Rowspan = 2;
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("1 Terminal",font));
                cell.Colspan = 4;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("2 Terminal", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("3 Terminal", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Combined Result", font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("20%", font));
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("80%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("100%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Grade", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("20%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("80%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("100%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Grade", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("20%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("80%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("100%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Grade", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("30%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("30%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("40%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("100%", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Grade", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //English Marks
                cell = new PdfPCell(new Phrase("English", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                if(exam == 1) {
                    cell = new PdfPCell(new Phrase(marks[0,0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[0,1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[0, 0]) + float.Parse(marks[0, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                } else {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 1 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[0, 0] = float.Parse(result[0]);
                        first[0, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1) {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                } else if (exam == 2) {
                    cell = new PdfPCell(new Phrase(marks[0, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[0, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[0, 0]) + float.Parse(marks[0, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                } else {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 1 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[0, 0] = float.Parse(result[0]);
                        second[0, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[0, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[0, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[0, 0]) + float.Parse(marks[0, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if(exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);
                    
                } else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //Nepali Marks
                combined.Clear();
                cell = new PdfPCell(new Phrase("Nepali", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[1, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[1, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[1, 0]) + float.Parse(marks[1, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 2 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[1, 0] = float.Parse(result[0]);
                        first[1, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[1, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[1, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[1, 0]) + float.Parse(marks[1, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 2 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[1, 0] = float.Parse(result[0]);
                        second[1, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[1, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[1, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[1, 0]) + float.Parse(marks[1, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //science & env marks
                combined.Clear();
                cell = new PdfPCell(new Phrase("Science & Environment", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[0, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[0, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[0, 0]) + float.Parse(marks[0, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 3 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[2, 0] = float.Parse(result[0]);
                        first[2, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[0, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[0, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[2, 0]) + float.Parse(marks[2, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 3 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[2, 0] = float.Parse(result[0]);
                        second[2, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[2, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[2, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[2, 0]) + float.Parse(marks[2, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //social & gk
                cell = new PdfPCell(new Phrase("Social Studies & GK", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[3, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[3, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[3, 0]) + float.Parse(marks[3, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 4 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[3, 0] = float.Parse(result[0]);
                        first[3, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[3, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[3, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[3, 0]) + float.Parse(marks[3, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 4 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[3, 0] = float.Parse(result[0]);
                        second[3, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[3, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[3, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[3, 0]) + float.Parse(marks[3, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //maths
                cell = new PdfPCell(new Phrase("Mathematic", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[4, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[4, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[4, 0]) + float.Parse(marks[4, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 5 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[4, 0] = float.Parse(result[0]);
                        first[4, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[4, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[4, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[4, 0]) + float.Parse(marks[4, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 5 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[4, 0] = float.Parse(result[0]);
                        second[4, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[4, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[4, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[4, 0]) + float.Parse(marks[4, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //computer
                cell = new PdfPCell(new Phrase("Computer Science", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[5, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[5, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[5, 0]) + float.Parse(marks[5, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 6 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[5, 0] = float.Parse(result[0]);
                        first[5, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[5, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[5, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[5, 0]) + float.Parse(marks[5, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 6 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[5, 0] = float.Parse(result[0]);
                        second[5, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[5, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[5, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[5, 0]) + float.Parse(marks[5, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //sambhota
                cell = new PdfPCell(new Phrase("Sambhota", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[6, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[6, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[6, 0]) + float.Parse(marks[6, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 7 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[6, 0] = float.Parse(result[0]);
                        first[6, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[6, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[6, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[6, 0]) + float.Parse(marks[6, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 7 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[6, 0] = float.Parse(result[0]);
                        second[6, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[6, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[6, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[6, 0]) + float.Parse(marks[6, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //health & physical edu
                cell = new PdfPCell(new Phrase("Health & Physical Edu", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[7, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[7, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[7, 0]) + float.Parse(marks[7, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 8 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[7, 0] = float.Parse(result[0]);
                        first[7, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[7, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[7, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[7, 0]) + float.Parse(marks[7, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 8 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[7, 0] = float.Parse(result[0]);
                        second[7, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[7, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[7, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[7, 0]) + float.Parse(marks[7, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //obt edu
                cell = new PdfPCell(new Phrase("OBT Education", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[8, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[8, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[8, 0]) + float.Parse(marks[8, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 9 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[8, 0] = float.Parse(result[0]);
                        first[8, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[8, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[8, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[8, 0]) + float.Parse(marks[8, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 9 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[8, 0] = float.Parse(result[0]);
                        second[8, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[8, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[8, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[8, 0]) + float.Parse(marks[8, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //moral science
                cell = new PdfPCell(new Phrase("Moral Science", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[9, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[9, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[9, 0]) + float.Parse(marks[9, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 10 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[9, 0] = float.Parse(result[0]);
                        first[9, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[9, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[9, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[9, 0]) + float.Parse(marks[9, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 10 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[9, 0] = float.Parse(result[0]);
                        second[9, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[9, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[9, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[9, 0]) + float.Parse(marks[9, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //drawing
                cell = new PdfPCell(new Phrase("Drawing", font));
                cell.Colspan = 2;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                combined.Clear();
                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase(marks[10, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[10, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[10, 0]) + float.Parse(marks[10, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal1 = gtotal1 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 1 AND subjectid = 11 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        first[10, 0] = float.Parse(result[0]);
                        first[10, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal1 = gtotal1 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase(marks[10, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[10, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[10, 0]) + float.Parse(marks[10, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    gtotal2 = gtotal2 + float.Parse(total);
                }
                else
                {
                    using (MySqlConnection con = conn.connectionResult())
                    {
                        List<string> result = new List<string>();
                        bool stat = conn.OpenConnection();
                        var sql = String.Format("SELECT practical,theory FROM marks WHERE examid = 2 AND subjectid = 11 AND sid = '{0}'", id);
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    result.Add(rdr.GetString(0));
                                    result.Add(rdr.GetString(1));
                                }
                                rdr.Close();
                            }
                            cmd.Cancel();
                        }
                        second[10, 0] = float.Parse(result[0]);
                        second[10, 1] = float.Parse(result[1]);
                        cell = new PdfPCell(new Phrase(result[0], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(result[1], font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        total = (float.Parse(result[0]) + float.Parse(result[1])).ToString();
                        cell = new PdfPCell(new Phrase(total, font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                        combined.Add((float.Parse(total) * 0.3).ToString());
                        gtotal2 = gtotal2 + float.Parse(total);
                    }
                }

                if (exam == 1)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 2)
                {
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                else if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(marks[10, 0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(marks[10, 1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(marks[10, 0]) + float.Parse(marks[10, 1])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    combined.Add((float.Parse(total) * 0.4).ToString());
                    gtotal3 = gtotal3 + float.Parse(total);
                }

                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(combined[0], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[1], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(combined[2], font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    total = (float.Parse(combined[0]) + float.Parse(combined[1]) + float.Parse(combined[2])).ToString();
                    cell = new PdfPCell(new Phrase(total, font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(checkGrade(float.Parse(total)), font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    comb_gtotal = comb_gtotal + float.Parse(total);

                }
                else
                {
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(" ", font));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                //grand total
                cell = new PdfPCell(new Phrase());
                cell.Colspan = 2;
                cell.Rowspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("GRAND TOTAL", font));
                cell.Colspan = 3;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(gtotal1.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("GRAND TOTAL", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(gtotal2.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("GRAND TOTAL", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(gtotal3.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("GRAND TOTAL", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(comb_gtotal.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //percentage
                cell = new PdfPCell(new Phrase("PERCENTAGE", font));
                cell.Colspan = 3;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                var percent1 = (gtotal1 / 1100)*100;
                cell = new PdfPCell(new Phrase(percent1.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("PERCENTAGE", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                var percent2 = (gtotal2 / 1100) * 100;
                cell = new PdfPCell(new Phrase(percent2.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("PERCENTAGE", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                var percent3 = (gtotal3 / 1100) * 100;
                cell = new PdfPCell(new Phrase(percent3.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("PERCENTAGE", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                var combpercent = (comb_gtotal / 1100) * 100;
                cell = new PdfPCell(new Phrase(combpercent.ToString(), font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //attendence
                cell = new PdfPCell(new Phrase("ATTANDANCE", font));
                cell.Colspan = 3;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("ATTANDANCE", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("ATTANDANCE", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("1100", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase());
                cell.Colspan = 5;
                cell.Rowspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //result
                cell = new PdfPCell(new Phrase(Result(first), font));
                cell.Colspan = 4;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                if(exam == 1) {
                    cell = new PdfPCell(new Phrase("", font));
                } else {
                    cell = new PdfPCell(new Phrase(Result(second), font));
                }
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                if (exam == 3)
                {
                    cell = new PdfPCell(new Phrase(Result(third), font));
                }
                else
                {
                    cell = new PdfPCell(new Phrase("", font));
                }
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //total attendence

                iTextSharp.text.Font boldfont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);
                cell = new PdfPCell(new Phrase("TOTAL ATTENDENCE", boldfont));
                cell.Colspan = 5;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("TOTAL SCHOOL DAYS", boldfont));
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                //characterstics
                cell = new PdfPCell(new Phrase("Responsibility & Social Work", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("80% Above", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Excellent", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Dedication and Effort", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("70% Above", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Good", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Participation & Involvement", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("60% Above", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Satisfactory", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Leadership", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Below 59.9%", font));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Needs Improvement", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("D", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Personal Hygeine", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("FINAL ASSESSMENT", boldfont));
                cell.Colspan = 10;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Moral Behavior", font));
                cell.Colspan = 6;
                cell.MinimumHeight = 20;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("A", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("B", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("C", font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Not Promoted", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Promoted To", font));
                cell.Colspan = 3;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("", font));
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

                document.Add(table);

                document.Add(Chunk.NEWLINE);
                document.Add(Chunk.NEWLINE);

                Paragraph clteacher = new Paragraph();
                txt = "Class Teacher's Signature";
                clteacher.SpacingBefore = 10;
                clteacher.SpacingAfter = 10;
                clteacher.Alignment = Element.ALIGN_CENTER;
                clteacher.Font = FontFactory.GetFont(FontFactory.HELVETICA, 14f, BaseColor.BLACK);
                clteacher.Add(txt);
                document.Add(clteacher);

                document.Close();   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createPDF();
        }

        private string checkGrade(float total) {
            
            float marks = total;
            string grade;
            if (marks >= 90)
            {
                grade = "A+";
            }
            else if (marks >= 80 && marks < 90)
            {
                grade = "A";
            }
            else if (marks >= 70 && marks < 80)
            {
                grade = "B+";
            }
            else if (marks >= 60 && marks < 70)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks < 60)
            {
                grade = "C+";
            }
            else if (marks >= 40 && marks < 50)
            {
                grade = "C";
            }
            else if (marks >= 25 && marks < 40)
            {
                grade = "D";
            }
            else if (marks >= 1 && marks < 25)
            {
                grade = "E";
            }
            else
            {
                grade = "N";
            }
            
            return grade;
        }
        public string checkDecimal(decimal marks) {
            decimal returnMarks = 0;
            if ((marks % 1) == 0) {
                returnMarks = decimal.Round(marks, 2, MidpointRounding.AwayFromZero);
            } else
            {
                returnMarks = marks;
            }

            return returnMarks.ToString();
        }

        public string Result(float[,] allMark) {
            var status="";
            bool flag = false;
            
            for(int i = 0; i < 11; i++) {
                if (allMark[i, 0] <= 8) {
                    flag = true;
                    break;
                }
                if (allMark[i, 1] <= 32) {
                    flag = true;
                    break;
                }
            }

            if(flag) {
                status = "Fail";
            } else {
                status = "Pass";
            }

            return status;
        }
    }
}