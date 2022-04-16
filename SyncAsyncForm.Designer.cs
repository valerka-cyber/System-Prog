
namespace SystemProg
{
    partial class SyncAsyncForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonTaskResult = new System.Windows.Forms.Button();
            this.buttonAsyncAwait = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonProcesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 355);
            this.listBox1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(39, 54);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(98, 29);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Invoke";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(39, 102);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(98, 35);
            this.buttonTask.TabIndex = 2;
            this.buttonTask.Text = "Task";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonTaskResult
            // 
            this.buttonTaskResult.Location = new System.Drawing.Point(39, 159);
            this.buttonTaskResult.Name = "buttonTaskResult";
            this.buttonTaskResult.Size = new System.Drawing.Size(98, 30);
            this.buttonTaskResult.TabIndex = 3;
            this.buttonTaskResult.Text = "TaskResult";
            this.buttonTaskResult.UseVisualStyleBackColor = true;
            this.buttonTaskResult.Click += new System.EventHandler(this.buttonTaskResult_Click);
            // 
            // buttonAsyncAwait
            // 
            this.buttonAsyncAwait.Location = new System.Drawing.Point(39, 214);
            this.buttonAsyncAwait.Name = "buttonAsyncAwait";
            this.buttonAsyncAwait.Size = new System.Drawing.Size(98, 31);
            this.buttonAsyncAwait.TabIndex = 4;
            this.buttonAsyncAwait.Text = "AsyncAwait";
            this.buttonAsyncAwait.UseVisualStyleBackColor = true;
            this.buttonAsyncAwait.Click += new System.EventHandler(this.buttonAsyncAwait_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "10";
            // 
            // buttonProcesc
            // 
            this.buttonProcesc.Location = new System.Drawing.Point(39, 303);
            this.buttonProcesc.Name = "buttonProcesc";
            this.buttonProcesc.Size = new System.Drawing.Size(98, 29);
            this.buttonProcesc.TabIndex = 6;
            this.buttonProcesc.Text = "buttonProc";
            this.buttonProcesc.UseVisualStyleBackColor = true;
            this.buttonProcesc.Click += new System.EventHandler(this.buttonProcesc_Click);
            // 
            // SyncAsyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.buttonProcesc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAsyncAwait);
            this.Controls.Add(this.buttonTaskResult);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBox1);
            this.Name = "SyncAsyncForm";
            this.Text = "SyncAsyncForm";
            this.Load += new System.EventHandler(this.SyncAsyncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonTaskResult;
        private System.Windows.Forms.Button buttonAsyncAwait;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonProcesc;
    }
}