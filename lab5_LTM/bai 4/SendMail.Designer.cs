namespace Bai4
{
    partial class SendMail
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
            this.sendTo = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rcvFrom = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // sendTo
            // 
            this.sendTo.Location = new System.Drawing.Point(77, 39);
            this.sendTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendTo.Name = "sendTo";
            this.sendTo.Size = new System.Drawing.Size(253, 22);
            this.sendTo.TabIndex = 2;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(77, 67);
            this.subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(253, 22);
            this.subject.TabIndex = 3;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(77, 93);
            this.body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(623, 210);
            this.body.TabIndex = 4;
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(462, 18);
            this.bt_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(156, 54);
            this.bt_Send.TabIndex = 5;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // attach
            // 
            this.attach.Location = new System.Drawing.Point(581, 314);
            this.attach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(116, 34);
            this.attach.TabIndex = 6;
            this.attach.Text = "Đính kèm";
            this.attach.UseVisualStyleBackColor = true;
            this.attach.Click += new System.EventHandler(this.bt_attach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // rcvFrom
            // 
            this.rcvFrom.Location = new System.Drawing.Point(77, 14);
            this.rcvFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcvFrom.Name = "rcvFrom";
            this.rcvFrom.Size = new System.Drawing.Size(253, 22);
            this.rcvFrom.TabIndex = 8;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(77, 320);
            this.url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(488, 22);
            this.url.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Body";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.url);
            this.Controls.Add(this.rcvFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.body);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.sendTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SendMail";
            this.Text = "New message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendTo;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rcvFrom;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label4;
    }
}