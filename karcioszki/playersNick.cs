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
    public partial class playersNick : Form
    {
        public Form1 form1;
        public Form2 form2;
        public int liczbaGraczy;
        public liczba_os uczestnicy;
        PIOTRUS piotrus;
        Wojna2 Wojna;
        public TextBox[] playerTextBoxes;
        public playersNick(Form1 form1, liczba_os uczestnicy)
        {
            InitializeComponent();
            this.liczbaGraczy = liczbaGraczy;
            this.form1 = form1;
            this.uczestnicy = uczestnicy;
            this.form1 = form1;
           
           playerTextBoxes = new TextBox[uczestnicy.SelectedNumberOfPlayers];

            for (int i = 0; i < uczestnicy.SelectedNumberOfPlayers; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(20, 50 + i * 30); // Ustawienie lokalizacji każdego pola TextBox
                this.Controls.Add(textBox); // Dodanie pola TextBox do formularza
                playerTextBoxes[i] = textBox; // Dodanie pola TextBox do tablicy
            }
        }
      

        private void playersNick_Load(object sender, EventArgs e)
        {

        }

        private void addPlayers(object sender, EventArgs e)
        {

        }
        // guzior graj
        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.button4WasClicked == true)
            {
                if (this.piotrus == null || piotrus.IsDisposed)
                {
                    this.piotrus = new PIOTRUS(this);
                    this.piotrus.Show();
                    this.piotrus.Focus();

                    return;
                }
                this.piotrus.Focus();
            }
            if (form1.button2WasClicked == true)
            {


                if (this.Wojna == null || Wojna.IsDisposed)
                {
                    this.Wojna = new Wojna2(this);
                    this.Wojna.Show();
                    this.Wojna.Focus();

                    return;
                }
                this.Wojna.Focus();
            }
			if (form1.button1WasClicked == true)
			{


				if (this.form2 == null || form2.IsDisposed)
				{
					this.form2 = new Form2(this);
					this.form2.Show();
					this.form2.Focus();

					return;
				}
				this.form2.Focus();
			}
		}
        //tu wprowadzamy nick
        
        private void writeNick(object sender, EventArgs e)
        {
            List<string> playerNames = new List<string>(); 

            foreach (TextBox textBox in playerTextBoxes)
            {
                playerNames.Add(textBox.Text); // Dodanie zawartości pola TextBox do listy
            }
        }
    }
}
