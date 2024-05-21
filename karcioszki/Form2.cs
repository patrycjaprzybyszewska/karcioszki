using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karcioszki
{
    public partial class Form2 : Form
    {
		playersNick playersNick;
		liczba_os liczba;
		liczba_os uczestnicy;
		Form1 form1;
		int liczbaGraczy;
		private List<Karta> taliaKart;
		private Random random = new Random();

		public Form2(playersNick playersNick)
        {
            InitializeComponent();
			this.playersNick = playersNick;
			this.form1 = playersNick.form1;
			this.uczestnicy = playersNick.uczestnicy;
			this.liczbaGraczy = playersNick.liczbaGraczy;
			InicjalizujTalie();
			SetBackgroundImage();
			CreateCardButtons();
		}

		private void InicjalizujTalie()
		{
			string[] kolory = { "1", "2", "3", "4" };
			string[] wartosci = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "W", "D", "K" };
			taliaKart = new List<Karta>();

			foreach (string kolor in kolory)
			{
				foreach (string wartosc in wartosci)
				{
					taliaKart.Add(new Karta(kolor, wartosc));
				}
			}
		}

		private void CreateCardButtons()
		{
			int cardWidth = 100; 
			int cardHeight = 160;

			for (int i = 0; i < 5; i++)
			{
				string kolor, wartosc;
				Losuj(out kolor, out wartosc);
				Button card = new Button();
				card.Size = new Size(cardWidth, cardHeight);
				card.Location = new Point((this.ClientSize.Width / 2) - (cardWidth * 5 / 2) + (cardWidth * i), 10);
				card.BackgroundImage = Image.FromFile(GetImagePath(kolor));
				card.BackgroundImageLayout = ImageLayout.Stretch;
				card.Text = wartosc;
				card.TextAlign = ContentAlignment.TopCenter;
				card.Font = new Font(card.Font, FontStyle.Bold);
				this.Controls.Add(card);
			}

			for (int i = 0; i < 5; i++)
			{
				string kolor, wartosc;
				Losuj(out kolor, out wartosc);
				Button card = new Button();
				card.Size = new Size(cardWidth, cardHeight);
				card.Location = new Point((this.ClientSize.Width / 2) - (cardWidth * 5 / 2) + (cardWidth * i), this.ClientSize.Height - cardHeight - 10);
				this.Controls.Add(card);
				card.BackgroundImage = Image.FromFile(GetImagePath(kolor));
				card.BackgroundImageLayout = ImageLayout.Stretch;
				card.Text = wartosc;
				card.TextAlign = ContentAlignment.TopCenter;
				card.Font = new Font(card.Font, FontStyle.Bold);
			}


			if (liczbaGraczy == 3 || liczbaGraczy == 4)
			{
				for (int i = 0; i < 5; i++)
				{
					string kolor, wartosc;
					Losuj(out kolor, out wartosc);
					Button card = new Button();
					card.Size = new Size(cardHeight, cardWidth);
					card.Location = new Point(10, (this.ClientSize.Height / 2) - (cardWidth * 5 / 2) + (cardWidth * i));
					card.BackgroundImage = Image.FromFile(GetImagePath(kolor));
					card.BackgroundImageLayout = ImageLayout.Stretch;
					card.Text = wartosc;
					card.TextAlign = ContentAlignment.TopCenter;
					card.Font = new Font(card.Font, FontStyle.Bold);
					this.Controls.Add(card);
				}

				if (liczbaGraczy == 4)
				{
					for (int i = 0; i < 5; i++)
					{
						string kolor, wartosc;
						Losuj(out kolor, out wartosc);
						Button card = new Button();
						card.Size = new Size(cardHeight, cardWidth); 
						card.Location = new Point(this.ClientSize.Width - cardHeight - 10, (this.ClientSize.Height / 2) - (cardWidth * 5 / 2) + (cardWidth * i));
						card.BackgroundImage = Image.FromFile(GetImagePath(kolor));
						card.BackgroundImageLayout = ImageLayout.Stretch;
						card.Text = wartosc;
						card.TextAlign = ContentAlignment.TopCenter;
						card.Font = new Font(card.Font, FontStyle.Bold);
						this.Controls.Add(card);
					}
				}
			}
		}

		private string GetImagePath(string kolor)
		{
			string basePath = AppDomain.CurrentDomain.BaseDirectory;
			string imageName = kolor + ".png";
			return Path.Combine(basePath, imageName);
		}

		private void Losuj(out string kolor, out string motyw)
		{
			int losowyIndex = random.Next(taliaKart.Count);
			Karta wylosowanaKarta = taliaKart[losowyIndex];

			kolor = wylosowanaKarta.Kolor;
			motyw = wylosowanaKarta.Motyw;

			taliaKart.RemoveAt(losowyIndex);
		}

		private void SetBackgroundImage()
		{
			string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "trawa.jpg");

			if(System.IO.File.Exists(imagePath))
			{
				this.BackgroundImage = Image.FromFile(imagePath);
				this.BackgroundImageLayout = ImageLayout.Stretch;
			}
		}
	}

	public class Karta
	{
		public string Kolor { get; }
		public string Motyw { get; }

		public Karta(string kolor, string motyw)
		{
			kolor = kolor;
			motyw = motyw;
		}
	}
}
