﻿using System;
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
        Wojna2 Wojna2;
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
