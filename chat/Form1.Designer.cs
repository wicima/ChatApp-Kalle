﻿namespace chat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.edtServerPort = new System.Windows.Forms.TextBox();
            this.edtServerIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.edtClientIP = new System.Windows.Forms.TextBox();
            this.edtClientPort = new System.Windows.Forms.TextBox();
            this.redtHistory = new System.Windows.Forms.RichTextBox();
            this.edtToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Controls.Add(this.edtServerPort);
            this.groupBox1.Controls.Add(this.edtServerIP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1005, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "5000->";
            // 
            // btnServerStart
            // 
            this.btnServerStart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnServerStart.Location = new System.Drawing.Point(884, 31);
            this.btnServerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(112, 35);
            this.btnServerStart.TabIndex = 2;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // edtServerPort
            // 
            this.edtServerPort.Location = new System.Drawing.Point(724, 31);
            this.edtServerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtServerPort.Name = "edtServerPort";
            this.edtServerPort.Size = new System.Drawing.Size(148, 26);
            this.edtServerPort.TabIndex = 1;
            // 
            // edtServerIP
            // 
            this.edtServerIP.Location = new System.Drawing.Point(27, 31);
            this.edtServerIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtServerIP.Name = "edtServerIP";
            this.edtServerIP.Size = new System.Drawing.Size(686, 26);
            this.edtServerIP.TabIndex = 0;
            this.edtServerIP.TextChanged += new System.EventHandler(this.edtServerIP_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClientStart);
            this.groupBox2.Controls.Add(this.edtClientIP);
            this.groupBox2.Controls.Add(this.edtClientPort);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(18, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1005, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnClientStart
            // 
            this.btnClientStart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClientStart.Location = new System.Drawing.Point(884, 38);
            this.btnClientStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(112, 35);
            this.btnClientStart.TabIndex = 3;
            this.btnClientStart.Text = "Connect";
            this.btnClientStart.UseVisualStyleBackColor = true;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click);
            // 
            // edtClientIP
            // 
            this.edtClientIP.Location = new System.Drawing.Point(27, 42);
            this.edtClientIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtClientIP.Name = "edtClientIP";
            this.edtClientIP.Size = new System.Drawing.Size(686, 26);
            this.edtClientIP.TabIndex = 2;
            // 
            // edtClientPort
            // 
            this.edtClientPort.Location = new System.Drawing.Point(724, 42);
            this.edtClientPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtClientPort.Name = "edtClientPort";
            this.edtClientPort.Size = new System.Drawing.Size(148, 26);
            this.edtClientPort.TabIndex = 1;
            // 
            // redtHistory
            // 
            this.redtHistory.Location = new System.Drawing.Point(18, 265);
            this.redtHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redtHistory.Name = "redtHistory";
            this.redtHistory.Size = new System.Drawing.Size(1005, 146);
            this.redtHistory.TabIndex = 2;
            this.redtHistory.Text = "";
            // 
            // edtToSend
            // 
            this.edtToSend.Location = new System.Drawing.Point(18, 421);
            this.edtToSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtToSend.Name = "edtToSend";
            this.edtToSend.Size = new System.Drawing.Size(872, 26);
            this.edtToSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(911, 421);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 37);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1034, 468);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtToSend);
            this.Controls.Add(this.redtHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtServerPort;
        private System.Windows.Forms.TextBox edtServerIP;
        private System.Windows.Forms.TextBox edtClientIP;
        private System.Windows.Forms.TextBox edtClientPort;
        private System.Windows.Forms.RichTextBox redtHistory;
        private System.Windows.Forms.TextBox edtToSend;
        private System.Windows.Forms.Button btnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.Label label1;
    }
}

