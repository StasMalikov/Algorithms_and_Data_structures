namespace Task_3
{
    partial class Task3_Form
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Write_btn = new System.Windows.Forms.Button();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Func_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RandNum_TextB = new System.Windows.Forms.TextBox();
            this.Random_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Student_DGV = new System.Windows.Forms.DataGridView();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.63089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.36912F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50498F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel2.Controls.Add(this.Write_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Read_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Func_btn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 77);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Write_btn
            // 
            this.Write_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Write_btn.Location = new System.Drawing.Point(296, 3);
            this.Write_btn.Name = "Write_btn";
            this.Write_btn.Size = new System.Drawing.Size(160, 71);
            this.Write_btn.TabIndex = 2;
            this.Write_btn.Text = "Запись";
            this.Write_btn.UseVisualStyleBackColor = true;
            this.Write_btn.Click += new System.EventHandler(this.Write_btn_Click);
            // 
            // Read_btn
            // 
            this.Read_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Read_btn.Location = new System.Drawing.Point(145, 3);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(145, 71);
            this.Read_btn.TabIndex = 1;
            this.Read_btn.Text = "Чтение";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Func_btn
            // 
            this.Func_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Func_btn.Location = new System.Drawing.Point(462, 3);
            this.Func_btn.Name = "Func_btn";
            this.Func_btn.Size = new System.Drawing.Size(161, 71);
            this.Func_btn.TabIndex = 3;
            this.Func_btn.Text = "Список\r\nна отчисление";
            this.Func_btn.UseVisualStyleBackColor = true;
            this.Func_btn.Click += new System.EventHandler(this.Func_btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RandNum_TextB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Random_btn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.60564F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.39437F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(136, 71);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // RandNum_TextB
            // 
            this.RandNum_TextB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandNum_TextB.Location = new System.Drawing.Point(3, 50);
            this.RandNum_TextB.Name = "RandNum_TextB";
            this.RandNum_TextB.Size = new System.Drawing.Size(130, 26);
            this.RandNum_TextB.TabIndex = 1;
            // 
            // Random_btn
            // 
            this.Random_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Random_btn.Location = new System.Drawing.Point(3, 3);
            this.Random_btn.Name = "Random_btn";
            this.Random_btn.Size = new System.Drawing.Size(130, 41);
            this.Random_btn.TabIndex = 0;
            this.Random_btn.Text = "Рандом";
            this.Random_btn.UseVisualStyleBackColor = true;
            this.Random_btn.Click += new System.EventHandler(this.Random_btn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74308F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25692F));
            this.tableLayoutPanel4.Controls.Add(this.Student_DGV, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Result_DGV, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1012, 442);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Student_DGV
            // 
            this.Student_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_DGV.Location = new System.Drawing.Point(3, 3);
            this.Student_DGV.Name = "Student_DGV";
            this.Student_DGV.RowTemplate.Height = 28;
            this.Student_DGV.Size = new System.Drawing.Size(547, 436);
            this.Student_DGV.TabIndex = 2;
            // 
            // Result_DGV
            // 
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_DGV.Location = new System.Drawing.Point(556, 3);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.RowTemplate.Height = 28;
            this.Result_DGV.Size = new System.Drawing.Size(453, 436);
            this.Result_DGV.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Task3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Task3_Form";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Task3_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Random_btn;
        private System.Windows.Forms.TextBox RandNum_TextB;
        private System.Windows.Forms.Button Write_btn;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Func_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.DataGridView Student_DGV;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

