namespace Task_10
{
    partial class Check_Guard_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Action_btn = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BadAreas_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.062937F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для того, чтобы проверить, в любой ли момент в галерее находится не менее двух ст" +
    "орожей \r\nнеобходимо указать интервал (в целых минутах) проверки и нажать кнопку " +
    "\"Проверить\"\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Интервал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "С :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "По:";
            // 
            // end_textBox
            // 
            this.end_textBox.Location = new System.Drawing.Point(380, 82);
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(93, 26);
            this.end_textBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результат:";
            // 
            // Action_btn
            // 
            this.Action_btn.Location = new System.Drawing.Point(530, 82);
            this.Action_btn.Name = "Action_btn";
            this.Action_btn.Size = new System.Drawing.Size(113, 32);
            this.Action_btn.TabIndex = 7;
            this.Action_btn.Text = "Проверить";
            this.Action_btn.UseVisualStyleBackColor = true;
            this.Action_btn.Click += new System.EventHandler(this.Action_btn_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.07692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.Location = new System.Drawing.Point(810, 88);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 26);
            this.result_label.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            // 
            // BadAreas_textbox
            // 
            this.BadAreas_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BadAreas_textbox.Location = new System.Drawing.Point(51, 190);
            this.BadAreas_textbox.Multiline = true;
            this.BadAreas_textbox.Name = "BadAreas_textbox";
            this.BadAreas_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BadAreas_textbox.Size = new System.Drawing.Size(472, 346);
            this.BadAreas_textbox.TabIndex = 10;
            this.BadAreas_textbox.Visible = false;
            // 
            // Check_Guard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 548);
            this.Controls.Add(this.BadAreas_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.Action_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.end_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Check_Guard_Form";
            this.Text = "Проверка охраны";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Action_btn;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BadAreas_textbox;
    }
}