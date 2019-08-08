using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //the COM port of my Arduino
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
        }
    }
}
