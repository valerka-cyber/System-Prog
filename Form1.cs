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

namespace SystemProg
{
   
    public partial class Form1 : Form
    { 
        private bool stopPressed;                            //прервать
        private Thread progressThread;                  //вызов потока
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            stopPressed = false;
            if (progressThread == null)
            { progressThread = new Thread(ShowProgress);
                progressThread.Start(); 
            }
        }

        private void ShowProgress()
        {
            
            for (int i = 0; i <= 10; i++)
            {
                this.Invoke(
                    new Action(
                        () => { progressBar1.Value = i * 10; }
                 ));
                Thread.Sleep(500);

                if (stopPressed)
                {
                    progressThread = null;
                    break;
                }
            }
            progressThread = null;
        }

        private Thread progressThread2 = null;
        private void ShowProgress1(object pauseTime)
        {
            int pTime = Convert.ToInt32(pauseTime);
            for (int i = 0; i <= 10; i++)
            {
                this.Invoke(
                    new Action(
                        () => { progressBar1.Value = i * 10; }
                 ));
                Thread.Sleep(pTime);
                if (stopPressed)
                {
                    progressThread2 = null;
                    break;
                }
            }
            progressThread2 = null;

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stopPressed = true;
        }
      
        private void Start1_Click(object sender, EventArgs e)
        {
            progressThread2 = new Thread(ShowProgress1);
            progressThread2.Start(300);
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            stopPressed = true;
        }

        private CancellationTokenSource cts;
        private void Start3_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            new Thread(ShowProgress4).Start(cts.Token);

        }

        private void Stop3_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            
        }

        private void ShowProgress3(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            for (int i = 0; i <= 10; i++)
            {
                this.Invoke(
                    new Action(
                        () => { progressBar1.Value = i * 10; }
                 ));
                Thread.Sleep(500);

                if (token.IsCancellationRequested)
                {
                
                    break;
                }
            }
        }

        private void ShowProgress4(object obj)
        {  
            CancellationToken token = (CancellationToken)obj;
            try
            {              
                for (int i = 0; i <= 10; i++)
                {
                    this.Invoke(
                        new Action(
                            () => { progressBar1.Value = i * 10; }
                     ));
                    Thread.Sleep(500);

                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cancelled");
            }
        }
    }
}
