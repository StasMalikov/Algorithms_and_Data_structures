namespace Task_6__UI_
{
   public partial class SortViewForm
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
            this.tableLayoutPanel_QuickSort = new System.Windows.Forms.TableLayoutPanel();
            this.Grid_Arr = new System.Windows.Forms.DataGridView();
            this.Grid_SortArr = new System.Windows.Forms.DataGridView();
            this.groupBox_functions = new System.Windows.Forms.GroupBox();
            this.Draw_btn = new System.Windows.Forms.Button();
            this.SortArr_btn = new System.Windows.Forms.Button();
            this.SetArr_btn = new System.Windows.Forms.Button();
            this.ViewSort_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_QuickSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Arr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SortArr)).BeginInit();
            this.groupBox_functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_QuickSort
            // 
            this.tableLayoutPanel_QuickSort.ColumnCount = 4;
            this.tableLayoutPanel_QuickSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.93014F));
            this.tableLayoutPanel_QuickSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06986F));
            this.tableLayoutPanel_QuickSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel_QuickSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel_QuickSort.Controls.Add(this.Grid_Arr, 2, 0);
            this.tableLayoutPanel_QuickSort.Controls.Add(this.Grid_SortArr, 3, 0);
            this.tableLayoutPanel_QuickSort.Controls.Add(this.groupBox_functions, 1, 0);
            this.tableLayoutPanel_QuickSort.Controls.Add(this.ViewSort_panel, 0, 0);
            this.tableLayoutPanel_QuickSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_QuickSort.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_QuickSort.Name = "tableLayoutPanel_QuickSort";
            this.tableLayoutPanel_QuickSort.RowCount = 1;
            this.tableLayoutPanel_QuickSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.272727F));
            this.tableLayoutPanel_QuickSort.Size = new System.Drawing.Size(1237, 597);
            this.tableLayoutPanel_QuickSort.TabIndex = 0;
            // 
            // Grid_Arr
            // 
            this.Grid_Arr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Arr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Arr.Location = new System.Drawing.Point(922, 3);
            this.Grid_Arr.Name = "Grid_Arr";
            this.Grid_Arr.RowTemplate.Height = 28;
            this.Grid_Arr.Size = new System.Drawing.Size(159, 591);
            this.Grid_Arr.TabIndex = 0;
            // 
            // Grid_SortArr
            // 
            this.Grid_SortArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_SortArr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_SortArr.Location = new System.Drawing.Point(1087, 3);
            this.Grid_SortArr.Name = "Grid_SortArr";
            this.Grid_SortArr.RowTemplate.Height = 28;
            this.Grid_SortArr.Size = new System.Drawing.Size(147, 591);
            this.Grid_SortArr.TabIndex = 1;
            // 
            // groupBox_functions
            // 
            this.groupBox_functions.Controls.Add(this.Draw_btn);
            this.groupBox_functions.Controls.Add(this.SortArr_btn);
            this.groupBox_functions.Controls.Add(this.SetArr_btn);
            this.groupBox_functions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_functions.Location = new System.Drawing.Point(784, 3);
            this.groupBox_functions.Name = "groupBox_functions";
            this.groupBox_functions.Size = new System.Drawing.Size(132, 591);
            this.groupBox_functions.TabIndex = 2;
            this.groupBox_functions.TabStop = false;
            // 
            // Draw_btn
            // 
            this.Draw_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Draw_btn.Location = new System.Drawing.Point(3, 178);
            this.Draw_btn.Name = "Draw_btn";
            this.Draw_btn.Size = new System.Drawing.Size(123, 53);
            this.Draw_btn.TabIndex = 4;
            this.Draw_btn.Text = "Нарисовать\r\n";
            this.Draw_btn.UseVisualStyleBackColor = true;
            this.Draw_btn.Click += new System.EventHandler(this.Draw_btn_Click);
            // 
            // SortArr_btn
            // 
            this.SortArr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortArr_btn.Location = new System.Drawing.Point(6, 103);
            this.SortArr_btn.Name = "SortArr_btn";
            this.SortArr_btn.Size = new System.Drawing.Size(123, 53);
            this.SortArr_btn.TabIndex = 1;
            this.SortArr_btn.Text = "Отсортировать\r\nмассив";
            this.SortArr_btn.UseVisualStyleBackColor = true;
            this.SortArr_btn.Click += new System.EventHandler(this.SortArr_btn_Click);
            // 
            // SetArr_btn
            // 
            this.SetArr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetArr_btn.Location = new System.Drawing.Point(3, 22);
            this.SetArr_btn.Name = "SetArr_btn";
            this.SetArr_btn.Size = new System.Drawing.Size(123, 53);
            this.SetArr_btn.TabIndex = 0;
            this.SetArr_btn.Text = "Задать \r\nмассив";
            this.SetArr_btn.UseVisualStyleBackColor = true;
            this.SetArr_btn.Click += new System.EventHandler(this.SetArr_btn_Click);
            // 
            // ViewSort_panel
            // 
            this.ViewSort_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSort_panel.Location = new System.Drawing.Point(3, 3);
            this.ViewSort_panel.Name = "ViewSort_panel";
            this.ViewSort_panel.Size = new System.Drawing.Size(775, 591);
            this.ViewSort_panel.TabIndex = 3;
            // 
            // SortViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 597);
            this.Controls.Add(this.tableLayoutPanel_QuickSort);
            this.Name = "SortViewForm";
            this.Text = "Быстрая  сортировка - визуализация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_QuickSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Arr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SortArr)).EndInit();
            this.groupBox_functions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_QuickSort;
        private System.Windows.Forms.DataGridView Grid_SortArr;
        private System.Windows.Forms.GroupBox groupBox_functions;
        private System.Windows.Forms.Button SortArr_btn;
        private System.Windows.Forms.Button SetArr_btn;
        public System.Windows.Forms.DataGridView Grid_Arr;
        private System.Windows.Forms.Button Draw_btn;
        public System.Windows.Forms.Panel ViewSort_panel;
    }
}

