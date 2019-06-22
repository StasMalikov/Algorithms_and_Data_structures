namespace Task_6__UI_
{
    partial class SetArrForm
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
            this.ArrLength_textBox = new System.Windows.Forms.TextBox();
            this.SetArr_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задайте размер массива.\r\n\r\n";
            // 
            // ArrLength_textBox
            // 
            this.ArrLength_textBox.Location = new System.Drawing.Point(133, 114);
            this.ArrLength_textBox.Name = "ArrLength_textBox";
            this.ArrLength_textBox.Size = new System.Drawing.Size(202, 26);
            this.ArrLength_textBox.TabIndex = 1;
            // 
            // SetArr_button
            // 
            this.SetArr_button.Location = new System.Drawing.Point(174, 188);
            this.SetArr_button.Name = "SetArr_button";
            this.SetArr_button.Size = new System.Drawing.Size(126, 42);
            this.SetArr_button.TabIndex = 2;
            this.SetArr_button.Text = "OK";
            this.SetArr_button.UseVisualStyleBackColor = true;
            this.SetArr_button.Click += new System.EventHandler(this.SetArr_button_Click);
            // 
            // SetArrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.SetArr_button);
            this.Controls.Add(this.ArrLength_textBox);
            this.Controls.Add(this.label1);
            this.Name = "SetArrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArrLength_textBox;
        private System.Windows.Forms.Button SetArr_button;
    }
}