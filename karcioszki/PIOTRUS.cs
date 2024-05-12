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
            playGame();
        }

        public void playGame()
        {
            Random rnd = new Random();
            row_indeks = rnd.Next(0, 4); // kolory
            col_indeks = rnd.Next(2, 14); // figury

            switch (row_indeks)
            {
                case 0:
                    card_color = "trefl";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\2.png");
                    break;
                case 1:
                    card_color = "karo";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\4.png");
                    break;
                case 2:
                    card_color = "kier";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\1.png");
                    break;
                case 3:
                    card_color = "pik";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\3.png");
                    break;

            }
            if (col_indeks == 9)
            {
                card_figure = "J";
                label5.Text = card_figure;
            }
            else if (col_indeks == 10)
            {
                card_figure = "Q";
                label5.Text = card_figure;
            }
            else if (col_indeks == 11)
            {
                card_figure = "K";
                label5.Text = card_figure;
            }
            else if (col_indeks == 12)
            {
                card_figure = "AS";
                label5.Text = card_figure;
            }
            else if (col_indeks == 13)
            {
                card_figure = "JOCKER";
                label5.Text = card_figure;
            }
            else { 
                card_figure = col_indeks.ToString();
                label5.Text = card_figure;
            }

            if (row_indeks == selectedIndexColor && col_indeks == selectedIndexFigure)
            {
                MessageBox.Show("dobrze strzeliłeś", "Wygrałeś!");
                punkty = 1;
                pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\revers.png");
                label5.Text = " ";
            }
            else
            {
                MessageBox.Show($"Źle strzeliłeś. Wartości karty to: kolor = {card_color}, figura = {card_figure}", "Przegrałeś!");
                punkty = 0;
                pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\revers.png");
                label5.Text = " ";
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
            Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\revers.png");
        }

        private void PIOTRUS_Load(object sender, EventArgs e)
        {
            if (playersNick.playerTextBoxes.Length > 0)
                label3.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;

            pictureBox1.Image = Image.FromFile("C:\\Users\\LAPTOP\\OneDrive\\Pulpit\\studia\\semestr_4\\p_wizualne\\revers.png");

            if (playersNick.playerTextBoxes.Length > 0)
                label3.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //d ofigury wpis
        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
