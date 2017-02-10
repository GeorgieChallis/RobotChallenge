﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommsLib;

namespace Comms
{
    public partial class Form1 : Form
    {
        //List all variables here as global
        int accX; // Accelerometer Values
        int accY; 
        int accZ;

        short magX; //Magnetometer Values
        short magY;
        short magZ;
        double magMax;
        double magMin;
        double compass;

        public Form1()
        {
            InitializeComponent();
            myClient = new TCPClient();
            myClient.OnMessageReceived += new ClientBase.ClientMessageReceivedEvent(myClient_OnMessageReceived);

            myRequestTimer = new Timer();
            myRequestTimer.Interval = 500; //every half a second
            myRequestTimer.Tick += new EventHandler(myRequestTimer_Tick);
        }

        TCPClient myClient;
        private void btnCon_Click(object sender, EventArgs e)
        {
            if ("Connect" == btnCon.Text)
            {
                try
                {
                    myClient.ConnectToServer(txtIP.Text,9760);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"\r\n"+ex.StackTrace);
                    return;
                }

                //if we get here, then we are connected
                btnCon.Text="Disconnect";
                
                myRequestTimer.Start();
            }
            else
            {
                myRequestTimer.Stop();
                myClient.Disconnect();
                if (!myClient.isConnected) btnCon.Text="Connect";
            }
        }

        short leftPos, rightPos;
        void myClient_OnMessageReceived(Client_Message_EventArgs e)
        {
            //we shall process the message here, e.RawMessage contains all bytes
            // [0] is 255, [1] is length, [2] 255, [3] is cmd, [4-] are payload
            if (e.RawMessage[3] == (byte)CommandID.GetLEDandSwitchStatus)
            {
                //we have received an LED status, so let's change labels accordingly
                bool bGreenOn = (((e.RawMessage[4] & 0x10) ==0 ) ? true : false);
                bool bRedOn =   (((e.RawMessage[4] & 0x20) ==0 ) ? true : false);

                lblGreenStatus.BackColor = ((bGreenOn) ? Color.LimeGreen : SystemColors.ButtonFace);
                lblRedStatus.BackColor = ((bRedOn) ? Color.Red : SystemColors.ButtonFace);
            }

            if (e.RawMessage[3] == (byte)CommandID.MotorPosition)
            {
                leftPos = (short)((uint)e.RawMessage[6] | ((uint)e.RawMessage[5] << 8));
                rightPos = (short)((uint)e.RawMessage[9] | ((uint)e.RawMessage[8] << 8));
            }

            if (e.RawMessage[3] == (byte)CommandID.GetAccelValue)
            {
                accX = (int)(e.RawMessage[5] | (e.RawMessage[4] >> 6));
                accY = (int)(e.RawMessage[7] | (e.RawMessage[6] >> 6));
                accZ = (int)(e.RawMessage[9] | (e.RawMessage[8] >> 6));
            }


            if (e.RawMessage[3] == (byte)CommandID.GetMagnetValue)
            {
                magX = (short)(((int)e.RawMessage[4] << 8) | (int)e.RawMessage[5]);
                magY = (short)(((int)e.RawMessage[6] << 8) | (int)e.RawMessage[7]);
                magZ = (short)(((int)e.RawMessage[8] << 8) | (int)e.RawMessage[9]);
                double magXN = magX - ((3000 + 3000) / 2);
                double magYN = magY - ((3000 + 3000) / 2);
                compass = Math.Atan2(magYN, magXN) * (180 / 3.14);
            }
        }
    

        Timer myRequestTimer;
        void myRequestTimer_Tick(object sender, EventArgs e)
        {
            if (!myClient.isConnected) return; //if no connection, don't do anything

            //we will request the status of the LEDs on a regular basis
            myClient.SendData(CommandID.GetLEDandSwitchStatus); //this type needs no payload
            myClient.SendData(CommandID.MotorPosition);

            lblPosLeft.Text = leftPos.ToString();
            lblPosRight.Text = rightPos.ToString();
        }

        Boolean bGreenRequestOn = true;
        Boolean bRedRequestOn = true;

        private void btnToggleGreen_Click(object sender, EventArgs e)
        {
            if (!myClient.isConnected) return;

            bGreenRequestOn = !bGreenRequestOn; //change from last time

            int value = 0;
            if (bGreenRequestOn) value |= 0x01;
            if (bRedRequestOn) value |= 0x02;

            myClient.SendData(CommandID.SetLEDs, new byte[] { (byte)value });
        }

        private void btnToggleRed_Click(object sender, EventArgs e)
        {
            if (!myClient.isConnected) return;

            bRedRequestOn = !bRedRequestOn; //change from last time

            int value = 0;
            if (bGreenRequestOn) value |= 0x01;
            if (bRedRequestOn) value |= 0x02;

            myClient.SendData(CommandID.SetLEDs, new byte[] { (byte)value });
        }


        //Clean up our mess if user clicks the X button, hits AltF4 etc
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRequestTimer.Stop(); //just in case ;-)
            if (myClient.isConnected) myClient.Disconnect();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        bool robotIsMoving = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 60, 60 });
                    robotIsMoving = true;
                    e.Handled=true;
                    break;

                case Keys.Down:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 200, 200 });
                    robotIsMoving = true;
                    e.Handled=true;
                    break;

                case Keys.Left:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 190, 60 });
                    robotIsMoving = true;
                    e.Handled=true;
                    break;
                case Keys.Right:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 60, 190 });
                    robotIsMoving = true;
                    e.Handled=true;
                    break;

                default: e.Handled=false;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (robotIsMoving)
            {
                myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 0,0 });
                robotIsMoving = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = accX.ToString(); //Update accelerometer values
            label5.Text = accY.ToString();
            label6.Text = accZ.ToString();

            label7.Text = magX.ToString(); //Update magnetometer values
            label8.Text = magY.ToString();
            label9.Text = magZ.ToString();
            label10.Text = compass.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!myClient.isConnected) return;
            myClient.SendData(CommandID.GetMagnetValue);
                        myClient.SendData(CommandID.GetAccelValue);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Move forward button
        private void button2_Click_1(object sender, EventArgs e) 
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 60, 0, 60, 0, 1 }); 
                                                    //SpeedL, 0, SpeedR, 0, 1 to call closedloop
            robotIsMoving = true;
        }

        //Move down
        private void button3_Click(object sender, EventArgs e)
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 200, 0, 200, 0, 1 });
            robotIsMoving = true;
        }

        //Move left
        private void button4_Click(object sender, EventArgs e)
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 190, 0, 60, 0, 1 });
            robotIsMoving = true;
        }

        //Move right
        private void button5_Click(object sender, EventArgs e)
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 60, 0, 190, 0, 1 });
            robotIsMoving = true;
        }

        //Stop
        private void button6_Click(object sender, EventArgs e)
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 0, 0, 0, 0, 1 });
            robotIsMoving = false;
        }

        private void lblPosLeft_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCon_Click(sender, null);
                btnToggleGreen.Focus();
            }
        }
    }
}
