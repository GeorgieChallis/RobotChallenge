﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommsLib;
using System.Diagnostics;
using System.Threading.Tasks;


namespace Comms
{
    public partial class Form1 : Form


    {
        //----STATE SELECTION - Enum used to track which task has been selected. Set by buttons
        enum taskState { Idle, SpatialVortex, LightTunnel, SeismicActivity, WeighObjects, DrawStar };
        int currentState = (int)taskState.Idle;

        //----Buttons for state selection
        private void button7_Click(object sender, EventArgs e) //Spatial Vortex Button
        {
            currentState = (int)taskState.SpatialVortex;
            SpatialVortex();
        }

        private void button8_Click_2(object sender, EventArgs e) //Light Tunnel Button
        {
            currentState = (int)taskState.LightTunnel;
        }

        private void button10_Click(object sender, EventArgs e) //Seismic Activity Button
        {
            currentState = (int)taskState.SeismicActivity;
            SeismicActivity();
        }

        private void button11_Click(object sender, EventArgs e) //Weigh Objects Button
        {
            currentState = (int)taskState.WeighObjects;
        }

        private void button12_Click(object sender, EventArgs e) //Draw Star Button
        {
            currentState = (int)taskState.DrawStar;
        }


        //----- GLOBAL VARIABLES
        // Accelerometer Values:
        int accX, accY, accZ;

        //Magnetometer Values:
        short magX, magY, magZ;
        double magMax, magMin;
        double compass = 0;

        //Movement variables:
        double startingAngle;
        double newAngle; //Angle we wish to move it by total
        bool clockwise = true;
        int distanceValue; //Distance to move forward/backwards (in cm)

        //Seismic Activity Variables
        MLApp.MLApp matlab; //Declare matlab object
        bool sampleSeismic = false; //Flag to start sampling of SeismicActivity (allows button to stop it)

        //Light Tunnel Variables
        uint light; //value for tunnel
        uint last_light; //value for tunnel
        uint light_index = 0;
        uint[] light_peak = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bool got_max = false;
        bool forward = true;
        int travel;
        Stopwatch sw = new Stopwatch();

        //Spatial Vortex Variables
        bool sampleSpatial = false;
        List<double> magValues = new List<double>();

        //----- MYCLIENT CODE - DO NOT DELETE!
        public Form1()
        {
            InitializeComponent();
            myClient = new TCPClient();
            myClient.OnMessageReceived += new ClientBase.ClientMessageReceivedEvent(myClient_OnMessageReceived);

            myRequestTimer = new Timer();
            myRequestTimer.Interval = 100; //**Changed from 500
            myRequestTimer.Tick += new EventHandler(myRequestTimer_Tick);
        }

        TCPClient myClient;
        private void btnCon_Click(object sender, EventArgs e)
        {
            if ("Connect" == btnCon.Text)
            {
                try
                {
                    myClient.ConnectToServer(txtIP.Text, 9760);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                    return;
                }

                //if we get here, then we are connected
                btnCon.Text = "Disconnect";

                myRequestTimer.Start();
            }
            else
            {
                myRequestTimer.Stop();
                myClient.Disconnect();
                if (!myClient.isConnected) btnCon.Text = "Connect";
            }
        }

