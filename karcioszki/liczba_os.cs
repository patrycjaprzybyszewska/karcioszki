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
        public liczba_os(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        // 2 osoby
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            form1.osoby = checkBox1.Text;
            startGry();
        }
        //3 osoby
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            form1.osoby = checkBox2.Text;
            startGry();
        }
        // 4 osoby
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            form1.osoby = checkBox3.Text;
            startGry();
        }
        // 5 osob
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            form1.osoby = checkBox4.Text;
            startGry();
        }
        // 6 osob
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            form1.osoby = checkBox5.Text;
            startGry();
        }
        private void startGry()
        {
            if (this.piotrus == null || piotrus.IsDisposed)
            {
                this.piotrus = new PIOTRUS(this.form1);
                this.piotrus.Show();
                this.piotrus.Focus();
                return;
            }
            this.piotrus.Focus();
        }
    }
}
