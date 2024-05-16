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
    public partial class liczba_os : Form
    {

        MainWindow form1;
        Ruletka piotrus;
        Wojna2 Wojna;
        playersNick playersNick;
        public bool button2WasClicked = false;
        public bool button1WasClicked = false;
        public int SelectedNumberOfPlayers;
        public liczba_os(MainWindow form1, playersNick playersNick)
        {
            InitializeComponent();
            this.form1 = form1;
            this.playersNick = playersNick;

            if (form1.button1WasClicked == true)
            {
                checkBox4.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
                checkBox5.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (form1.button1WasClicked)
            {
                CheckBox checkBox = sender as CheckBox;

                if (checkBox != null && checkBox.Checked)
                {
                    checkBox.Checked = false;
					//MessageBox.Show("Wybierz od 2 do 4 graczy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
            }
        }

		// 2 osoby
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            SelectedNumberOfPlayers = 2;
            startGry();
        }
        //3 osoby
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            SelectedNumberOfPlayers = 3;
            startGry();
        }
        // 4 osoby
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            SelectedNumberOfPlayers = 4;
            startGry();
        }
        // 5 osob
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            SelectedNumberOfPlayers = 5;
            startGry();
        }
        // 6 osob
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            SelectedNumberOfPlayers = 6;
            startGry();
        }
        private void startGry()
        {
			if (button1WasClicked && (SelectedNumberOfPlayers == 5 || SelectedNumberOfPlayers == 6))
            {
				if (SelectedNumberOfPlayers == 5) checkBox4.Checked = false;
				if (SelectedNumberOfPlayers == 6) checkBox5.Checked = false;
				return;
			}
			if (form1.button2WasClicked == true)
            {
                DialogResult result = MessageBox.Show("Wojna jest grą dla dwóch osób");
                SelectedNumberOfPlayers = 2;
            }
            if (this.playersNick == null || playersNick.IsDisposed)
            {
                this.playersNick = new playersNick(this.form1, this);
                this.playersNick.Show();
                this.playersNick.Focus();

                return;
            }
            this.playersNick.Focus();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