        short leftPos, rightPos;

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCon_Click(sender, null);
                btnToggleGreen.Focus();
            }
        }


        //------ START ON MESSAGE RECEIVED PROCEDURE
        void myClient_OnMessageReceived(Client_Message_EventArgs e)
        {
            //we shall process the message here, e.RawMessage contains all bytes
            // [0] is 255, [1] is length, [2] 255, [3] is cmd, [4-] are payload
            if (e.RawMessage[3] == (byte)CommandID.GetLEDandSwitchStatus)
            {
                //we have received an LED status, so let's change labels accordingly
                bool bGreenOn = (((e.RawMessage[4] & 0x10) == 0) ? true : false);
                bool bRedOn = (((e.RawMessage[4] & 0x20) == 0) ? true : false);

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
                double magXN = magX - ((-931 + -1507) / 2);
                double magYN = magY - ((2947 + 2320) / 2);
                compass = Math.Atan2(magYN, magXN) * (180 / 3.14);
                if (compass < 0)
                {
                    compass = compass + 360;
                }
            }

           if (e.RawMessage[3] == (byte)CommandID.SeismicActivity) //Seismic Activity Results
           {
               //Quick read z-axis of accel.
               accZ = (short)((((int)e.RawMessage[4] << 8) | (int)(e.RawMessage[5])) >> 2);
               StreamWriter file1 = new StreamWriter("C:\\Users\\Georgina\\Desktop\\Robotics Challenge HHA\\GCSeismicActivity.txt", true);
               file1.WriteLine(accZ);
               file1.Close();
           }

           if (e.RawMessage[3] == (byte)CommandID.SpatialVortex) {
                magX = (short)(((int)e.RawMessage[4] << 8) | (int)e.RawMessage[5]);
                magY = (short)(((int)e.RawMessage[6] << 8) | (int)e.RawMessage[7]);
                double magXN = magX - ((-931 + -1507) / 2);
                double magYN = magY - ((2947 + 2320) / 2);
                compass = Math.Atan2(magYN, magXN) * (180 / 3.14);
                if (compass < 0){
                    compass = compass + 360;
                }
                magValues.Add(compass);
                //StreamWriter file1 = new StreamWriter("C:\\Users\\Georgina\\Desktop\\Robotics Challenge HHA\\GCSpatialVortex.txt", true);
                //file1.WriteLine(compass);
                //file1.Close();

            }
        }

    //----- MY REQUEST TIMER
        Timer myRequestTimer;
        void myRequestTimer_Tick(object sender, EventArgs e)
        {
            if (!myClient.isConnected) return; //if no connection, don't do anything

            //we will request the status of the LEDs on a regular basis
            myClient.SendData(CommandID.GetLEDandSwitchStatus); //this type needs no payload
            myClient.SendData(CommandID.MotorPosition);

            lblPosLeft.Text = leftPos.ToString(); //Update position values
            lblPosRight.Text = rightPos.ToString();
        }

        Boolean bGreenRequestOn = true;
        Boolean bRedRequestOn = true;

    //----- TOGGLE LEDs
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


    //----- Clean up our mess if user clicks the X button, hits AltF4 etc
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRequestTimer.Stop(); //just in case ;-)
            if (myClient.isConnected) myClient.Disconnect();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

   //----- MOVEMENT VIA ARROW KEYS
        bool robotIsMoving = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 60, 60 });
                    robotIsMoving = true;
                    e.Handled = true;
                    break;

                case Keys.Down:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 200, 200 });
                    robotIsMoving = true;
                    e.Handled = true;
                    break;

                case Keys.Left:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 190, 60 });
                    robotIsMoving = true;
                    e.Handled = true;
                    break;
                case Keys.Right:
                    myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 60, 190 });
                    robotIsMoving = true;
                    e.Handled = true;
                    break;

                default:
                    e.Handled = false;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (robotIsMoving)
            {
                myClient.SendData(CommandID.SetMotorsSpeed, new byte[] { 0, 0 });
                robotIsMoving = false;
            }
        }


        private void timer2_Tick(object sender, EventArgs e) //Constantly update readings
        {
            if (!myClient.isConnected) return;
           // myClient.SendData(CommandID.GetMagnetValue);
           // myClient.SendData(CommandID.GetAccelValue);
        }

   //----- MOVEMENT VIA BUTTON PRESSES
        public bool MoveForward(int inputTime)
        {
            timer3.Interval = inputTime;
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 59, 0, 61, 0, 1 });
            //SpeedL, 0, SpeedR, 0, 1 to call closedloop
            timer3.Enabled = true;
            robotIsMoving = true;
            return robotIsMoving;
        }

        public bool MoveBackward(int inputTime)
        {
            timer3.Interval = inputTime;
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 200, 0, 200, 0, 1 });
            //SpeedL, 0, SpeedR, 0, 1 to call closedloop
            timer3.Enabled = true;
            robotIsMoving = true;
            return robotIsMoving;
        }

        public void MoveLeft()
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 252, 0, 3, 0, 1 });
            robotIsMoving = true;
        }

        public void MoveRight()
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 3, 0, 252, 0, 1 });
            robotIsMoving = true;
        }

        public bool StopMoving()
        {
            myClient.SendData(CommandID.MotorSpeedClosed, new byte[] { 0, 0, 0, 0, 1 });
            robotIsMoving = false;
            return robotIsMoving;
        }

        //Move forward button
        private void button2_Click_1(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            MoveForward(1000); //Arbitrary value to get it to move, can be changed
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
            StopMoving();
            timer4.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e) //Go button (enter distance to move)
        {
            distanceValue = Convert.ToInt32(textBox1.Text);
            distanceValue = int.Parse(textBox1.Text);

            if (distanceValue > 0)                             //for forwards
            {
                int time = 0;
                int time2 = 0;
                float dist = 0;
                if (distanceValue > 8)                         //initial 7 cm is weird
                {
                    distanceValue = distanceValue - 8;
                    time = 500;                                 //the initial 7 cm takes 500ms
                    dist = distanceValue;                       //make remaining distance a float for division
                    time2 = (int)((dist / 15) * 500);           //get the remaining time working, moves 12cm in 500ms
                    time = time + time2;
                }
                MoveForward(time);                              //calls move fowrward function, for the time needed
            }
            if (distanceValue < 0)
            {
                distanceValue = Math.Abs(distanceValue);        //needs calibrating but the same principle as before
                int time = 0;
                int time2 = 0;
                float dist = 0;
                if (distanceValue > 0)
                {
                    distanceValue = distanceValue - 0;
                    time = 500;
                    dist = distanceValue;
                    time2 = (int)((dist / 17) * 500);
                    time = time + time2;
                }
                MoveBackward(time);
            }
        }

        private void timer3_Tick(object sender, EventArgs e){
            timer3.Enabled = false;
            StopMoving();
        }


        private void timer4_Tick(object sender, EventArgs e){
            checkAndTurn(newAngle);
        }

        private void checkAndTurn(double inputAngle)
        {
            if (clockwise)
            {
                if (compass > (inputAngle + 5))
                {
                    MoveRight();
                }
                if (compass < (inputAngle - 5)) //Use newAngle in here
                {
                    MoveRight();
                }
                else
                {
                    label14.Text = "Finished rotation";
                    timer4.Enabled = false;
                    StopMoving();
                }
            }
            else if (!clockwise)
            {
                if (compass < (inputAngle - 5)) //Use newAngle in here
                {
                    MoveLeft();
                }
                if (compass > (inputAngle + 5))
                {
                    MoveLeft();
                }
                else
                {
                    label14.Text = "Finished rotation";
                    timer4.Enabled = false;
                    StopMoving();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e) //angle Go button
        {
            startingAngle = compass;
            newAngle = Convert.ToDouble(textBox2.Text) + startingAngle; //takes in the value
            if (newAngle > 360)
            {
                newAngle -= 360;
            }
            if (newAngle < 0)
            {
                newAngle += 360;
            }
            //newAngle = newAngle * 0.95;
            timer4.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)  {
            clockwise = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){
            clockwise = false;
        }



    //-----SEISMIC ACTIVITY FUNCTION

        void SeismicActivity()
        {
            sampleSeismic = !sampleSeismic;
            myClient.SendData(CommandID.SeismicActivity);
            if (sampleSeismic == true) label4.Text = "Running...";
            else
            {
                label4.Text = "Idle";

                object res; //dummy object to staisfy the needs of matlab
                matlab = new MLApp.MLApp();
                matlab.Execute("C:\\Program Files\\MATLAB\\R2015b\\bin\\matlab.exe");
                matlab.Feval("SeismicFFT", 0, out res);
            }
        }

        //------SPATIAL VORTEX FUNCTION

        void SpatialVortex()
        {
            sampleSpatial = !sampleSpatial;
            myClient.SendData(CommandID.SpatialVortex);
            if (sampleSpatial == true) label5.Text = "Running...";
            else
            {
                label5.Text = "Idle";

                object res; //dummy object to staisfy the needs of matlab
                matlab = new MLApp.MLApp();
                matlab.Execute("C:\\Program Files\\MATLAB\\R2015b\\bin\\matlab.exe");
                matlab.Feval("SeismicFFT", 0, out res);
            }
        }

    //----- EMPTY METHODS (LABELS ETC)
    private void textBox1_TextChanged(object sender, EventArgs e) //used for entering distance to travel
        {
            // converting the text from the textbox to an int

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // converting the text from the textbox to an int
            //requestedAngle = Convert.ToDouble(textBox2.Text);
            //requestedAngle = Double.Parse(textBox2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
        { }

        private void groupBox6_Enter(object sender, EventArgs e)
        { }
    }
}

