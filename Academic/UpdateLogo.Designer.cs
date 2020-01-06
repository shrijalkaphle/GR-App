namespace Academic
{
    partial class UpdateLogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schoolName = new System.Windows.Forms.TextBox();
            this.changeLogo = new System.Windows.Forms.Button();
            this.changeName = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(108, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 179);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Logo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "School Name";
            // 
            // schoolName
            // 
            this.schoolName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.Location = new System.Drawing.Point(124, 279);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(262, 37);
            this.schoolName.TabIndex = 4;
            // 
            // changeLogo
            // 
            this.changeLogo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLogo.Location = new System.Drawing.Point(302, 43);
            this.changeLogo.Name = "changeLogo";
            this.changeLogo.Size = new System.Drawing.Size(84, 29);
            this.changeLogo.TabIndex = 0;
            this.changeLogo.Text = "Change";
            this.changeLogo.UseVisualStyleBackColor = true;
            this.changeLogo.Click += new System.EventHandler(this.changeLogo_Click);
            // 
            // changeName
            // 
            this.changeName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeName.Location = new System.Drawing.Point(302, 322);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(84, 29);
            this.changeName.TabIndex = 5;
            this.changeName.Text = "Update";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.Click += new System.EventHandler(this.changeName_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toPageToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toPageToolStripMenuItem
            // 
            this.toPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.addMarksToolStripMenuItem});
            this.toPageToolStripMenuItem.Name = "toPageToolStripMenuItem";
            this.toPageToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.toPageToolStripMenuItem.Text = "To Page";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homePageToolStripMenuItem.Text = "HomePage";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // addMarksToolStripMenuItem
            // 
            this.addMarksToolStripMenuItem.Name = "addMarksToolStripMenuItem";
            this.addMarksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMarksToolStripMenuItem.Text = "Add Marks";
            this.addMarksToolStripMenuItem.Click += new System.EventHandler(this.addMarksToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // UpdateLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 375);
            this.Controls.Add(this.changeName);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changeLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UpdateLogo";
            this.Text = "Update Logo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox schoolName;
        private System.Windows.Forms.Button changeLogo;
        private System.Windows.Forms.Button changeName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}