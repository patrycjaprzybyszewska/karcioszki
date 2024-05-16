namespace karcioszki
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            MemoryButton = new Button();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 20);
            button1.Margin = new Padding(0, 20, 0, 20);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "MAKAO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 80);
            button2.Margin = new Padding(0, 20, 0, 20);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 1;
            button2.Text = "WOJNA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MemoryButton
            // 
            MemoryButton.Location = new Point(0, 140);
            MemoryButton.Margin = new Padding(0, 20, 0, 20);
            MemoryButton.Name = "MemoryButton";
            MemoryButton.Size = new Size(78, 20);
            MemoryButton.TabIndex = 2;
            MemoryButton.Text = "MEMORY";
            MemoryButton.UseVisualStyleBackColor = true;
            MemoryButton.Click += MemoryButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 200);
            button4.Margin = new Padding(0, 20, 0, 20);
            button4.Name = "button4";
            button4.Size = new Size(78, 20);
            button4.TabIndex = 3;
            button4.Text = "RULETKA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(MemoryButton);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(100, 50);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(80, 265);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(1);
            Name = "MainWindow";
            Text = "MainWindow";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

		#endregion

		private Button button1;
        private Button button2;
        private Button MemoryButton;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}