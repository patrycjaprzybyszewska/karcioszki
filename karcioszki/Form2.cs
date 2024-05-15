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
		liczba_os uczestnicy;
		Form1 form1;

		public Form2(playersNick playersNick)
        {
            InitializeComponent();
			this.playersNick = playersNick;
			this.form1 = playersNick.form1;
			this.uczestnicy = playersNick.uczestnicy;
		}
    }
}
