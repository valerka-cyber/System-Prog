using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProg
{
    public partial class FormProces : Form
    {
        public FormProces()
        {
            InitializeComponent();
        }

        private void FormProces_Load(object sender, EventArgs e)
        {

        }

        private void ShowProcesses()
        {
            Process[] processes = Process.GetProcesses();
            treeView1.Nodes.Clear();
            var root = new TreeNode("Active Processes");
            foreach (var grp in processes
                .GroupBy(p => p.ProcessName)
                .OrderBy(x => x.Key))
            {
                var node = new TreeNode();
                node.Text = $"{grp.Key} ({ grp.Count()})";
                
                foreach (var process in grp)
                {
                    var subnote = new TreeNode();
                    subnote.Text = $"{process.ProcessName} ( {process.Id})";
                    node.Nodes.Add(subnote);
                    foreach ( Thread t in process.Threads)
                    {
                        
                    }
                  //  process.Threads;
                }
                root.Nodes.Add(node);
            }
            treeView1.Nodes.Add(root);
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            ShowProcesses();
        }

        /*
         * задание - сделать "диспетчер задач" - форму, отображающию систему
         * активных процессов
         * 
         
         
         */
    }
}
