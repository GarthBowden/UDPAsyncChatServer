namespace UDPAsyncChatServer
{
    partial class Form1
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
            this.BtnSendBroadcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBLocalPort = new System.Windows.Forms.TextBox();
            this.TBRemotePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBBroadcastText = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSendBroadcast
            // 
            this.BtnSendBroadcast.Location = new System.Drawing.Point(43, 133);
            this.BtnSendBroadcast.Name = "BtnSendBroadcast";
            this.BtnSendBroadcast.Size = new System.Drawing.Size(187, 23);
            this.BtnSendBroadcast.TabIndex = 0;
            this.BtnSendBroadcast.Text = "Send Broadcast";
            this.BtnSendBroadcast.UseVisualStyleBackColor = true;
            this.BtnSendBroadcast.Click += new System.EventHandler(this.BtnSendBroadcast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Port";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Port";
            // 
            // TBLocalPort
            // 
            this.TBLocalPort.Location = new System.Drawing.Point(130, 21);
            this.TBLocalPort.Name = "TBLocalPort";
            this.TBLocalPort.Size = new System.Drawing.Size(100, 22);
            this.TBLocalPort.TabIndex = 3;
            // 
            // TBRemotePort
            // 
            this.TBRemotePort.Location = new System.Drawing.Point(130, 58);
            this.TBRemotePort.Name = "TBRemotePort";
            this.TBRemotePort.Size = new System.Drawing.Size(100, 22);
            this.TBRemotePort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broadcast";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // TBBroadcastText
            // 
            this.TBBroadcastText.Location = new System.Drawing.Point(130, 105);
            this.TBBroadcastText.Name = "TBBroadcastText";
            this.TBBroadcastText.Size = new System.Drawing.Size(100, 22);
            this.TBBroadcastText.TabIndex = 6;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(236, 19);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(665, 227);
            this.tbOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 250);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.TBBroadcastText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBRemotePort);
            this.Controls.Add(this.TBLocalPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSendBroadcast);
            this.Name = "Form1";
            this.Text = "Server Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendBroadcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBLocalPort;
        private System.Windows.Forms.TextBox TBRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBBroadcastText;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

