namespace Bài1
{
    partial class ControlPanel
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
            this.UDPServer = new System.Windows.Forms.Button();
            this.UDPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPServer
            // 
            this.UDPServer.Location = new System.Drawing.Point(213, 150);
            this.UDPServer.Name = "UDPServer";
            this.UDPServer.Size = new System.Drawing.Size(122, 105);
            this.UDPServer.TabIndex = 0;
            this.UDPServer.Text = "UDP server";
            this.UDPServer.UseVisualStyleBackColor = true;
            this.UDPServer.Click += new System.EventHandler(this.UDPServer_Click);
            // 
            // UDPClient
            // 
            this.UDPClient.Location = new System.Drawing.Point(473, 150);
            this.UDPClient.Name = "UDPClient";
            this.UDPClient.Size = new System.Drawing.Size(122, 105);
            this.UDPClient.TabIndex = 1;
            this.UDPClient.Text = "UDP Client";
            this.UDPClient.UseVisualStyleBackColor = true;
            this.UDPClient.Click += new System.EventHandler(this.UDPClient_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UDPServer);
            this.Controls.Add(this.UDPClient);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPServer;
        private System.Windows.Forms.Button UDPClient;
    }
}

