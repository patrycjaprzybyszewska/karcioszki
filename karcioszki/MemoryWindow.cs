using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace karcioszki
{
    public partial class MemoryWindow : Form
    {
        public List<int> cardsCounter;
        public int dopasowania;
        private List<System.Drawing.Bitmap> cards;
        private List<PictureBox> flippedCards;

        public MemoryWindow()
        {
            InitializeComponent();
        }

        private void MEMORY_Load(object sender, EventArgs e)
        {
            dopasowania = 0;
            labelDopasowania.Text += dopasowania;
            cardsCounter = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            flippedCards = new List<PictureBox>();
            generateCards();
        }

        private void generateCards()
        {
            cards = new List<System.Drawing.Bitmap>();
            for (var i = 1; i <= 18; i++)
            {
                System.Drawing.Bitmap image = getRandomImage();

                cards.Add(image);
            }
        }

        private System.Drawing.Bitmap getRandomImage()
        {
            var random = new Random();
            int index = random.Next(0, cardsCounter.Count);

            while (cardsCounter[index] <= 0)
            {
                index = random.Next(0, cardsCounter.Count);
            }

            cardsCounter[index]--;

            switch (index)
            {
                case 0:
                    return Properties.Resources.pik;
                case 1:
                    return Properties.Resources.goro;
                case 2:
                    return Properties.Resources.monkey;
                case 3:
                    return Properties.Resources.karo;
                case 4:
                    return Properties.Resources.kiriu;
                case 5:
                    return Properties.Resources.kier;
                case 6:
                    return Properties.Resources.trefl;
                case 7:
                    return Properties.Resources.wizard;
                case 8:
                    return Properties.Resources.isaac;
                default:
                    return Properties.Resources.back; // Return a default image for null safety
            }
        }

        private void flipCard(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            var number = int.Parse(pictureBox.Name.Substring(4));

            if (flippedCards.Count < 2)
            {
                pictureBox.Image = cards[number];

                flippedCards.Add(pictureBox);
            }
            else
            {
                checkCards();
            }
            if (dopasowania >= 9)
            {
                MessageBox.Show("Gratulacje Wygrałeś!");
            }
        }

        private void checkCards()
        {
            Bitmap bmp1 = new Bitmap(flippedCards[0].Image);
            Bitmap bmp2 = new Bitmap(flippedCards[1].Image);
            if (areBitmapsEqual(bmp1, bmp2))
            {
                foreach (var card in flippedCards)
                {
                    card.Enabled = false;
                }
                flippedCards = new List<PictureBox>();
                dopasowania++;
                labelDopasowania.Text = "ilość dopasowań: " + dopasowania;
            }
            else
            {
                foreach (var card in flippedCards)
                {
                    card.Image = Properties.Resources.back;
                }
                flippedCards = new List<PictureBox>();
            }
        }
        private bool areBitmapsEqual(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
            {
                return false;
            }

            for (int y = 0; y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            dopasowania = 0;
            labelDopasowania.Text = "ilość dopasowań: " + dopasowania;
            cardsCounter = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            flippedCards = new List<PictureBox>();

            for (int y = 0; y < 18; y++)
            {
                PictureBox pictureBox = this.Controls.Find("card" + y, true).FirstOrDefault() as PictureBox;
                pictureBox.Image = Properties.Resources.back;
                pictureBox.Enabled = true;
            }
            generateCards();
        }
    }
}


