namespace Task_4_2s_
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
            this.textBox_numb = new System.Windows.Forms.TextBox();
            this.label_numb = new System.Windows.Forms.Label();
            this.button_recursion = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_steps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_numb
            // 
            this.textBox_numb.Location = new System.Drawing.Point(72, 12);
            this.textBox_numb.Name = "textBox_numb";
            this.textBox_numb.Size = new System.Drawing.Size(39, 22);
            this.textBox_numb.TabIndex = 0;
            // 
            // label_numb
            // 
            this.label_numb.AutoSize = true;
            this.label_numb.Location = new System.Drawing.Point(12, 15);
            this.label_numb.Name = "label_numb";
            this.label_numb.Size = new System.Drawing.Size(18, 17);
            this.label_numb.TabIndex = 1;
            this.label_numb.Text = "N";
            // 
            // button_recursion
            // 
            this.button_recursion.Location = new System.Drawing.Point(143, 6);
            this.button_recursion.Name = "button_recursion";
            this.button_recursion.Size = new System.Drawing.Size(85, 41);
            this.button_recursion.TabIndex = 2;
            this.button_recursion.Text = "Рекурсия";
            this.button_recursion.UseVisualStyleBackColor = true;
            this.button_recursion.Click += new System.EventHandler(this.button_recursion_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(252, 18);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(43, 17);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "result";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(317, 15);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(75, 22);
            this.textBox_result.TabIndex = 4;
            // 
            // textBox_steps
            // 
            this.textBox_steps.Location = new System.Drawing.Point(15, 63);
            this.textBox_steps.Multiline = true;
            this.textBox_steps.Name = "textBox_steps";
            this.textBox_steps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_steps.Size = new System.Drawing.Size(829, 590);
            this.textBox_steps.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 702);
            this.Controls.Add(this.textBox_steps);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_recursion);
            this.Controls.Add(this.label_numb);
            this.Controls.Add(this.textBox_numb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_numb;
        private System.Windows.Forms.Label label_numb;
        private System.Windows.Forms.Button button_recursion;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_steps;
    }
}

