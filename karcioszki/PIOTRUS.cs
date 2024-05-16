using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace karcioszki
{

    public partial class PIOTRUS : Form
    {
        Form1 form1;
        createTable class1;
        playersNick playersNick;
        liczba_os uczestnicy;


        public int[,] tab_card;
        public int selectedIndexColor;
        public int selectedIndexFigure;
        public int row_indeks;
        public int col_indeks;
        public string card_color;
        public string card_figure;
        public int currentPlayerIndex = 0;
        public int punkty;
        public List<string> nameList;
        public List<int> scoreList;
        public bool isClicked_2 = false;
        public bool isClicked_3 = false;
        public bool isClicked_4 = false;

        public PIOTRUS(playersNick playersNick)
        {
            InitializeComponent();
            this.playersNick = playersNick;
            this.class1 = new createTable();
            this.form1 = playersNick.form1;
            this.uczestnicy = playersNick.uczestnicy;
            nameList = new List<string>();
            scoreList = new List<int>();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            SetBackgroundImage();
        }

        private void SetBackgroundImage()
        {
            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "niebo.jpg");

            if (System.IO.File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        // obstawianie koloru karty
        //1. trefl
        //2. karo
        //3. kier
        //4. pik
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexColor = comboBox1.SelectedIndex;
        }
        //obstawianie figury karty
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexFigure = comboBox2.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // playGame();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
        }

        private void PIOTRUS_Load(object sender, EventArgs e)
        {
            if (playersNick.playerTextBoxes.Length > 0)
                label3.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;

            pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");

            if (playersNick.playerTextBoxes.Length > 0)
                label3.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // karta 2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
        }
        // karta 3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
        }
        // 1 karta 
        private void button2_Click(object sender, EventArgs e)
        {
            isClicked_2 = true;
            playGame();
            
        }
        // 2 karta
        private void button3_Click(object sender, EventArgs e)
        {
            isClicked_3 = true;
            playGame();
            
        }
        // 3 karta
        private void button4_Click(object sender, EventArgs e)
        {
            isClicked_4 = true;
            playGame();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void playGame()
        {

            Random rnd = new Random();
            row_indeks = rnd.Next(0, 4); // kolory
            col_indeks = rnd.Next(2, 14); // figury

            if (isClicked_2 == true)
            {
                switch (row_indeks)
                {
                    case 0:
                        card_color = "trefl";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\1.png");
                        break;
                    case 1:
                        card_color = "karo";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\3.png");
                        break;
                    case 2:
                        card_color = "kier";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\4.png");
                        break;
                    case 3:
                        card_color = "pik";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\2.png");
                        break;

                }
                if (col_indeks == 9)
                {
                    card_figure = "J";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 10)
                {
                    card_figure = "Q";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 11)
                {
                    card_figure = "K";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 12)
                {
                    card_figure = "AS";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 13)
                {
                    card_figure = "JOCKER";
                    label6.Text = card_figure;
                }
                else
                {
                    card_figure = col_indeks.ToString();
                    label6.Text = card_figure;
                }
            }
            else if (isClicked_3 == true)
            {
                switch (row_indeks)
                {
                    case 0:
                        card_color = "trefl";
                        pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\1.png");
                        break;
                    case 1:
                        card_color = "karo";
                        pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\3.png");
                        break;
                    case 2:
                        card_color = "kier";
                        pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\4.png");
                        break;
                    case 3:
                        card_color = "pik";
                        pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\2.png");
                        break;

                }
                if (col_indeks == 9)
                {
                    card_figure = "J";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 10)
                {
                    card_figure = "Q";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 11)
                {
                    card_figure = "K";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 12)
                {
                    card_figure = "AS";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 13)
                {
                    card_figure = "JOCKER";
                    label6.Text = card_figure;
                }
                else
                {
                    card_figure = col_indeks.ToString();
                    label6.Text = card_figure;
                }
            }
            else if (isClicked_4 == true)
            {
                switch (row_indeks)
                {
                    case 0:
                        card_color = "trefl";
                        pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\1.png");
                        break;
                    case 1:
                        card_color = "karo";
                        pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\3.png");
                        break;
                    case 2:
                        card_color = "kier";
                        pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\4.png");
                        break;
                    case 3:
                        card_color = "pik";
                        pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\2.png");
                        break;

                }
                if (col_indeks == 9)
                {
                    card_figure = "J";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 10)
                {
                    card_figure = "Q";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 11)
                {
                    card_figure = "K";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 12)
                {
                    card_figure = "AS";
                    label6.Text = card_figure;
                }
                else if (col_indeks == 13)
                {
                    card_figure = "JOCKER";
                    label6.Text = card_figure;
                }
                else
                {
                    card_figure = col_indeks.ToString();
                    label6.Text = card_figure;
                }
            }
            isClicked_2 = false;
            isClicked_3 = false;
            isClicked_4 = false;


            if (row_indeks == selectedIndexColor && col_indeks == selectedIndexFigure)
            {
                MessageBox.Show("dobrze strzeliłeś", "Wygrałeś!");
                punkty = 1;
                pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                label6.Text = " ";
            }
            else
            {
                MessageBox.Show($"Źle strzeliłeś. Wartości karty to: kolor = {card_color}, figura = {card_figure}", "Przegrałeś!");
                punkty = 0;
                pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                pictureBox2.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                pictureBox3.Image = Image.FromFile("C:\\Users\\LAPTOP\\source\\repos\\lab1\\karcioszki\\karcioszki\\revers.png");
                label6.Text = " ";
            }

            nameList.Add(playersNick.playerTextBoxes[currentPlayerIndex].Text);
            scoreList.Add(punkty);

            currentPlayerIndex++;
            if (currentPlayerIndex >= playersNick.uczestnicy.SelectedNumberOfPlayers)
            {
                currentPlayerIndex = 0;
                saveResultsToCSV();
                MessageBox.Show("Gra zakończona. Wyniki zostały zapisane do pliku CSV.");
                Application.Exit();
            }
            else
            {
                label3.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;
            }
        }
    }
}
