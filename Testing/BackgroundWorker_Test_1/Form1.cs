using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker_Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct DataParamerter
        {
            public int Process;
            public int Delay;
        }

        private DataParamerter _inputParameter;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                _inputParameter.Delay = 100;
                _inputParameter.Process = 1200;
                backgroundWorker1.RunWorkerAsync(_inputParameter);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParamerter)e.Argument).Process;
            int delay = ((DataParamerter)e.Argument).Delay;
            int index = 1;
            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(string.Format("Error occurred : {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = string.Format("Processing....{0}%", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process has been completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
