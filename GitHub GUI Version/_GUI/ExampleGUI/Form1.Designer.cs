using System;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosRight = new System.Windows.Forms.Label();
            this.lblPosLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.LightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button14 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button15 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communications";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(73, 62);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(65, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(98, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "10.215.2.36";
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
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
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LEDs and buttons";
            // 
            // lblRedStatus
            // 
            this.lblRedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedStatus.Location = new System.Drawing.Point(166, 53);
            this.lblRedStatus.Name = "lblRedStatus";
            this.lblRedStatus.Size = new System.Drawing.Size(100, 18);
            this.lblRedStatus.TabIndex = 1;
            this.lblRedStatus.Text = "Red Status";
            this.lblRedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreenStatus
            // 
            this.lblGreenStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreenStatus.Location = new System.Drawing.Point(166, 19);
            this.lblGreenStatus.Name = "lblGreenStatus";
            this.lblGreenStatus.Size = new System.Drawing.Size(100, 18);
            this.lblGreenStatus.TabIndex = 1;
            this.lblGreenStatus.Text = "Green Status";
            this.lblGreenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleRed
            // 
            this.btnToggleRed.Location = new System.Drawing.Point(21, 48);
            this.btnToggleRed.Name = "btnToggleRed";
            this.btnToggleRed.Size = new System.Drawing.Size(108, 23);
            this.btnToggleRed.TabIndex = 0;
            this.btnToggleRed.Text = "Toggle Red";
            this.btnToggleRed.UseVisualStyleBackColor = true;
            this.btnToggleRed.Click += new System.EventHandler(this.btnToggleRed_Click);
            // 
            // btnToggleGreen
            // 
            this.btnToggleGreen.Location = new System.Drawing.Point(21, 19);
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
            this.groupBox3.Location = new System.Drawing.Point(536, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tracks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Starboard:";
            // 
            // lblPosRight
            // 
            this.lblPosRight.AutoSize = true;
            this.lblPosRight.Location = new System.Drawing.Point(196, 24);
            this.lblPosRight.Name = "lblPosRight";
            this.lblPosRight.Size = new System.Drawing.Size(13, 13);
            this.lblPosRight.TabIndex = 0;
            this.lblPosRight.Text = "0";
            // 
            // lblPosLeft
            // 
            this.lblPosLeft.AutoSize = true;
            this.lblPosLeft.Location = new System.Drawing.Point(84, 24);
            this.lblPosLeft.Name = "lblPosLeft";
            this.lblPosLeft.Size = new System.Drawing.Size(13, 13);
            this.lblPosLeft.TabIndex = 0;
            this.lblPosLeft.Text = "0";
            this.lblPosLeft.Click += new System.EventHandler(this.lblPosLeft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Forward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 48);
            this.button4.TabIndex = 13;
            this.button4.Text = "Left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 49);
            this.button5.TabIndex = 14;
            this.button5.Text = "Right";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(301, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 49);
            this.button6.TabIndex = 15;
            this.button6.Text = "STOP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "DistanceToTravel (cm)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(395, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "Anti-Clockwise";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(395, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Clockwise";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Angle To Move (Deg)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(337, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 23);
            this.button9.TabIndex = 24;
            this.button9.Text = "Go";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 250;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(49, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "Spatial Vortex";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(257, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "Light Tunnel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(49, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 23);
            this.button10.TabIndex = 32;
            this.button10.Text = "Seismic Activity";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(53, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 23);
            this.button11.TabIndex = 33;
            this.button11.Text = "Weigh Objects";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(53, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 23);
            this.button12.TabIndex = 34;
            this.button12.Text = "Draw Star";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Idle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Idle";
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(49, 83);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 37;
            this.button13.Text = "Get Turns";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "label6";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(398, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 389);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(525, 62);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 389);
            this.listView2.TabIndex = 40;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // LightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LightChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.LightChart.Legends.Add(legend1);
            this.LightChart.Location = new System.Drawing.Point(25, 102);
            this.LightChart.Name = "LightChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.LightChart.Series.Add(series1);
            this.LightChart.Size = new System.Drawing.Size(357, 294);
            this.LightChart.TabIndex = 41;
            this.LightChart.Text = "chart1";
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Location = new System.Drawing.Point(91, 62);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 23);
            this.button14.TabIndex = 42;
            this.button14.Text = "Detect";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Location = new System.Drawing.Point(158, 62);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 23);
            this.button15.TabIndex = 43;
            this.button15.Text = "Clear";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "label7";
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(80, 51);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 45;
            this.button16.Text = "Toggle Pen";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "label9";
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(225, 62);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(126, 23);
            this.button17.TabIndex = 48;
            this.button17.Text = "Into the tunnel 5cm";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(21, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 222);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spatial Vortex";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(21, 352);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 100);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seismic Activity";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Location = new System.Drawing.Point(301, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(256, 100);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Draw Star";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Location = new System.Drawing.Point(301, 124);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 222);
            this.groupBox7.TabIndex = 52;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Weigh Objects";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button8);
            this.groupBox8.Controls.Add(this.LightChart);
            this.groupBox8.Controls.Add(this.listView1);
            this.groupBox8.Controls.Add(this.listView2);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.button17);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.button15);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.button14);
            this.groupBox8.Location = new System.Drawing.Point(569, 124);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(657, 471);
            this.groupBox8.TabIndex = 53;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Light Tunnel";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.button5);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Location = new System.Drawing.Point(808, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(418, 90);
            this.groupBox9.TabIndex = 54;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Movement Buttons";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.textBox2);
            this.groupBox10.Controls.Add(this.button9);
            this.groupBox10.Controls.Add(this.radioButton1);
            this.groupBox10.Controls.Add(this.radioButton2);
            this.groupBox10.Location = new System.Drawing.Point(21, 463);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(536, 132);
            this.groupBox10.TabIndex = 55;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Precise Movement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 607);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "2nd Year Challenge - Team 6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveBackward(200);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart LightChart;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}

