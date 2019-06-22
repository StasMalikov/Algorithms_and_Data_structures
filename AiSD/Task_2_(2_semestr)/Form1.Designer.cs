namespace Task_2__2_semestr_
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
            this.Load_button1 = new System.Windows.Forms.Button();
            this.Load_button2 = new System.Windows.Forms.Button();
            this.Load_button3 = new System.Windows.Forms.Button();
            this.Sort_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Load_button1
            // 
            this.Load_button1.Location = new System.Drawing.Point(46, 37);
            this.Load_button1.Name = "Load_button1";
            this.Load_button1.Size = new System.Drawing.Size(47, 23);
            this.Load_button1.TabIndex = 0;
            this.Load_button1.Text = "1";
            this.Load_button1.UseVisualStyleBackColor = true;
            this.Load_button1.Click += new System.EventHandler(this.Load_button1_Click);
            // 
            // Load_button2
            // 
            this.Load_button2.Location = new System.Drawing.Point(138, 37);
            this.Load_button2.Name = "Load_button2";
            this.Load_button2.Size = new System.Drawing.Size(47, 23);
            this.Load_button2.TabIndex = 1;
            this.Load_button2.Text = "2";
            this.Load_button2.UseVisualStyleBackColor = true;
            this.Load_button2.Click += new System.EventHandler(this.Load_button2_Click);
            // 
            // Load_button3
            // 
            this.Load_button3.Location = new System.Drawing.Point(234, 37);
            this.Load_button3.Name = "Load_button3";
            this.Load_button3.Size = new System.Drawing.Size(49, 23);
            this.Load_button3.TabIndex = 2;
            this.Load_button3.Text = "3";
            this.Load_button3.UseVisualStyleBackColor = true;
            this.Load_button3.Click += new System.EventHandler(this.Load_button3_Click);
            // 
            // Sort_button
            // 
            this.Sort_button.Location = new System.Drawing.Point(316, 37);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(56, 23);
            this.Sort_button.TabIndex = 3;
            this.Sort_button.Text = "Sort_button";
            this.Sort_button.UseVisualStyleBackColor = true;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(396, 37);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(73, 71);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save result";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 279);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 279);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 98);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 279);
            this.textBox3.TabIndex = 7;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(316, 98);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_textBox.Size = new System.Drawing.Size(56, 279);
            this.result_textBox.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 412);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Sort_button);
            this.Controls.Add(this.Load_button3);
            this.Controls.Add(this.Load_button2);
            this.Controls.Add(this.Load_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_button1;
        private System.Windows.Forms.Button Load_button2;
        private System.Windows.Forms.Button Load_button3;
        private System.Windows.Forms.Button Sort_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

