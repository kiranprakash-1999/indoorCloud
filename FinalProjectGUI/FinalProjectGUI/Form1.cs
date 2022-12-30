using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectGUI
{
    public partial class Form1 : Form
    {
        // variables to receive data
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        int start, p_val, t_val, rh_val, weatherType;
        int i = 0;
        int mode = 0;
        byte[] byteData = new byte[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBox1.Items.Count == 0)
                comboBox1.Text = "No COM ports!";
            else
                comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Acquire COM port from combo box
            if (comboBox1.SelectedItem != null)
            {
                serialPort1.PortName = Convert.ToString(comboBox1.SelectedItem);
            }
            //Configure COM port on SerialPort object
        }

        private void serialButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.PortName != null)
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    serialButton.Text = "Connected";
                }
                else
                {
                    serialPort1.Close();
                    serialButton.Text = "Not Connected";
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPort1.BytesToRead;
            int newByte = 0;


            while (bytesToRead != 0)
            {
                newByte = serialPort1.ReadByte();
                dataQueue.Enqueue(newByte);
            }
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flagTextbox.Text = dataQueue.Count.ToString();
            flagLabel.Text = "Flag";
            if (dataQueue.Count > 5)
            {
                if (!dataQueue.TryDequeue(out i))
                {
                    flagLabel.Text = "0";
                }
                while (i != 255)
                {
                    dataQueue.TryDequeue(out i);
                }
                start = i;
                if (!dataQueue.TryDequeue(out p_val))
                {
                    flagLabel.Text = "1";
                }
                if (!dataQueue.TryDequeue(out t_val))
                {
                    flagLabel.Text = "2";
                }
                if (!dataQueue.TryDequeue(out rh_val))
                {
                    flagLabel.Text = "3";
                }
                if (!dataQueue.TryDequeue(out weatherType))
                {
                    flagLabel.Text = "4";
                }
                if (mode == 0)
                {
                    lightTextbox.Text = p_val.ToString();
                    tempTextbox.Text = t_val.ToString();
                    rhTextbox.Text = rh_val.ToString();
                    weatherTypeTextbox.Text = weatherType.ToString();
                }
            }
            modeTextbox.Text = mode.ToString();
        }
        private void autoButton_Click(object sender, EventArgs e)
        {
            mode = 0;
            serialPort1.Write("a");
        }
        private void sunnyButton_Click(object sender, EventArgs e)
        {
            mode = 1;
            serialPort1.Write("s");
        }

        private void cloudyButton_Click(object sender, EventArgs e)
        {
            mode = 2;
            serialPort1.Write("c");
        }

        private void rainyButton_Click(object sender, EventArgs e)
        {
            mode = 3;
            serialPort1.Write("r");
        }

        private void snowyButton_Click(object sender, EventArgs e)
        {
            mode = 4;
            serialPort1.Write("n");
        }
        private void stormyButton_Click(object sender, EventArgs e)
        {
            mode = 5;
            serialPort1.Write("t");
        }











    }
}
