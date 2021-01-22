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



namespace BaguetteMagique
{
    public partial class Form1 : Form
    {
        public static string spell1_name = "alohomora";
        public static string spell2_name = "ventus";
        public static string spell3_name = "wingardium_leviosa";

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] strPortName = SerialPort.GetPortNames();
            foreach(string n in strPortName)
            {
                PortBox.Items.Add(n);
            }
            PortBox.SelectedIndex = 0;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = PortBox.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;

            try
            {       
                serialPort1.Open();
                SerialDataLabel.Visible = true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data_rx = serialPort1.ReadLine();
            SerialDataLabel.Text = data_rx;

            if (data_rx.StartsWith(spell1_name))
            {
                pictureBox1.Image = Image.FromFile(@"C:\ProjetBaguetteMagique\alohomora.png");
            }

            if (data_rx.StartsWith(spell2_name))
            {              
                pictureBox1.Image = Image.FromFile(@"C:\ProjetBaguetteMagique\ventus.png");
            }

            if (data_rx.StartsWith(spell3_name))
            {
                pictureBox1.Image = Image.FromFile(@"C:\ProjetBaguetteMagique\wingardium_leviosa.png");
            }
        }
    }
}
