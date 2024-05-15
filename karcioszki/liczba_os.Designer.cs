namespace karcioszki
{
    partial class liczba_os
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
			label1 = new Label();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox3 = new CheckBox();
			checkBox4 = new CheckBox();
			checkBox5 = new CheckBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(146, 168);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(227, 32);
			label1.TabIndex = 0;
			label1.Text = "Wybierz liczbę osób";
			label1.Click += label1_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(146, 238);
			checkBox1.Margin = new Padding(5, 5, 5, 5);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(130, 36);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "2 osoby";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(146, 301);
			checkBox2.Margin = new Padding(5, 5, 5, 5);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(130, 36);
			checkBox2.TabIndex = 2;
			checkBox2.Text = "3 osoby";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Location = new Point(146, 365);
			checkBox3.Margin = new Padding(5, 5, 5, 5);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(130, 36);
			checkBox3.TabIndex = 3;
			checkBox3.Text = "4 osoby";
			checkBox3.UseVisualStyleBackColor = true;
			checkBox3.CheckedChanged += checkBox3_CheckedChanged;
			// 
			// checkBox4
			// 
			checkBox4.AutoSize = true;
			checkBox4.Location = new Point(146, 429);
			checkBox4.Margin = new Padding(5, 5, 5, 5);
			checkBox4.Name = "checkBox4";
			checkBox4.Size = new Size(118, 36);
			checkBox4.TabIndex = 4;
			checkBox4.Text = "5 osob";
			checkBox4.UseVisualStyleBackColor = true;
			checkBox4.CheckedChanged += checkBox4_CheckedChanged;
			// 
			// checkBox5
			// 
			checkBox5.AutoSize = true;
			checkBox5.Location = new Point(146, 497);
			checkBox5.Margin = new Padding(5, 5, 5, 5);
			checkBox5.Name = "checkBox5";
			checkBox5.Size = new Size(118, 36);
			checkBox5.TabIndex = 5;
			checkBox5.Text = "6 osob";
			checkBox5.UseVisualStyleBackColor = true;
			checkBox5.CheckedChanged += checkBox5_CheckedChanged;
			// 
			// liczba_os
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(530, 719);
			Controls.Add(checkBox5);
			Controls.Add(checkBox4);
			Controls.Add(checkBox3);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(label1);
			Margin = new Padding(5, 5, 5, 5);
			Name = "liczba_os";
			Text = "liczba_os";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}