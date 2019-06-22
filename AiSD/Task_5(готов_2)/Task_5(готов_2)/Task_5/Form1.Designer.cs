namespace Task_5
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
            this.button_rndQueue = new System.Windows.Forms.Button();
            this.button_sortQueue = new System.Windows.Forms.Button();
            this.textBox_SortQueue = new System.Windows.Forms.TextBox();
            this.textBox_Queue = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_rndQueue
            // 
            this.button_rndQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.985401F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rndQueue.Location = new System.Drawing.Point(23, 8);
            this.button_rndQueue.Name = "button_rndQueue";
            this.button_rndQueue.Size = new System.Drawing.Size(93, 61);
            this.button_rndQueue.TabIndex = 0;
            this.button_rndQueue.Text = "Set Queue";
            this.button_rndQueue.UseVisualStyleBackColor = true;
            this.button_rndQueue.Click += new System.EventHandler(this.button_rndQueue_Click);
            // 
            // button_sortQueue
            // 
            this.button_sortQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.985401F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sortQueue.Location = new System.Drawing.Point(229, 10);
            this.button_sortQueue.Name = "button_sortQueue";
            this.button_sortQueue.Size = new System.Drawing.Size(100, 52);
            this.button_sortQueue.TabIndex = 1;
            this.button_sortQueue.Text = "Sort";
            this.button_sortQueue.UseVisualStyleBackColor = true;
            this.button_sortQueue.Click += new System.EventHandler(this.button_sortQueue_Click);
            // 
            // textBox_SortQueue
            // 
            this.textBox_SortQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SortQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.08759F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SortQueue.Location = new System.Drawing.Point(199, 75);
            this.textBox_SortQueue.Multiline = true;
            this.textBox_SortQueue.Name = "textBox_SortQueue";
            this.textBox_SortQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SortQueue.Size = new System.Drawing.Size(130, 594);
            this.textBox_SortQueue.TabIndex = 2;
            // 
            // textBox_Queue
            // 
            this.textBox_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.08759F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Queue.Location = new System.Drawing.Point(23, 75);
            this.textBox_Queue.Multiline = true;
            this.textBox_Queue.Name = "textBox_Queue";
            this.textBox_Queue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Queue.Size = new System.Drawing.Size(120, 594);
            this.textBox_Queue.TabIndex = 3;
            this.textBox_Queue.TextChanged += new System.EventHandler(this.textBox_Queue_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.985401F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(140, 8);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(67, 54);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 681);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_Queue);
            this.Controls.Add(this.textBox_SortQueue);
            this.Controls.Add(this.button_sortQueue);
            this.Controls.Add(this.button_rndQueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rndQueue;
        private System.Windows.Forms.Button button_sortQueue;
        private System.Windows.Forms.TextBox textBox_SortQueue;
        private System.Windows.Forms.TextBox textBox_Queue;
        private System.Windows.Forms.Button button_clear;
    }
}

