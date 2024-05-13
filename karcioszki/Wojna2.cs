using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace karcioszki
{

    public partial class Wojna2 : Form
    {
        Form1 form1;
        createTable class1;
        playersNick playersNick;
        public List<int> scoreList;
        liczba_os uczestnicy;
        private ResourceManager resources;
        public int punkty = 0;
        private List<string> cards = new List<string>()
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };

        private List<string> suits = new List<string>()
        {
            "♠", "♥", "♦", "♣"
        };

        private Queue<string> player1Cards = new Queue<string>();
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        public List<string> nameList;
        private Label label4;
        private Queue<string> player2Cards = new Queue<string>();

        public Wojna2(playersNick playersNick)
        {
            InitializeComponent();
            this.playersNick = playersNick;
            this.class1 = new createTable();
            this.form1 = playersNick.form1;
            this.uczestnicy = playersNick.uczestnicy;
            nameList = new List<string>();
            scoreList = new List<int>();

        }

        private void Wojna2_Load(object sender, EventArgs e)
        {
            // Rozdaj karty graczom
           

        }






        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(107, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(596, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 389);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 152);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 152);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(154, 679);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(753, 612);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 5;
            label3.Text = "Liczba punktów";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(960, 612);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // Wojna2
            // 
            ClientSize = new Size(1229, 725);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Wojna2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 13);
            int randomNumber2 = rnd.Next(1, 13);
            string directoryPath = @"C:\Users\patpr\OneDrive\Dokumenty\Grafika\";
            string card;
            if (randomNumber >= 2 && randomNumber <= 10)
            {
                card = randomNumber.ToString(); // Dla liczb od 2 do 10 używamy ich samego
            }
            else
            {
                switch (randomNumber)
                {
                    case 1:
                        card = "As";
                        break;
                    case 11:
                        card = "J";
                        break;
                    case 12:
                        card = "Q";
                        break;
                    case 13:
                        card = "K";
                        break;
                    default:
                        card = "Unknown"; // W razie nieprzewidzianego numeru
                        break;
                }
            }
            string card2;
            if (randomNumber2 >= 2 && randomNumber2 <= 10)
            {
                card2 = randomNumber2.ToString(); // Dla liczb od 2 do 10 używamy ich samego
            }
            else
            {
                switch (randomNumber)
                {
                    case 1:
                        card2 = "As";
                        break;
                    case 11:
                        card2 = "J";
                        break;
                    case 12:
                        card2 = "Q";
                        break;
                    case 13:
                        card2 = "K";
                        break;
                    default:
                        card2 = "Unknown"; // W razie nieprzewidzianego numeru
                        break;
                }
            }
            label2.Text = card2;

            label1.Text = card;

            if (Directory.Exists(directoryPath))
            {
                string[] cardImages = Directory.GetFiles(directoryPath, "*.png");

                if (cardImages.Length > 0)
                {
                    // Random rnd = new Random();
                    int index = rnd.Next(cardImages.Length);
                    string imagePath = cardImages[index];
                    pictureBox1.Image = Image.FromFile(imagePath);
                    int index2 = rnd.Next(cardImages.Length);
                    string imagePath2 = cardImages[index2];
                    pictureBox2.Image = Image.FromFile(imagePath2);
                }
                else
                {
                    MessageBox.Show("Brak plików PNG w folderze.");
                }
            }
            else
            {
                MessageBox.Show("Podana ścieżka do folderu nie istnieje.");
            }
           if (randomNumber > randomNumber2)
            {
                punkty++;



                label4.Text = punkty.ToString();
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
