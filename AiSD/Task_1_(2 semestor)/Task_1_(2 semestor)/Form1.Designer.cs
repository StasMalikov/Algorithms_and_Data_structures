namespace Task_1__2_semestor_
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
            this.button_LoadFile = new System.Windows.Forms.Button();
            this.button_FindParagraph = new System.Windows.Forms.Button();
            this.textBox_ShowText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_paragraph = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_LoadFile
            // 
            this.button_LoadFile.Location = new System.Drawing.Point(32, 25);
            this.button_LoadFile.Name = "button_LoadFile";
            this.button_LoadFile.Size = new System.Drawing.Size(116, 54);
            this.button_LoadFile.TabIndex = 0;
            this.button_LoadFile.Text = "Загрузить текст";
            this.button_LoadFile.UseVisualStyleBackColor = true;
            this.button_LoadFile.Click += new System.EventHandler(this.button_LoadFile_Click);
            // 
            // button_FindParagraph
            // 
            this.button_FindParagraph.Location = new System.Drawing.Point(168, 25);
            this.button_FindParagraph.Name = "button_FindParagraph";
            this.button_FindParagraph.Size = new System.Drawing.Size(120, 54);
            this.button_FindParagraph.TabIndex = 1;
            this.button_FindParagraph.Text = "Найти абзацы";
            this.button_FindParagraph.UseVisualStyleBackColor = true;
            this.button_FindParagraph.Click += new System.EventHandler(this.button_FindParagraph_Click);
            // 
            // textBox_ShowText
            // 
            this.textBox_ShowText.Location = new System.Drawing.Point(32, 135);
            this.textBox_ShowText.Multiline = true;
            this.textBox_ShowText.Name = "textBox_ShowText";
            this.textBox_ShowText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ShowText.Size = new System.Drawing.Size(421, 216);
            this.textBox_ShowText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во абзацев:";
            // 
            // label_paragraph
            // 
            this.label_paragraph.AutoSize = true;
            this.label_paragraph.Location = new System.Drawing.Point(150, 97);
            this.label_paragraph.Name = "label_paragraph";
            this.label_paragraph.Size = new System.Drawing.Size(16, 17);
            this.label_paragraph.TabIndex = 4;
            this.label_paragraph.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 363);
            this.Controls.Add(this.label_paragraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ShowText);
            this.Controls.Add(this.button_FindParagraph);
            this.Controls.Add(this.button_LoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoadFile;
        private System.Windows.Forms.Button button_FindParagraph;
        private System.Windows.Forms.TextBox textBox_ShowText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_paragraph;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

