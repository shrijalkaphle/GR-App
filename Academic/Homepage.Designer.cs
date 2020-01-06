namespace Academic
{
    partial class Homepage
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
            this.label1 = new System.Windows.Forms.Label();
            this.marksheet = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stddetails = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.logoUpdate = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // marksheet
            // 
            this.marksheet.AutoSize = true;
            this.marksheet.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksheet.Location = new System.Drawing.Point(231, 189);
            this.marksheet.Name = "marksheet";
            this.marksheet.Size = new System.Drawing.Size(106, 34);
            this.marksheet.TabIndex = 1;
            this.marksheet.TabStop = true;
            this.marksheet.Text = "Click here.";
            this.marksheet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.marksheet_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Marksheet?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "View Student Details?";
            // 
            // stddetails
            // 
            this.stddetails.AutoSize = true;
            this.stddetails.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stddetails.Location = new System.Drawing.Point(231, 246);
            this.stddetails.Name = "stddetails";
            this.stddetails.Size = new System.Drawing.Size(106, 34);
            this.stddetails.TabIndex = 4;
            this.stddetails.TabStop = true;
            this.stddetails.Text = "Click here.";
            this.stddetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stddetails_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Update School Logo";
            // 
            // logoUpdate
            // 
            this.logoUpdate.AutoSize = true;
            this.logoUpdate.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoUpdate.Location = new System.Drawing.Point(231, 128);
            this.logoUpdate.Name = "logoUpdate";
            this.logoUpdate.Size = new System.Drawing.Size(106, 34);
            this.logoUpdate.TabIndex = 6;
            this.logoUpdate.TabStop = true;
            this.logoUpdate.Text = "Click here.";
            this.logoUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoUpdate_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(299, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(165, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(399, 375);
            this.Controls.Add(this.logoUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stddetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marksheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "Homepage | Grade Report Application";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel marksheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel stddetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel logoUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}