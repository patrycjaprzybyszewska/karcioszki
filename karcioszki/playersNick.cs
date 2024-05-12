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
        Form1 form1;
        public int liczbaGraczy;
        liczba_os uczestnicy;
        public playersNick(int liczbaGraczy, Form1 form1)
        {
            InitializeComponent();
            this.liczbaGraczy = liczbaGraczy;
            this.form1 = form1;
        }

        private void playersNick_Load(object sender, EventArgs e)
        {

        }

        private void addPlayers(object sender, EventArgs e)
        {
            
        }
    }
}
