
namespace SystemProg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Stop1 = new System.Windows.Forms.Button();
            this.Start1 = new System.Windows.Forms.Button();
            this.Start3 = new System.Windows.Forms.Button();
            this.Stop3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(48, 82);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(105, 37);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(479, 82);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(105, 37);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Stop1
            // 
            this.Stop1.Location = new System.Drawing.Point(479, 141);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(105, 36);
            this.Stop1.TabIndex = 4;
            this.Stop1.Text = "Stop";
            this.Stop1.UseVisualStyleBackColor = true;
            this.Stop1.Click += new System.EventHandler(this.Stop1_Click);
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(48, 141);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(105, 32);
            this.Start1.TabIndex = 5;
            this.Start1.Text = "Start";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Start3
            // 
            this.Start3.Location = new System.Drawing.Point(48, 190);
            this.Start3.Name = "Start3";
            this.Start3.Size = new System.Drawing.Size(105, 32);
            this.Start3.TabIndex = 6;
            this.Start3.Text = "Start";
            this.Start3.UseVisualStyleBackColor = true;
            this.Start3.Click += new System.EventHandler(this.Start3_Click);
            // 
            // Stop3
            // 
            this.Stop3.Location = new System.Drawing.Point(479, 190);
            this.Stop3.Name = "Stop3";
            this.Stop3.Size = new System.Drawing.Size(105, 32);
            this.Stop3.TabIndex = 7;
            this.Stop3.Text = "Stop";
            this.Stop3.UseVisualStyleBackColor = true;
            this.Stop3.Click += new System.EventHandler(this.Stop3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(this.Stop3);
            this.Controls.Add(this.Start3);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Stop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button Start3;
        private System.Windows.Forms.Button Stop3;
    }
}

