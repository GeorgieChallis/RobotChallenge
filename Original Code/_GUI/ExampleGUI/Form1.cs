using System;
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
