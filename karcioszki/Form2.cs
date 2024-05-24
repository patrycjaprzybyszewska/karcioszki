using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace karcioszki
{
	public partial class Form2 : Form
	{
		private List<string> taliaKart;
		private Random random = new Random();
		liczba_os liczba;
		int liczbaGraczy;
		private List<Tuple<string, string>> Player1;
		private List<Tuple<string, string>> Player2;
		private List<Tuple<string, string>> Player3;
		private List<Tuple<string, string>> Player4;
		private List<string> playerNames;
		private Button kartaNaSrodku;
		private Button dobierzButton;
		private Button dalejButton;
		private Label labelPlayer1;
		playersNick playersNick;
		liczba_os uczestnicy;
		Form1 form1;
		bool makaoCalled = false;
		bool pomakaleCalled = false;
		private int currentPlayerIndex = 0;
		private List<int> winningPlayers;
		bool klik = false;

		public Form2(playersNick playersNick)
		{
			InitializeComponent();
			this.playersNick = playersNick;
			this.form1 = playersNick.form1;
			this.uczestnicy = playersNick.uczestnicy;
			this.liczbaGraczy = playersNick.liczbaGraczy;
			this.playerNames = playersNick.playerNames;
			InicjalizujTalie(); 
			SetBackgroundImage();
			CreateCentralCard();
			int initialCardCount = 5;
			Player1 = CreateUserCardList(initialCardCount);
			CreateCardButtonsFromList(Player1, true, "dol");
			Player2 = CreateUserCardList(initialCardCount);
			CreateCardButtonsFromList(Player2, false, "gora");
			AddDobierzButton();
			AddMakaoButtons();
			AddPlayerNameLabels();

			if (liczbaGraczy >= 3)
			{
				Player3 = CreateUserCardList(initialCardCount);
				CreateCardButtonsFromList(Player3, false, "prawo");
			}
			else
			{
				Player3 = new List<Tuple<string, string>>();
			}

			if (liczbaGraczy == 4)
			{
				Player4 = CreateUserCardList(initialCardCount);
				CreateCardButtonsFromList(Player4, false, "lewo");
			}
			else
			{
				Player4 = new List<Tuple<string, string>>();
			}
		}

		private void AddPlayerNameLabels()
		{
			labelPlayer1 = new Label();
			labelPlayer1.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;
			labelPlayer1.Visible = true;
			labelPlayer1.AutoSize = true;
			labelPlayer1.Location = new Point(this.ClientSize.Width - 180, this.ClientSize.Height - 140);
			labelPlayer1.ForeColor = Color.White;
			labelPlayer1.Font = new Font(labelPlayer1.Font.FontFamily, labelPlayer1.Font.Size * 2, labelPlayer1.Font.Style);
			labelPlayer1.BackColor = Color.Transparent;
			this.Controls.Add(labelPlayer1);
		}

		private void AddMakaoButtons()
		{
			Point cardLocation = kartaNaSrodku.Location;

			Button makaoButton = new Button();
			makaoButton.Text = "Makao";
			makaoButton.Size = new Size(150, 50);
			makaoButton.Location = new Point(cardLocation.X, cardLocation.Y - 100);
			makaoButton.Click += new EventHandler(this.Makao_Click);
			this.Controls.Add(makaoButton);

			Button poMakaleButton = new Button();
			poMakaleButton.Text = "Po makale";
			poMakaleButton.Size = new Size(150, 50);
			poMakaleButton.Location = new Point(cardLocation.X, cardLocation.Y - 50);
			poMakaleButton.Click += new EventHandler(this.PoMakale_Click);
			this.Controls.Add(poMakaleButton);
		}

		private void Makao_Click(object sender, EventArgs e)
		{
			if(Player1.Count == 1)
			{
				makaoCalled = true;
				MessageBox.Show("Makao!");
			}
			else
			{
				MessageBox.Show("Nie możesz wywołać Makao gdy masz więcej niż 1 kartę");
			}
		}

		private void PoMakale_Click(object sender, EventArgs e)
		{
			if (Player1.Count == 0)
			{
				MessageBox.Show("Wygrałeś! Gratulacje!");

				winningPlayers.Add(currentPlayerIndex);
				pomakaleCalled = true;
				
				if (winningPlayers.Count == liczbaGraczy - 1)
				{
					foreach (var playerIndex in Enumerable.Range(0, liczbaGraczy).Except(winningPlayers))
					{
						winningPlayers.Add(playerIndex);
					}


					string resultMessage = "Kolejność wygranych:\n";
					for (int i = 0; i < winningPlayers.Count; i++)
					{
						resultMessage += $"{i + 1}. {playerNames[winningPlayers[i]]}\n";
					}
					
					MessageBox.Show(resultMessage);
					this.Close();
				}
				else
				{
					ShowDalejButton();
					if (Player1.Count == 0 && winningPlayers.Contains(currentPlayerIndex))
					{
						DisableAllButtons();
					}
				}
			}
		}

		private void DisableAllButtons()
		{
			foreach (Control control in this.Controls)
			{
				if (control is Button button && button != dalejButton && button != kartaNaSrodku)
				{
					button.Enabled = false;
				}
			}
		}

		private void AddDobierzButton()
		{
			dobierzButton = new Button();
			dobierzButton.Text = "Dobierz";
			dobierzButton.Size = new Size(150, 50);
			dobierzButton.Location = new Point(this.ClientSize.Width - 180, this.ClientSize.Height - 70);
			dobierzButton.Click += new EventHandler(this.Dobierz_Click);
			this.Controls.Add(dobierzButton);
		}

		private void Dobierz_Click(object sender, EventArgs e)
		{
			if (taliaKart.Count > 0)
			{
				string kolor, wartosc;
				Losuj(out kolor, out wartosc);
				Player1.Add(new Tuple<string, string>(kolor, wartosc));

				int cardWidth = 100;
				int cardHeight = 160;
				int startX = (this.ClientSize.Width / 2) - (cardWidth * Player1.Count / 2) + 50;
				int startY = this.ClientSize.Height - cardHeight - 10;
				int cardPositionX = startX + (Player1.Count - 1) * cardWidth;

				Button newCardButton = new Button();
				newCardButton.Size = new Size(cardWidth, cardHeight);
				newCardButton.BackgroundImage = Image.FromFile(GetImagePath(kolor));
				newCardButton.BackgroundImage.Tag = kolor;
				newCardButton.BackgroundImageLayout = ImageLayout.Stretch;
				newCardButton.Text = wartosc;
				newCardButton.TextAlign = ContentAlignment.TopCenter;
				newCardButton.Font = new Font(newCardButton.Font, FontStyle.Bold);
				newCardButton.Location = new Point(cardPositionX, startY);
				newCardButton.Click += new EventHandler(this.Card_Click);

				this.Controls.Add(newCardButton);

				dobierzButton.Enabled = false;

				bool hasValidMove = Player1.Any(card => card.Item1 == kartaNaSrodku.BackgroundImage.Tag.ToString() || card.Item2 == kartaNaSrodku.Text);
				if (!hasValidMove)
				{
					ShowDalejButton();
				}
			}
			else if (taliaKart.Count == 0)
			{
				ReturnCards();
			}
		}

		private void ReturnCards()
		{
			HashSet<string> cardsOnTable = new HashSet<string>();

			string centralCard = $"{kartaNaSrodku.BackgroundImage.Tag}{kartaNaSrodku.Text}";
			cardsOnTable.Add(centralCard);

			AddCardsToHashSet(cardsOnTable, Player1);
			AddCardsToHashSet(cardsOnTable, Player2);
			if (liczbaGraczy >= 3)
			{
				AddCardsToHashSet(cardsOnTable, Player3);
			}
			if (liczbaGraczy == 4)
			{
				AddCardsToHashSet(cardsOnTable, Player4);
			}

			List<string> cardsNotOnTable = taliaKart.Where(card => !cardsOnTable.Contains(card)).ToList();

			taliaKart.AddRange(cardsNotOnTable);

		}

		private void AddCardsToHashSet(HashSet<string> hashSet, List<Tuple<string, string>> cards)
		{
			foreach (var card in cards)
			{
				hashSet.Add($"{card.Item1}{card.Item2}");
			}
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

		private void ShowDalejButton()
		{
			dalejButton = new Button();
			dalejButton.Text = "Dalej";
			dalejButton.Size = new Size(100, 50);
			dalejButton.Location = new Point((this.ClientSize.Width / 2) - 50, (this.ClientSize.Height / 2) + 130);
			dalejButton.Click += new EventHandler(this.Dalej_Click);
			this.Controls.Add(dalejButton);
		}

		private void CreateCentralCard()
		{
			string kolor, wartosc;
			Losuj(out kolor, out wartosc);
			kartaNaSrodku = new Button();
			kartaNaSrodku.Size = new Size(150, 240);
			kartaNaSrodku.Location = new Point((this.ClientSize.Width / 2) - 75, (this.ClientSize.Height / 2) - 120);
			kartaNaSrodku.BackgroundImage = Image.FromFile(GetImagePath(kolor));
			kartaNaSrodku.BackgroundImage.Tag = kolor; 
			kartaNaSrodku.BackgroundImageLayout = ImageLayout.Stretch;
			kartaNaSrodku.Text = wartosc;
			kartaNaSrodku.TextAlign = ContentAlignment.TopCenter;
			kartaNaSrodku.Font = new Font(kartaNaSrodku.Font, FontStyle.Bold);
			this.Controls.Add(kartaNaSrodku);
		}

		private List<Tuple<string, string>> CreateUserCardList(int numberOfCards)
		{
			var cardList = new List<Tuple<string, string>>();
			for (int i = 0; i < numberOfCards; i++)
			{
				string kolor, wartosc;
				Losuj(out kolor, out wartosc);
				cardList.Add(new Tuple<string, string>(kolor, wartosc));
			}
			return cardList;
		}

		private void CreateCardButtonsFromList(List<Tuple<string, string>> cardList, bool isUser, string position)
		{
			int cardWidth = 100;
			int cardHeight = 160;
			int startX = 10;
			int startY = 10;

			if (liczbaGraczy >= 2)
			{
				if (position == "dol")
				{
					startY = this.ClientSize.Height - cardHeight - 10;
					startX = (this.ClientSize.Width / 2) - (cardWidth * cardList.Count / 2);
				}
				else if (position == "gora")
				{
					startY = 10;
					startX = (this.ClientSize.Width / 2) - (cardWidth * cardList.Count / 2);
				}
			}

			if (liczbaGraczy >= 3)
			{
				if (position == "prawo")
				{
					startX = this.ClientSize.Width - cardHeight - 10;
					startY = (this.ClientSize.Height / 2) - (cardWidth * cardList.Count / 2);
					int temp = cardWidth;
					cardWidth = cardHeight;
					cardHeight = temp;
				}
			}

			if (liczbaGraczy == 4)
			{
				if (position == "lewo")
				{
					startX = 10;
					startY = (this.ClientSize.Height / 2) - (cardWidth * cardList.Count / 2);
					int temp = cardWidth;
					cardWidth = cardHeight;
					cardHeight = temp;
				}
			}

			string basePath = AppDomain.CurrentDomain.BaseDirectory;
			string reversImagePath = Path.Combine(basePath, "revers.png");

			for (int i = 0; i < cardList.Count; i++)
			{
				var (kolor, wartosc) = cardList[i];
				Button card = new Button();
				card.Size = new Size(cardWidth, cardHeight);

				if (position == "dol" || position == "gora")
				{
					card.Location = new Point(startX + (cardWidth * i), startY);
				}
				else
				{
					card.Location = new Point(startX, startY + (cardHeight * i));
				}

				string imagePath = isUser ? GetImagePath(kolor) : reversImagePath;
				if (File.Exists(imagePath))
				{
					card.BackgroundImage = Image.FromFile(imagePath);
				}
				card.BackgroundImage.Tag = kolor;
				card.BackgroundImageLayout = ImageLayout.Stretch;
				card.Text = isUser ? wartosc : "";
				card.TextAlign = ContentAlignment.TopCenter;
				card.Font = new Font(card.Font, FontStyle.Bold);
				if (isUser)
				{
					card.Click += new EventHandler(this.Card_Click);
				}
				this.Controls.Add(card);
			}
		}


		private void Card_Click(object sender, EventArgs e)
		{
			Button clickedCard = sender as Button;
			if (clickedCard != null && kartaNaSrodku.BackgroundImage != null && clickedCard.BackgroundImage != null)
			{
				string kolorKlikniete = clickedCard.BackgroundImage.Tag?.ToString();
				string wartoscKlikniete = clickedCard.Text;

				if (kartaNaSrodku.BackgroundImage != null)
				{
					string kolorKartyNaSrodku = kartaNaSrodku.BackgroundImage.Tag?.ToString();
					string wartoscKartyNaSrodku = kartaNaSrodku.Text;

					if (kolorKlikniete?.ToLower() == kolorKartyNaSrodku?.ToLower() || wartoscKlikniete == wartoscKartyNaSrodku)
					{
						kartaNaSrodku.BackgroundImage = clickedCard.BackgroundImage;
						kartaNaSrodku.BackgroundImage.Tag = kolorKlikniete;
						kartaNaSrodku.Text = clickedCard.Text;

						var cardToRemove = new Tuple<string, string>(kolorKlikniete, wartoscKlikniete);
						Player1.Remove(cardToRemove);
						this.Controls.Remove(clickedCard);

						dobierzButton.Enabled = false;

						if (!Player1.Any(k => k.Item2 == wartoscKlikniete))
						{
							if(currentPlayerIndex != liczbaGraczy - 1)
							{
								MessageBox.Show("Koniec ruchu! Kolej gracza: " + playersNick.playerTextBoxes[currentPlayerIndex + 1].Text);
							}
							else
							{
								MessageBox.Show("Koniec ruchu! Kolej gracza: " + playersNick.playerTextBoxes[0].Text);
							}
							
							ShowDalejButton();
							DisablePlayerButtons();
							klik = true;
						}
						else if (Player1.Count == 1 && !makaoCalled)
						{
							MessageBox.Show("Brak makao! Plus 5 kart.");
							DrawAdditionalCards(5);
						}
					}
					
					else
					{
						MessageBox.Show("Nie można wykonać tego ruchu");
					}
				}
			}
		
			else
			{
				 MessageBox.Show("Błąd: Karta na środku lub kliknięta karta nie jest poprawnie ustawiona");
			}
		}

		private void DisablePlayerButtons()
		{
			foreach (Control control in this.Controls)
			{
				if (control is Button button && Player1.Any(card => button.Text == card.Item2))
				{
					button.Enabled = false;
				}
			}
		}

		private void Dalej_Click(object sender, EventArgs e)
		{
			Button dalejButton = sender as Button;
			if (dalejButton != null)
			{
				this.Controls.Remove(dalejButton);
			}
			if (Player1.Count == 0)
			{
				MessageBox.Show("Brak po makale! Plus 5 kart.");
				DrawAdditionalCards(5);
			}
			else if (Player1.Count == 1 && !makaoCalled)
			{
				MessageBox.Show("Brak makao! Plus 5 kart.");
				DrawAdditionalCards(5);
			}
			currentPlayerIndex = (currentPlayerIndex + 1) % liczbaGraczy;
			labelPlayer1.Text = playersNick.playerTextBoxes[currentPlayerIndex].Text;
			RotatePlayers();
			RemoveAllCardButtons();
			RedrawBoard();
			EnableAllCardButtons();
			makaoCalled = false;
			pomakaleCalled = false;
		}

		private void EnableAllCardButtons()
		{
			foreach (Control control in this.Controls)
			{
				if (control is Button button && button != kartaNaSrodku)
				{
					button.Enabled = true;
				}
			}
		}

		private void RemoveAllCardButtons()
		{
			var controlsToRemove = new List<Control>();
			foreach (Control control in this.Controls)
			{
				if (control is Button button && button != kartaNaSrodku && button != dobierzButton && button.Text != "Makao" && button.Text != "Po makale")
				{
					controlsToRemove.Add(control);
				}
			}
			foreach (var control in controlsToRemove)
			{
				this.Controls.Remove(control);
			}
		}

		private void RedrawBoard()
		{
			RemoveAllCardButtons();

			CreateCardButtonsFromList(Player1, true, "dol");
			CreateCardButtonsFromList(Player2, false, "gora");

			if (liczbaGraczy >= 3)
			{
				CreateCardButtonsFromList(Player3, false, "prawo");
			}
			if (liczbaGraczy == 4)
			{
				CreateCardButtonsFromList(Player4, false, "lewo");
			}
		}

		private void DrawAdditionalCards(int count)
		{
			for (int i = 0; i < count; i++)
			{
				if (taliaKart.Count >= count)
				{
					string kolor, wartosc;
					Losuj(out kolor, out wartosc);
					Player1.Add(new Tuple<string, string>(kolor, wartosc));
				}
				else
				{
					ReturnCards();
					DrawAdditionalCards(count);
				}
			}
		}

		private void RotatePlayers()
		{
			klik = false;
			List<Tuple<string, string>> temp = Player1;
			Player1 = Player2;

			if (liczbaGraczy == 2)
			{
				Player2 = temp;
			}
			else if (liczbaGraczy == 3)
			{
				Player2 = Player3;
				Player3 = temp;
			}
			else if (liczbaGraczy == 4)
			{
				Player2 = Player3;
				Player3 = Player4;
				Player4 = temp;
			}
		}
	

		private string GetImagePath(string kolor)
		{
			string basePath = AppDomain.CurrentDomain.BaseDirectory;
			string imageName = kolor + ".png";
			return Path.Combine(basePath, imageName);
		}

		private void Losuj(out string kolor, out string wartosc)
		{
			int losowyIndex = random.Next(taliaKart.Count);
			string wylosowanaKarta = taliaKart[losowyIndex];

			kolor = wylosowanaKarta.Substring(0, 1);
			wartosc = wylosowanaKarta.Substring(1);

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