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
        
        Form1 form1;
        PIOTRUS piotrus;
        playersNick playersNick;
        public int SelectedNumberOfPlayers;
        public liczba_os(Form1 form1, playersNick playersNick)
        {
            InitializeComponent();
            this.form1 = form1;
            this.playersNick = playersNick;
        }
        // 2 osoby
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //form1.osoby = checkBox1.Text;
            SelectedNumberOfPlayers = 2;
            startGry();
        }
        //3 osoby
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //form1.osoby = checkBox2.Text;
            SelectedNumberOfPlayers = 3;
            startGry();
        }
        // 4 osoby
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //form1.osoby = checkBox3.Text;
            SelectedNumberOfPlayers = 4;
            startGry();
        }
        // 5 osob
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //form1.osoby = checkBox4.Text;
            SelectedNumberOfPlayers = 5;
            startGry();
        }
        // 6 osob
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //form1.osoby = checkBox5.Text;
            SelectedNumberOfPlayers = 6;
            startGry();
        }
        private void startGry()
        {
            if (this.playersNick == null || playersNick.IsDisposed)
            {
                this.playersNick = new playersNick(this.form1, this);
                this.playersNick.Show();
                this.playersNick.Focus();
                /*if (checkBox1.Checked)
                {
                    SelectedNumberOfPlayers = 2;
                }
                else if (checkBox2.Checked)
                {
                    SelectedNumberOfPlayers = 3;
                }
                else if (checkBox3.Checked)
                {
                    SelectedNumberOfPlayers = 4;
                }
                else if (checkBox4.Checked)
                {
                    SelectedNumberOfPlayers = 5;
                }
                else if (checkBox5.Checked)
                {
                    SelectedNumberOfPlayers = 6;
                }*/
                return;
            }
            this.playersNick.Focus();
            

        }
    }
}
