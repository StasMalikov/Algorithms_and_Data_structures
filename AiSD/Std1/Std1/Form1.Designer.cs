namespace Std1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_random = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_write = new System.Windows.Forms.Button();
            this.button_func = new System.Windows.Forms.Button();
            this.textBox_numOfStd = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Data_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_random
            // 
            this.button_random.Location = new System.Drawing.Point(29, 19);
            this.button_random.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(145, 92);
            this.button_random.TabIndex = 0;
            this.button_random.Text = "rnd";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(439, 15);
            this.button_read.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(147, 85);
            this.button_read.TabIndex = 1;
            this.button_read.Text = "read";
            this.button_read.UseVisualStyleBackColor = true;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(654, 19);
            this.button_write.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(132, 85);
            this.button_write.TabIndex = 2;
            this.button_write.Text = "write";
            this.button_write.UseVisualStyleBackColor = true;
            // 
            // button_func
            // 
            this.button_func.Location = new System.Drawing.Point(876, 19);
            this.button_func.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_func.Name = "button_func";
            this.button_func.Size = new System.Drawing.Size(109, 85);
            this.button_func.TabIndex = 3;
            this.button_func.Text = "function";
            this.button_func.UseVisualStyleBackColor = true;
            // 
            // textBox_numOfStd
            // 
            this.textBox_numOfStd.Location = new System.Drawing.Point(206, 51);
            this.textBox_numOfStd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_numOfStd.Name = "textBox_numOfStd";
            this.textBox_numOfStd.Size = new System.Drawing.Size(112, 26);
            this.textBox_numOfStd.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Data_textBox
            // 
            this.Data_textBox.Location = new System.Drawing.Point(29, 132);
            this.Data_textBox.Multiline = true;
            this.Data_textBox.Name = "Data_textBox";
            this.Data_textBox.Size = new System.Drawing.Size(1004, 462);
            this.Data_textBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 616);
            this.Controls.Add(this.Data_textBox);
            this.Controls.Add(this.textBox_numOfStd);
            this.Controls.Add(this.button_func);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_random);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_func;
        private System.Windows.Forms.TextBox textBox_numOfStd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox Data_textBox;
    }
}

