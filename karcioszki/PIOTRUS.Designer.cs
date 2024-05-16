namespace karcioszki
{
    partial class PIOTRUS
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "trefl", "karo", "kier", "pik" });
            comboBox1.Location = new Point(748, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 51);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Obstaw kolor karty";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "AS", "JOCKER" });
            comboBox2.Location = new Point(748, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 138);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 3;
            label2.Text = "Obstaw figure karty";
            // 
            // button1
            // 
            button1.Location = new Point(748, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "GRAJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 262);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 96);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 51);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 9;
            label4.Text = "Gra:";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(179, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 262);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(361, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 262);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(28, 374);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "karta 1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 374);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "karta 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(383, 374);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "karta 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 326);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 17;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // PIOTRUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "PIOTRUS";
            Text = "PIOTRUS";
            Load += PIOTRUS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}