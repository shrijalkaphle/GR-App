namespace Academic
{
    partial class LoginForm
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.unamelabel = new System.Windows.Forms.Label();
            this.pwdlabel = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(149, 271);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(111, 35);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // unamelabel
            // 
            this.unamelabel.AutoSize = true;
            this.unamelabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelabel.Location = new System.Drawing.Point(95, 77);
            this.unamelabel.Name = "unamelabel";
            this.unamelabel.Size = new System.Drawing.Size(100, 34);
            this.unamelabel.TabIndex = 1;
            this.unamelabel.Text = "Username";
            // 
            // pwdlabel
            // 
            this.pwdlabel.AutoSize = true;
            this.pwdlabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlabel.Location = new System.Drawing.Point(95, 154);
            this.pwdlabel.Name = "pwdlabel";
            this.pwdlabel.Size = new System.Drawing.Size(95, 34);
            this.pwdlabel.TabIndex = 2;
            this.pwdlabel.Text = "Password";
            this.pwdlabel.Click += new System.EventHandler(this.pwdlabel_Click);
            // 
            // uname
            // 
            this.uname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(101, 114);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(228, 37);
            this.uname.TabIndex = 3;
            this.uname.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(101, 191);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(228, 37);
            this.pwd.TabIndex = 4;
            this.pwd.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 383);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.pwdlabel);
            this.Controls.Add(this.unamelabel);
            this.Controls.Add(this.loginbtn);
            this.Name = "LoginForm";
            this.Text = "Grade Report Application";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label unamelabel;
        private System.Windows.Forms.Label pwdlabel;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
    }
}