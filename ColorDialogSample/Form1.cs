using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ColorDialogSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ForegroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;
                     
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
   
                listBox1.ForeColor = colorDlg.Color;

            }
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
  
                listBox1.BackColor = colorDlg.Color;
         
                serialPort1.Write("R"+colorDlg.Color.R+","+colorDlg.Color.G+","+colorDlg.Color.B + "\n");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;

            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write("S");
            label1.Text = serialPort1.ReadLine();
        }

    }
}
