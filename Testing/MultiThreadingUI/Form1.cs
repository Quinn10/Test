using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreadingUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread thRed;
        Thread thBlue;
        Random rdm;

        private void btnRed_Click(object sender, EventArgs e)
        {
            thRed = new Thread(threadRed);
            thRed.Start();
        }


        public void threadRed()
        {
            for (int i = 0; i < 100; i++)
            {
                CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(10);
            }            
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            thBlue = new Thread(threadBlue);
            thBlue.Start();

        }

        public void threadBlue()
        {
            for (int i = 0; i < 100; i++)
            {
                CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }
    }
}
