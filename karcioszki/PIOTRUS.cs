using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace karcioszki
{

    public partial class PIOTRUS : Form
    {
        Form1 form1;
        createTable class1;
        public int[,] tab_card;
        public int selectedIndexColor;
        public int selectedIndexFigure;
        public int row_indeks;
        public int col_indeks;
        public string card_color;
        public string card_figure;

        public PIOTRUS(Form1 form1)
        {
            InitializeComponent();
            this.class1 = new createTable();
            this.form1 = form1;
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
        //graj
        private void button1_Click(object sender, EventArgs e)
        {
            playGame();
        }
        
        //nicki graczy
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void playGame()
        {
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    row_indeks = rnd.Next(0, 4); // kolory
                    col_indeks = rnd.Next(0, 13); // figury
                }
            }

            switch (row_indeks)
            {
                case 0:
                    card_color = "trefl";
                    break;
                case 1:
                    card_color = "karo";
                    break;
                case 2:
                    card_color = "kier";
                    break;
                case 3:
                    card_color = "pik";
                    break;
            }
            if (col_indeks == 9)
            {
                card_figure = "J";
            }
            if (col_indeks == 10)
            {
                card_figure = "Q";
            }
            if (col_indeks == 11)
            {
                card_figure = "K";
            }
            if (col_indeks == 12)
            {
                card_figure = "AS";
            }
            if (col_indeks == 13)
            {
                card_figure = "JOCKER";
            }
            else { card_figure = col_indeks.ToString(); }

            if (row_indeks == selectedIndexColor && col_indeks == selectedIndexFigure)
            {
                MessageBox.Show("dobrze strzeliles", "Wygrales!");
            }
            else
            {
                MessageBox.Show($"Zle strzeliles. Wartości: kolor = {card_color}, figura = {card_figure}", "Przegrales!");
            }
        }
        //obrazek
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PIOTRUS_Load(object sender, EventArgs e)
        {

        }
    }
}
