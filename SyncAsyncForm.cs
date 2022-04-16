using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProg
{
    public partial class SyncAsyncForm : Form
    {
        public SyncAsyncForm()
        {
            InitializeComponent();
        }
        private String SyncMethod(String name)
        {
            Invoke(new Action(
                () => {
                    listBox1.Items.Add($"Hello, {name}");
                }));
            return "Hello";
        }

        private delegate String SyncInvoker(String name);
        private void buttonStart_Click(object sender, EventArgs e)
        {
            var syncInvoker = new SyncInvoker(SyncMethod);
            syncInvoker.BeginInvoke("User", null, null);
            //производный код, выполняющийся паралельно 
            
            String res = syncInvoker.EndInvoke(null);
            // syncInvoker.EndInvoke(null); //в этом месте ожидается окончание SyncMethod 
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            var act = Task.Run( () => SyncMethod("User"));
            act.ContinueWith(                           // назначение callback
                task =>                                             //в него будет передан отработавший Task
                MessageBox.Show(task.Result));      //результат возврата
            



        }

        private Task<String> taskResult(String name)
        {
            Task.Delay(1000).Wait();
            return Task.Run( () => $"Hello,{ name}");
        }
        private void buttonTaskResult_Click(object sender, EventArgs e)
        {
          
            var tr = taskResult("User");
            listBox1.Items.Add(tr.Result);
            stopwatch.Stop();

            listBox1.Items.Add($"Duration: {stopwatch.Elapsed}");
        }
  Stopwatch stopwatch = Stopwatch.StartNew();
        private async Task<String> helloAsync(String name)
        {
            await Task.Delay(1000);
            return $"Hello,{ name}";
        }
        private async void buttonAsyncAwait_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Number convert error");
                return;
            }
            if (n > 0)
            {               
                    // listBox1.Items.Add
                    // (await helloAsync((i+1).ToString()));
                    Task<String>[] greeting = new Task<string>[n];
                    for (int i = 0; i < n; i++)
                    {
                        greeting[i] = helloAsync((i + 1).ToString());
                    }
                    for (int i = 0; i < n; i++)
                    {
                        listBox1.Items.Add(await greeting[i]);
                    }
                    stopwatch.Stop();
                    listBox1.Items.Add($"Duration: {stopwatch.Elapsed}");                
            }
            else
            {
                var greetin = helloAsync("admin");
                listBox1.Items.Add
                    (await greetin);
            }
        }

        private void buttonProcesc_Click(object sender, EventArgs e)
        {
            new FormProces().ShowDialog(this);
        }

        private void SyncAsyncForm_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
 * Асинхронный запуск синхронных методов
 * В базовом языке не возможности смешивать синхронные методы и асинхронные
 * В какой-то момент появляется задача запустить что-то асинхронно, находясь в синхронном контексте
 * Применяется два решения:
 * - при помощи делегата (поддерживается не всеми платформами)
 * - создаем делегат для метода
 * параметры? сначала идут те, которые передаются в метод (если метод не принимает параметров, то их нет )
 * после них (последние два) - callback и ссылка лоя возврата
 * (любой из них может юыть ноль если не нужен)
 * - вызов EndInvoke() приведет к ожиданию окончания выполнения и вернет то, что было возвращено из исходного метода
*Преимущество - возможность возврата значения из метода


Второе решение - задачи (Task), основа многозадачности
объект Task отвечает за выполнение задачи и хранение ее результата, а так же за блокировку
(Ожидание) как одной так и нескольких задач

 */
