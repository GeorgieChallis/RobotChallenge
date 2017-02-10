namespace Comms
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
            this.btnCon = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRedStatus = new System.Windows.Forms.Label();
            this.lblGreenStatus = new System.Windows.Forms.Label();
            this.btnToggleRed = new System.Windows.Forms.Button();
            this.btnToggleGreen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosLeft = new System.Windows.Forms.Label();
            this.lblPosRight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communications";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(48, 80);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(48, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(98, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "10.215.2.36";
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRedStatus);
            this.groupBox2.Controls.Add(this.lblGreenStatus);
            this.groupBox2.Controls.Add(this.btnToggleRed);
            this.groupBox2.Controls.Add(this.btnToggleGreen);
            this.groupBox2.Location = new System.Drawing.Point(189, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LEDs and buttons";
            // 
            // lblRedStatus
            // 
            this.lblRedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedStatus.Location = new System.Drawing.Point(166, 69);
            this.lblRedStatus.Name = "lblRedStatus";
            this.lblRedStatus.Size = new System.Drawing.Size(100, 18);
            this.lblRedStatus.TabIndex = 1;
            this.lblRedStatus.Text = "Red Status";
            this.lblRedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreenStatus
            // 
            this.lblGreenStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreenStatus.Location = new System.Drawing.Point(166, 40);
            this.lblGreenStatus.Name = "lblGreenStatus";
            this.lblGreenStatus.Size = new System.Drawing.Size(100, 18);
            this.lblGreenStatus.TabIndex = 1;
            this.lblGreenStatus.Text = "Green Status";
            this.lblGreenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleRed
            // 
            this.btnToggleRed.Location = new System.Drawing.Point(21, 67);
            this.btnToggleRed.Name = "btnToggleRed";
            this.btnToggleRed.Size = new System.Drawing.Size(108, 23);
            this.btnToggleRed.TabIndex = 0;
            this.btnToggleRed.Text = "Toggle Red";
            this.btnToggleRed.UseVisualStyleBackColor = true;
            this.btnToggleRed.Click += new System.EventHandler(this.btnToggleRed_Click);
            // 
            // btnToggleGreen
            // 
            this.btnToggleGreen.Location = new System.Drawing.Point(21, 38);
            this.btnToggleGreen.Name = "btnToggleGreen";
            this.btnToggleGreen.Size = new System.Drawing.Size(108, 23);
            this.btnToggleGreen.TabIndex = 0;
            this.btnToggleGreen.Text = "Toggle Green";
            this.btnToggleGreen.UseVisualStyleBackColor = true;
            this.btnToggleGreen.Click += new System.EventHandler(this.btnToggleGreen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblPosRight);
            this.groupBox3.Controls.Add(this.lblPosLeft);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(490, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Starboard:";
            // 
            // lblPosLeft
            // 
            this.lblPosLeft.AutoSize = true;
            this.lblPosLeft.Location = new System.Drawing.Point(84, 33);
            this.lblPosLeft.Name = "lblPosLeft";
            this.lblPosLeft.Size = new System.Drawing.Size(13, 13);
            this.lblPosLeft.TabIndex = 0;
            this.lblPosLeft.Text = "0";
            // 
            // lblPosRight
            // 
            this.lblPosRight.AutoSize = true;
            this.lblPosRight.Location = new System.Drawing.Point(84, 72);
            this.lblPosRight.Name = "lblPosRight";
            this.lblPosRight.Size = new System.Drawing.Size(13, 13);
            this.lblPosRight.TabIndex = 0;
            this.lblPosRight.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 154);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "2nd Year Challenge - Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRedStatus;
        private System.Windows.Forms.Label lblGreenStatus;
        private System.Windows.Forms.Button btnToggleRed;
        private System.Windows.Forms.Button btnToggleGreen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosRight;
        private System.Windows.Forms.Label lblPosLeft;
        private System.Windows.Forms.Label label2;
    }
}

