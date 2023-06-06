namespace Bai4
{
    partial class ReadMail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rcvFrom = new System.Windows.Forms.TextBox();
            this.SendTo = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reply = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "BODY";
            // 
            // rcvFrom
            // 
            this.rcvFrom.Location = new System.Drawing.Point(84, 8);
            this.rcvFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcvFrom.Name = "rcvFrom";
            this.rcvFrom.ReadOnly = true;
            this.rcvFrom.Size = new System.Drawing.Size(283, 22);
            this.rcvFrom.TabIndex = 4;
            // 
            // SendTo
            // 
            this.SendTo.Location = new System.Drawing.Point(84, 38);
            this.SendTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendTo.Name = "SendTo";
            this.SendTo.ReadOnly = true;
            this.SendTo.Size = new System.Drawing.Size(283, 22);
            this.SendTo.TabIndex = 5;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(84, 74);
            this.Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Size = new System.Drawing.Size(281, 22);
            this.Subject.TabIndex = 6;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(12, 135);
            this.body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(693, 221);
            this.body.TabIndex = 7;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(480, 11);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Size = new System.Drawing.Size(219, 22);
            this.dateTime.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Time";
            // 
            // reply
            // 
            this.reply.Location = new System.Drawing.Point(416, 54);
            this.reply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(105, 37);
            this.reply.TabIndex = 10;
            this.reply.Text = "Reply";
            this.reply.UseVisualStyleBackColor = true;
            this.reply.Click += new System.EventHandler(this.bt_Reply_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(544, 54);
            this.forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(100, 37);
            this.forward.TabIndex = 11;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.bt_Forward_Click);
            // 
            // ReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.SendTo);
            this.Controls.Add(this.rcvFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReadMail";
            this.Text = "ReadMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rcvFrom;
        private System.Windows.Forms.TextBox SendTo;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reply;
        private System.Windows.Forms.Button forward;
    }
}