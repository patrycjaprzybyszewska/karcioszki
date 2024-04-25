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
        public string osoby;
        public liczba_os()
        {
            InitializeComponent();
        }
        // 2 osoby
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            osoby = checkBox1.Text;
        }
        //3 osoby
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            osoby = checkBox2.Text;
        }
        // 4 osoby
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            osoby = checkBox3.Text;
        }
        // 5 osob
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            osoby = checkBox4.Text;
        }
        // 6 osob
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            osoby = checkBox5.Text;
        }
    }
}
