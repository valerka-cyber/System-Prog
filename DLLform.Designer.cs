namespace SystemProg
{
    partial class DLLform
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
            this.buttonAlert = new System.Windows.Forms.Button();
            this.buttonЕггог = new System.Windows.Forms.Button();
            this.buttonWarn = new System.Windows.Forms.Button();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonSingleSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAlert
            // 
            this.buttonAlert.Location = new System.Drawing.Point(44, 34);
            this.buttonAlert.Name = "buttonAlert";
            this.buttonAlert.Size = new System.Drawing.Size(120, 23);
            this.buttonAlert.TabIndex = 0;
            this.buttonAlert.Text = "Alert";
            this.buttonAlert.UseVisualStyleBackColor = true;
            this.buttonAlert.Click += new System.EventHandler(this.buttonAlert_Click);
            // 
            // buttonЕггог
            // 
            this.buttonЕггог.Location = new System.Drawing.Point(44, 64);
            this.buttonЕггог.Name = "buttonЕггог";
            this.buttonЕггог.Size = new System.Drawing.Size(120, 23);
            this.buttonЕггог.TabIndex = 1;
            this.buttonЕггог.Text = "Еггог";
            this.buttonЕггог.UseVisualStyleBackColor = true;
            this.buttonЕггог.Click += new System.EventHandler(this.buttonЕггог_Click);
            // 
            // buttonWarn
            // 
            this.buttonWarn.Location = new System.Drawing.Point(44, 94);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(120, 23);
            this.buttonWarn.TabIndex = 2;
            this.buttonWarn.Text = "Warning";
            this.buttonWarn.UseVisualStyleBackColor = true;
            this.buttonWarn.Click += new System.EventHandler(this.buttonWarn_Click);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.Location = new System.Drawing.Point(44, 124);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(120, 23);
            this.buttonQuestion.TabIndex = 3;
            this.buttonQuestion.Text = "Question";
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(44, 200);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(120, 23);
            this.buttonReverse.TabIndex = 5;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonSingleSpace
            // 
            this.buttonSingleSpace.Location = new System.Drawing.Point(44, 230);
            this.buttonSingleSpace.Name = "buttonSingleSpace";
            this.buttonSingleSpace.Size = new System.Drawing.Size(120, 23);
            this.buttonSingleSpace.TabIndex = 6;
            this.buttonSingleSpace.Text = "SingleSpace";
            this.buttonSingleSpace.UseVisualStyleBackColor = true;
            this.buttonSingleSpace.Click += new System.EventHandler(this.buttonSingleSpace_Click);
            // 
            // DLLform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSingleSpace);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.buttonWarn);
            this.Controls.Add(this.buttonЕггог);
            this.Controls.Add(this.buttonAlert);
            this.Name = "DLLform";
            this.Text = "DLLform";
            this.Load += new System.EventHandler(this.DLLform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlert;
        private System.Windows.Forms.Button buttonЕггог;
        private System.Windows.Forms.Button buttonWarn;
        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonSingleSpace;
    }
}