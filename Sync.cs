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
    public partial class Sync : Form
    {
        private Random rnd = new Random();
        Action<String> Log;
        public Sync()
        {
            InitializeComponent();
            Log = new Action<string>(log);
        }
        #region Threads
        private void Sync_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            result = 100;
            ConsoleLog.Items.Add("Start.....");
            for(int i = 1; i<=12;++i)
            {
                new Thread(AddPercent).Start(i);
            }
        }

        double result;
        object resLocer = new object();
     
        private void AddPercent(object month)
        {
            lock (resLocer)
            {
                double tmp = result;
                  Thread.Sleep(rnd.Next(100,200));
                tmp *= 1.1;
                result = tmp;
                Invoke(new Action(() => ConsoleLog.Items.Add(
                   String.Format(
                       "{0} - {1}",
                       Convert.ToInt32(month),
                       result
                   ))));
            }
        }

        private void log (String str)
        {
            ConsoleLog.Items.Add(str);
        }

        Thread t1; 
        private int cnt;
        delegate void callback();     

        private void fin()
        {
            Invoke(Log, new object[] { "CallBack - fin" });
        }
        private void Proc1()
        {
            this.Invoke(Log, new object[] { "Proc1 start"});           
            Thread.Sleep(rnd.Next(100, 200));
            Invoke(Log, new object[] { "Proc1 end" });

        } 
        private void Proc2()
        {
            t1.Join();
            Invoke(Log, new object[] { "Proc2 start" });
            Thread.Sleep(rnd.Next(100, 200));
            Invoke(Log, new object[] { "Proc2 end " });

        }
        private void Proc3()
        {
            t1.Join();
            Invoke(Log, new object[] { "Proc3 start" });
            Thread.Sleep(rnd.Next(100, 200));
            Invoke(Log, new object[] { "Proc3 end " });
        }  
        private void Proc4(object obj)
        {
            var cb = (callback)obj;
            Invoke(Log, new object[] { "Proc4 start" });
            Thread.Sleep(rnd.Next(100, 200));
            Invoke(Log, new object[] { "Proc4 end " });
            cnt++;
            if (cnt == 2) cb();
        }
        private void Proc5(object obj)
        {
            var cb = (callback)obj;
            Invoke(Log, new object[] { "Proc5 start" });
            Thread.Sleep(rnd.Next(100, 200));
            Invoke(Log, new object[] { "Proc5 end " });
            cnt++;
            if (cnt == 2) cb();
        }
        private void ButtonShema1_Click(object sender, EventArgs e)
        {
            new Thread(Proc1).Start();
            new Thread(Proc2).Start();
        }

        private void buttonSheme2_Click(object sender, EventArgs e)
        {
            t1 = new Thread(Proc1);
            t1.Start();
            new Thread(Proc3).Start();
        }
     
        private void buttonSheme3_Click(object sender, EventArgs e)
        {
            cnt = 0;
           callback f = fin;
            new Thread(Proc4).Start(f);
            new Thread(Proc5).Start(f);
        }

        private void ButtonSheme4_Click(object sender, EventArgs e)
        {
            cnt = 0;
            callback f = fin;
            if(TBCnt.Text == String.Empty)
            {
                ConsoleLog.Items.Add("Введите количество потоков!!");
            }

           //if(TBCnt.Text == "1")
           // {
           //     new Thread(Proc1).Start();
           // }
           // else
          if (TBCnt.Text == "2")   {
                t1 = new Thread(Proc1);
                t1.Start();
                new Thread(Proc2).Start();
            }         

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=12 ; i++)
            {
                new Thread(calcMonth).Start(i);
            }
        }

        private void calcMonth(object m)
        {
            result = 100;
            //m - number montch
            int month = 0;
            try
            {
                month = Convert.ToInt32(m);
            }
            catch
            {
                    Invoke(new Action(() =>
                    {
                        ConsoleLog.Items.Add("Parse exeption");
                    }
                ));
                return;
            }
            if (month < 1 || month > 12)
            {
                Invoke(new Action(() =>
                {
                    ConsoleLog.Items.Add("Month invalid");
                }
            ));
                return;
            }
                  // find textBoxM 
            TextBox tb = Controls.Find("textBox" + m, true)[0] as TextBox;
             if(tb == null)
            {
                Invoke(new Action(() =>
                {
                    ConsoleLog.Items.Add("TB not found");
                }
            ));
                return;
            }
                     //Get percent
           double percent = -1;
           try
            {
                percent = Convert.ToDouble(tb.Text);
            }
            catch
            {
                {
                    Invoke(new Action(() =>
                    {
                        ConsoleLog.Items.Add("Parse   percent exeption");
                    }
                         ));
                    return;
                }
            }
                    if (percent < 0)
                    {
                        Invoke(new Action(() =>
                        {
                            ConsoleLog.Items.Add(" percent invalid");
                        }));
                        return;
                    }

            // Modify result
            String str;
            lock (resLocer)
            { 
                result *= 1 + percent / 100;
                  str = month + "  " + result;
            }
          

            Invoke(new Action( ()=>
                {
                     ConsoleLog.Items.Add(str);
                 }));         
            
        }
        #endregion
         #region Massive Digits
        /*
                * Задача: сформировать массив символов (char) цифр 0123..9
                * после каждого добавления цифры выводить рез-т 
                * ( ___3______ )
                * ( ___3__6___ )
                * ( _1_3__6___ )
                * 
                */
    
        char[] digits = new char[10];
            private void AddDigit(object d)
            {
            // d --> int
            int digit = 0;
            String ptr = "  ";
            try
            {
                digit = Convert.ToInt32(d);
            }
            catch
            {
                Invoke(new Action(() => ConsoleLog.Items.Add("Parse exception")));
                return;
            }
            if (digit < 0 || digit > 9)
            {
                Invoke(new Action(() => ConsoleLog.Items.Add("Digit invalid")));
                return;
            }
            lock(resLocer)
            {
            char sym = (char)(digit + '0');
                digits[digit] = sym;
                foreach (char c in digits)
                {
                    if (c == '\0')
                    {
                        ptr += "_";
                    }
                    else
                        ptr += c;
                }
                Invoke(new Action(() => ConsoleLog.Items.Add(ptr)));
                ptr = "\0";
            }           
        }

        private void buttonDigits_Click(object sender, EventArgs e)
       {
            for (int i = 0; i < 10; i++)
            {
                digits[i] = '\0';
            }

            for (int i = 0; i < 10; i++)
            {
                new Thread(AddDigit).Start(i);
            }
       }
        #endregion
        #region Thread Pool
        String str = String.Empty;
        private readonly object strLocker = new object();
        private void Log1()
        {
            ConsoleLog.Items.Add(str);
        }
      private void PoolProc1(object par) //object? par
            {
                    if (par == null) return;
                    lock (strLocker)
                    {
                        str = par.ToString();
                        Invoke((Action)Log1);
                    }
            } 
      private void buttonPool1_Click(object sender, EventArgs e)
             {
                for (int i = 0; i < 10; i++)
                {
                ThreadPool.QueueUserWorkItem(PoolProc1,i);
                }
             }
        private CancellationTokenSource cts = new CancellationTokenSource();
        private void PoolProc2(object par)
        { 
            var threadData = par as ThreadData;
            if (threadData == null) return;           
            lock (cts)
            {
                str = "Start" + threadData?.Id;
                Invoke((Action)Log1);
            }

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(rnd.Next(400));
                if(threadData.Token.IsCancellationRequested)
                {
                      lock (cts)
                      {
                          str = "Cancel" + threadData?.Id;
                          Invoke((Action)Log1);
                      }
                    return;
                }
            }
            lock (cts)
            {
                str = "Finish" + threadData?.Id;
                Invoke((Action)Log1);
            }


        }
        private void buttonPool2_Click(object sender, EventArgs e)
      {
            //start
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(PoolProc2,
                    new ThreadData { Id = i, Token = cts.Token });
            }
      }   
        private void buttonPool2Stop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }  
        class ThreadData
        {
            public int Id { get; set; }
            public CancellationToken Token { get; set; }
        }
        

        private void buttonPoolInf_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                new Thread(calcMonth).Start(i);
            }
        }
        #endregion

        private void buttonAsync_Click(object sender, EventArgs e)
        {
            new SyncAsyncForm().ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DLLform().ShowDialog(this);
        }

        private void buttonHook_Click(object sender, EventArgs e)
        {
            new HookForm().ShowDialog(this);
        }

     
    }
}
/*
 * Хорошая многопоточная задача
 * по известным данным за каждый месяц
 * Обоснование:
 * добавление процента - суть умножения
 * х + 10% = х * 1.1
 * поэтому порядок добавления не играет роли
 * (х + 10%) + 20% == (х + 20%) + 10%
 * это дает возможность проводить расчеты
 * в паралельных потоках не заботясь впоряжке их завершению
 * 
 ???????????
 */