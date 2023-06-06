namespace Bai4
{
    partial class Bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compose = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SMTP = new System.Windows.Forms.TextBox();
            this.imap = new System.Windows.Forms.TextBox();
            this.Port_Smtp = new System.Windows.Forms.ComboBox();
            this.Port_imap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Mail = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compose);
            this.groupBox1.Controls.Add(this.Logout);
            this.groupBox1.Controls.Add(this.Refresh);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(346, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // compose
            // 
            this.compose.BackColor = System.Drawing.Color.Transparent;
            this.compose.BackgroundImage = global::Bai4.Properties.Resources.pen;
            this.compose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compose.Location = new System.Drawing.Point(293, 92);
            this.compose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compose.Name = "compose";
            this.compose.Size = new System.Drawing.Size(46, 41);
            this.compose.TabIndex = 7;
            this.compose.UseVisualStyleBackColor = false;
            this.compose.Click += new System.EventHandler(this.bt_newMail_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(189, 92);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(98, 40);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Đăng xuất";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(108, 92);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(80, 40);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(4, 92);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(98, 40);
            this.Login.TabIndex = 4;
            this.Login.Text = "Đăng nhập";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(113, 54);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(196, 22);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(113, 21);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(196, 22);
            this.user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SMTP);
            this.groupBox2.Controls.Add(this.imap);
            this.groupBox2.Controls.Add(this.Port_Smtp);
            this.groupBox2.Controls.Add(this.Port_imap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(364, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(499, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // SMTP
            // 
            this.SMTP.Location = new System.Drawing.Point(312, 33);
            this.SMTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SMTP.Name = "SMTP";
            this.SMTP.Size = new System.Drawing.Size(172, 22);
            this.SMTP.TabIndex = 7;
            // 
            // imap
            // 
            this.imap.Location = new System.Drawing.Point(62, 36);
            this.imap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imap.Name = "imap";
            this.imap.Size = new System.Drawing.Size(172, 22);
            this.imap.TabIndex = 6;
            // 
            // Port_Smtp
            // 
            this.Port_Smtp.FormattingEnabled = true;
            this.Port_Smtp.Location = new System.Drawing.Point(312, 92);
            this.Port_Smtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Port_Smtp.Name = "Port_Smtp";
            this.Port_Smtp.Size = new System.Drawing.Size(172, 24);
            this.Port_Smtp.TabIndex = 5;
            // 
            // Port_imap
            // 
            this.Port_imap.FormattingEnabled = true;
            this.Port_imap.Location = new System.Drawing.Point(62, 95);
            this.Port_imap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Port_imap.Name = "Port_imap";
            this.Port_imap.Size = new System.Drawing.Size(172, 24);
            this.Port_imap.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMAP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Mail);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(851, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MAIL";
            // 
            // Mail
            // 
            this.Mail.BackgroundColor = System.Drawing.Color.White;
            this.Mail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.From,
            this.Subject,
            this.DateTime,
            this.Body});
            this.Mail.Location = new System.Drawing.Point(11, 19);
            this.Mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mail.Name = "Mail";
            this.Mail.RowHeadersWidth = 62;
            this.Mail.RowTemplate.Height = 28;
            this.Mail.Size = new System.Drawing.Size(825, 181);
            this.Mail.TabIndex = 0;
            this.Mail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mail_CellDoubleClick);
            // 
            // NO
            // 
            this.NO.HeaderText = "NO";
            this.NO.MinimumWidth = 8;
            this.NO.Name = "NO";
            this.NO.Width = 50;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 8;
            this.From.Name = "From";
            this.From.Width = 220;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 8;
            this.Subject.Name = "Subject";
            this.Subject.Width = 270;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.MinimumWidth = 8;
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 250;
            // 
            // Body
            // 
            this.Body.HeaderText = "Body";
            this.Body.MinimumWidth = 8;
            this.Body.Name = "Body";
            this.Body.Width = 8;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai4";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SMTP;
        private System.Windows.Forms.TextBox imap;
        private System.Windows.Forms.ComboBox Port_Smtp;
        private System.Windows.Forms.ComboBox Port_imap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Mail;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button compose;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
    }
}

