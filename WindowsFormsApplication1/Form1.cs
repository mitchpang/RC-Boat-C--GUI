using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            speedTrackbar.Orientation = Orientation.Vertical;
            speedTrackbar.Height = angularTrackbar.Width;
            angularTrackbar.Value = 5;
            speedTrackbar.Value = 5;
            KeyPreview = true;
            decreaseAngularButton.Font = new Font(decreaseAngularButton.Font.FontFamily, 14);
            decreaseAngularButton.Text = "Speed Left";
            increaseAngularButton.Font = new Font(increaseAngularButton.Font.FontFamily, 14);
            increaseAngularButton.Text = "Speed Right";
            increaseSpeedButton.Font = new Font(increaseSpeedButton.Font.FontFamily, 14);
            increaseSpeedButton.Text = "Speed Up";
            decreaseSpeedButton.Font = new Font(decreaseSpeedButton.Font.FontFamily, 14);
            decreaseSpeedButton.Text = "Speed Down";
            button5.Font = new Font(button5.Font.FontFamily, 14);
            button5.Text = "Reset";
            label5.Font = new Font(label5.Font.FontFamily, 16);  
            label5.Text = "RoboBoat Speed Control";
            commSelect.DataSource = Communication.commNames;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decreaseAngular(Constants.speedIncrement);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            increaseAngular(Constants.speedIncrement);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            increaseLinear(Constants.speedIncrement);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decreaseLinear(Constants.speedIncrement);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speedTrackbar.Value = 0;
            angularTrackbar.Value = 0;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Communication.angular = ((float)angularTrackbar.Value) / 500.0f;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            Communication.forward = ((float)speedTrackbar.Value) / 500.0f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enablePID_CheckedChanged(object sender, EventArgs e)
        {
            Communication.PID_enabled = enablePID.Checked ? 1 : 0;
        }

        private void enableMotors_CheckedChanged(object sender, EventArgs e)
        {
            Communication.motors_enabled = enableMotors.Checked ? 1 : 0;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private static bool portOpened = false;

        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (!portOpened)
            {
                Communication.selectedComm = Communication.commNames[commSelect.SelectedIndex];
                Communication.commThread.Start();
                portOpened = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                increaseLinear(Constants.speedIncrement);
            } 
            else if (e.KeyCode == Keys.Down) {
                decreaseLinear(Constants.speedIncrement);
            }
            else if (e.KeyCode == Keys.Left)
            {
                decreaseAngular(Constants.speedIncrement);
            }
            else if (e.KeyCode == Keys.Right)
            {
                increaseAngular(Constants.speedIncrement);
            }
        }



        //Utility functions for changing trackbar values (and therefore speeds)
        private void increaseLinear(int amount)
        {
            speedTrackbar.Value = Math.Min(speedTrackbar.Value + amount, speedTrackbar.Maximum);
        }

        private void decreaseLinear(int amount)
        {
            speedTrackbar.Value = Math.Max(speedTrackbar.Value - amount, speedTrackbar.Minimum);
        }

        private void increaseAngular(int amount)
        {
            angularTrackbar.Value = Math.Min(angularTrackbar.Value + amount, angularTrackbar.Maximum);
        }

        private void decreaseAngular(int amount)
        {
            angularTrackbar.Value = Math.Max(angularTrackbar.Value - amount, angularTrackbar.Minimum);
        }

        private void PIDProgramButton_Click(object sender, EventArgs e)
        {
            Communication.linearPGain = Decimal.ToSingle(linPUpDown.Value);
            Communication.linearIGain = Decimal.ToSingle(linIUpDown.Value);
            Communication.linearDGain = Decimal.ToSingle(linDUpDown.Value);
            Communication.angularPGain = Decimal.ToSingle(angPUpDown.Value);
            Communication.angularIGain = Decimal.ToSingle(angIUpDown.Value);
            Communication.angularDGain = Decimal.ToSingle(angDUpDown.Value);

            Communication.reprogramPID = true;
        }

    }
}
