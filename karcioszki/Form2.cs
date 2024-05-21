using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
		private List<string> taliaKart;
		private Random random = new Random();
		private List<Button> Player1;
		private List<Button> Player2;
		private List<Button> Player3;
		private List<Button> Player4;
		private Button kartaNaSrodku;

		public Form2(playersNick playersNick)
		{
			InitializeComponent();
			this.playersNick = playersNick;
			this.form1 = playersNick.form1;
			this.uczestnicy = playersNick.uczestnicy;
			this.liczbaGraczy = playersNick.liczbaGraczy;
			InicjalizujTalie();
			SetBackgroundImage();
			CreateCentralCard();
			CreateUserCardButtons();
		}

		private void InicjalizujTalie()
		{
			string[] kolory = { "1", "2", "3", "4" };
			string[] wartosci = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "W", "D", "K" };
			taliaKart = new List<string>();

			foreach (string kolor in kolory)
			{
				foreach (string wartosc in wartosci)
				{
					taliaKart.Add(kolor + wartosc);
				}
			}
		}

		private void CreateCentralCard()
		{
			string kolor, wartosc;
			Losuj(out kolor, out wartosc);
			kartaNaSrodku = new Button();
			kartaNaSrodku.Size = new Size(150, 240);
			kartaNaSrodku.Location = new Point((this.ClientSize.Width / 2) - 75, (this.ClientSize.Height / 2) - 120);
			kartaNaSrodku.BackgroundImage = Image.FromFile(GetImagePath(kolor));
			kartaNaSrodku.BackgroundImageLayout = ImageLayout.Stretch;
			kartaNaSrodku.Text = wartosc;
			kartaNaSrodku.TextAlign = ContentAlignment.TopCenter;
			kartaNaSrodku.Font = new Font(kartaNaSrodku.Font, FontStyle.Bold);
			this.Controls.Add(kartaNaSrodku);
		}

		private void CreateUserCardButtons()
		{
			Player1 = new List<Button>();
			int cardWidth = 100;
			int cardHeight = 160;
			string rewers = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "revers.png");


			for (int i = 0; i < 5; i++)
			{
				string kolor, wartosc;
				Losuj(out kolor, out wartosc);
				Button card = new Button();
				card.Size = new Size(cardWidth, cardHeight);
				card.Location = new Point((this.ClientSize.Width / 2) - (cardWidth * 5 / 2) + (cardWidth * i), 10);
				card.BackgroundImage = Image.FromFile(rewers);
				card.BackgroundImageLayout = ImageLayout.Stretch;
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
				card.BackgroundImage = Image.FromFile(GetImagePath(kolor));
				card.BackgroundImageLayout = ImageLayout.Stretch;
				card.Text = wartosc;
				card.TextAlign = ContentAlignment.TopCenter;
				card.Font = new Font(card.Font, FontStyle.Bold);
				card.Click += new EventHandler(this.Card_Click);
				this.Controls.Add(card);
				Player1.Add(card);
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
					card.BackgroundImage = Image.FromFile(rewers);
					card.BackgroundImageLayout = ImageLayout.Stretch;
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
						card.BackgroundImage = Image.FromFile(rewers);
						card.BackgroundImageLayout = ImageLayout.Stretch;
						card.Font = new Font(card.Font, FontStyle.Bold);
						this.Controls.Add(card);
					}
				}
			}
		}

		private void Card_Click(object sender, EventArgs e)
		{
			Button clickedCard = sender as Button;
			if (clickedCard != null)
			{
				string kolorKartyNaSrodku = kartaNaSrodku.BackgroundImage.Tag.ToString();
				string wartoscKartyNaSrodku = kartaNaSrodku.Text;

				string kolorKlikniete = clickedCard.BackgroundImage.Tag.ToString();
				string wartoscKlikniete = clickedCard.Text;

				if (kolorKlikniete == kolorKartyNaSrodku || wartoscKlikniete == wartoscKartyNaSrodku)
				{
					kartaNaSrodku.BackgroundImage = clickedCard.BackgroundImage;
					kartaNaSrodku.Text = clickedCard.Text;

					Player1.Remove(clickedCard);
					this.Controls.Remove(clickedCard);
				}
				else
				{
					MessageBox.Show("Nie można wykonać tego ruchu");
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
			string wylosowanaKarta = taliaKart[losowyIndex];

			kolor = wylosowanaKarta.Substring(0, 1);
			motyw = wylosowanaKarta.Substring(1);

			taliaKart.RemoveAt(losowyIndex);
		}

		private void SetBackgroundImage()
		{
			string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "trawa.jpg");

			if (System.IO.File.Exists(imagePath))
			{
				this.BackgroundImage = Image.FromFile(imagePath);
				this.BackgroundImageLayout = ImageLayout.Stretch;
			}
		}
	}
}
