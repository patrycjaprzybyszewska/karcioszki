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
        public int punkty2 = 0;
        
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
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
            label3.Location = new Point(596, 612);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 5;
            label3.Text = "Liczba punktów użytkownika";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(960, 612);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 6;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 612);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 7;
            label5.Text = "Liczba punktów użytkownika";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 612);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 8;
            label6.Text = "0";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 637);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 9;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(765, 651);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 10;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // Wojna2
            // 
            ClientSize = new Size(1229, 725);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
            label7.Text = playersNick.playerTextBoxes[0].Text;
            label8.Text = playersNick.playerTextBoxes[1].Text;
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
                       card = "Joker"; // W razie nieprzewidzianego numeru
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
            if (randomNumber < randomNumber2)
            {
                punkty2++;
                label6.Text = punkty2.ToString();
            }
            if(punkty == 20 || punkty2 == 20 )
            {
                if (punkty > punkty2)
                {
                    saveResultsToCSV();
                    MessageBox.Show("Gra zakończona. " + label8.Text + "wygrał.  Wyniki zostały zapisane do pliku CSV.");
                    Application.Exit();
                }
                if (punkty < punkty2)
                {
                    saveResultsToCSV();
                    MessageBox.Show("Gra zakończona. " + label7.Text + "wygrał.  Wyniki zostały zapisane do pliku CSV.");
                    Application.Exit();
                }
            }
        }

        private void saveResultsToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Wybierz miejsce zapisu tabeli wyników";
            saveFileDialog.FileName = "wyniki.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Nick, Wynik");
                    for (int i = 0; i < nameList.Count; i++)
                    {
                        writer.WriteLine($"{nameList[i]}, {scoreList[i]}");
                    }
                }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
