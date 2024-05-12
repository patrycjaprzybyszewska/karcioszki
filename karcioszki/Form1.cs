namespace karcioszki
{
    public partial class Form1 : Form
    {
        liczba_os uczestnicy;
        public string osoby;
        public Form1()
        {
            InitializeComponent();
            wojna2 = new Wojna2();
            Console.SetOut(new DebugTextWriter());
        }
       
        //piotrus

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.uczestnicy == null || uczestnicy.IsDisposed)
            {
                this.uczestnicy = new liczba_os(this);
                this.uczestnicy.Show();
                this.uczestnicy.Focus();
                return;
            }
            this.uczestnicy.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wojna2.Show();
            this.Hide();
        }
    }
}