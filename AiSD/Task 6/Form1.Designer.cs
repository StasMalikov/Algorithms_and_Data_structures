namespace Task_6
{
    partial class Task6_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Sort_btn = new System.Windows.Forms.Button();
            this.Read_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Data_textbox = new System.Windows.Forms.TextBox();
            this.Result_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.13793F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.86207F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel3.Controls.Add(this.Clear_btn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Sort_btn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Read_btn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 74);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear_btn.Location = new System.Drawing.Point(237, 3);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(106, 68);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Sort_btn
            // 
            this.Sort_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sort_btn.Location = new System.Drawing.Point(118, 3);
            this.Sort_btn.Name = "Sort_btn";
            this.Sort_btn.Size = new System.Drawing.Size(113, 68);
            this.Sort_btn.TabIndex = 4;
            this.Sort_btn.Text = "Sort";
            this.Sort_btn.UseVisualStyleBackColor = true;
            this.Sort_btn.Click += new System.EventHandler(this.Sort_btn_Click);
            // 
            // Read_btn
            // 
            this.Read_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Read_btn.Location = new System.Drawing.Point(3, 3);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(109, 68);
            this.Read_btn.TabIndex = 3;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.35632F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.64368F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel2.Controls.Add(this.Data_textbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Result_textbox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 364);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Data_textbox
            // 
            this.Data_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.08392F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Data_textbox.Location = new System.Drawing.Point(3, 3);
            this.Data_textbox.Multiline = true;
            this.Data_textbox.Name = "Data_textbox";
            this.Data_textbox.Size = new System.Drawing.Size(213, 358);
            this.Data_textbox.TabIndex = 1;
            // 
            // Result_textbox
            // 
            this.Result_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.08392F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_textbox.Location = new System.Drawing.Point(222, 3);
            this.Result_textbox.Multiline = true;
            this.Result_textbox.Name = "Result_textbox";
            this.Result_textbox.Size = new System.Drawing.Size(238, 358);
            this.Result_textbox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Task6_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Task6_Form";
            this.Text = "DELL THE SAME NUMBERS IN QUEUE";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Sort_btn;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Data_textbox;
        private System.Windows.Forms.TextBox Result_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

