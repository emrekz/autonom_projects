using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace unique_id_gui
{
    public partial class Form1 : Form
    {
        private SerialPort SerPort;     //  serial port
        private string ReceivedData;    //  received data from serial port
        public Form1()
        {
            InitializeComponent();
            FetchAvaiablePorts();   //  fetch available ports.
        }

        void FetchAvaiablePorts()
        {
            String[] ports = SerialPort.GetPortNames(); //  We get available COM ports.
            AvailablePortsBox.Items.AddRange(ports);    //  Add COM ports strings in to comboBox list.
        }

        private void ConnectToPort_Click(object sender, EventArgs e)
        {
            SerPort = new SerialPort();

            /*  Serial Port Configuration  */
            SerPort.BaudRate = 9600;
            SerPort.PortName = AvailablePortsBox.Text.ToString();
            SerPort.Parity = Parity.None;
            SerPort.DataBits = 8;
            SerPort.StopBits = StopBits.One;
            SerPort.ReadBufferSize = 200000000;
            SerPort.DataReceived += SerPort_DataReceived;

            try
            {
                SerPort.Open();     // open serial port.
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...!");
            }
        }

        private void SerPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedData = SerPort.ReadLine();  // Read line from serial port.

            this.Invoke(new Action(ProcessingData));
        }

        private void ProcessingData()
        {
            ReceivedDataBox.Text += "UniqueID: " + ReceivedData.ToString() + Environment.NewLine;
        }

        private void SendSerialButton_Click(object sender, EventArgs e)
        {
            SerPort.WriteLine(SenderTextBox.Text.ToString());   //  Send command from gui to arduino via COM port.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SerPort.Close();    //  Close serial port.
            }
            catch
            {}
        }
    }
}
