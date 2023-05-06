namespace bài3
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Button_send = new System.Windows.Forms.Button();
            this.textBox_in = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 301);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Button_send
            // 
            this.Button_send.Location = new System.Drawing.Point(696, 372);
            this.Button_send.Name = "Button_send";
            this.Button_send.Size = new System.Drawing.Size(88, 37);
            this.Button_send.TabIndex = 5;
            this.Button_send.Text = "Send";
            this.Button_send.UseVisualStyleBackColor = true;
            this.Button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // textBox_in
            // 
            this.textBox_in.Location = new System.Drawing.Point(16, 382);
            this.textBox_in.Multiline = true;
            this.textBox_in.Name = "textBox_in";
            this.textBox_in.Size = new System.Drawing.Size(661, 42);
            this.textBox_in.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Button_send);
            this.Controls.Add(this.textBox_in);
            this.Name = "Form3";
            this.Text = "TCP client";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Button_send;
        private System.Windows.Forms.TextBox textBox_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}