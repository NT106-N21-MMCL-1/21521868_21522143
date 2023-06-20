namespace LAB03
{
    partial class Client
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstViewShowMessage = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.lstChatters = new System.Windows.Forms.ListBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEncrypt);
            this.tabPage1.Controls.Add(this.lstViewShowMessage);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtEncrypt);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Public Chat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstViewShowMessage
            // 
            this.lstViewShowMessage.HideSelection = false;
            this.lstViewShowMessage.Location = new System.Drawing.Point(6, 6);
            this.lstViewShowMessage.Name = "lstViewShowMessage";
            this.lstViewShowMessage.Size = new System.Drawing.Size(764, 300);
            this.lstViewShowMessage.TabIndex = 23;
            this.lstViewShowMessage.UseCompatibleStateImageBehavior = false;
            this.lstViewShowMessage.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 312);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(764, 34);
            this.txtMessage.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Private Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(761, 395);
            this.tabControl2.TabIndex = 0;
            // 
            // lstChatters
            // 
            this.lstChatters.FormattingEnabled = true;
            this.lstChatters.ItemHeight = 16;
            this.lstChatters.Location = new System.Drawing.Point(843, 27);
            this.lstChatters.Name = "lstChatters";
            this.lstChatters.Size = new System.Drawing.Size(107, 468);
            this.lstChatters.TabIndex = 23;
            this.lstChatters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstChatters_MouseDoubleClick);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(111, 358);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(236, 27);
            this.txtEncrypt.TabIndex = 20;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(6, 361);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(99, 16);
            this.lblEncrypt.TabIndex = 24;
            this.lblEncrypt.Text = "Encryption Key ";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 544);
            this.Controls.Add(this.lstChatters);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstViewShowMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ListBox lstChatters;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Label lblEncrypt;
    }
}