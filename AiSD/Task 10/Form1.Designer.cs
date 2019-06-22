namespace Task_10
{
    partial class Task_10_MainForm
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
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Inform_DGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Help_btn = new System.Windows.Forms.Button();
            this.Check_min_btn = new System.Windows.Forms.Button();
            this.Draw_btn = new System.Windows.Forms.Button();
            this.ShowWeight_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Random_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inform_DGV)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.036144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.96385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.93398F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.06602F));
            this.tableLayoutPanel2.Controls.Add(this.Draw_Panel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1242, 603);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw_Panel.Location = new System.Drawing.Point(3, 3);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(875, 597);
            this.Draw_Panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Inform_DGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(884, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 597);
            this.panel1.TabIndex = 1;
            // 
            // Inform_DGV
            // 
            this.Inform_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inform_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inform_DGV.Location = new System.Drawing.Point(20, 3);
            this.Inform_DGV.Name = "Inform_DGV";
            this.Inform_DGV.RowTemplate.Height = 28;
            this.Inform_DGV.Size = new System.Drawing.Size(335, 591);
            this.Inform_DGV.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.93877F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.06123F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel3.Controls.Add(this.Help_btn, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.Check_min_btn, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Draw_btn, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ShowWeight_btn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Add_btn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Random_btn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1242, 54);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Help_btn
            // 
            this.Help_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Help_btn.Location = new System.Drawing.Point(1011, 3);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(228, 48);
            this.Help_btn.TabIndex = 5;
            this.Help_btn.Text = "Подказка";
            this.Help_btn.UseVisualStyleBackColor = true;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Check_min_btn
            // 
            this.Check_min_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Check_min_btn.Location = new System.Drawing.Point(784, 3);
            this.Check_min_btn.Name = "Check_min_btn";
            this.Check_min_btn.Size = new System.Drawing.Size(221, 48);
            this.Check_min_btn.TabIndex = 4;
            this.Check_min_btn.Text = "Проверить охрану";
            this.Check_min_btn.UseVisualStyleBackColor = true;
            this.Check_min_btn.Click += new System.EventHandler(this.Check_min_btn_Click);
            // 
            // Draw_btn
            // 
            this.Draw_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw_btn.Location = new System.Drawing.Point(591, 3);
            this.Draw_btn.Name = "Draw_btn";
            this.Draw_btn.Size = new System.Drawing.Size(187, 48);
            this.Draw_btn.TabIndex = 3;
            this.Draw_btn.Text = "Нарисовать граф";
            this.Draw_btn.UseVisualStyleBackColor = true;
            this.Draw_btn.Click += new System.EventHandler(this.Draw_btn_Click);
            // 
            // ShowWeight_btn
            // 
            this.ShowWeight_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowWeight_btn.Location = new System.Drawing.Point(395, 3);
            this.ShowWeight_btn.Name = "ShowWeight_btn";
            this.ShowWeight_btn.Size = new System.Drawing.Size(190, 48);
            this.ShowWeight_btn.TabIndex = 2;
            this.ShowWeight_btn.Text = "Показать вес";
            this.ShowWeight_btn.UseVisualStyleBackColor = true;
            this.ShowWeight_btn.Click += new System.EventHandler(this.ShowWeight_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_btn.Location = new System.Drawing.Point(187, 3);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(202, 48);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Обновить данные \r\n(если вы внесли изменения в таблице)";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Random_btn
            // 
            this.Random_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Random_btn.Location = new System.Drawing.Point(3, 3);
            this.Random_btn.Name = "Random_btn";
            this.Random_btn.Size = new System.Drawing.Size(178, 48);
            this.Random_btn.TabIndex = 0;
            this.Random_btn.Text = "Задать Расписание";
            this.Random_btn.UseVisualStyleBackColor = true;
            this.Random_btn.Click += new System.EventHandler(this.Random_btn_Click);
            // 
            // Task_10_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Task_10_MainForm";
            this.Text = "Расписание дежурств картинной галереи";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Inform_DGV)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Check_min_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Random_btn;
        public System.Windows.Forms.DataGridView Inform_DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Draw_btn;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.Button ShowWeight_btn;
    }
}

