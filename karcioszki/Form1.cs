namespace karcioszki
{
    public partial class Form1 : Form
    {
        liczba_os uczestnicy;
        public string osoby;
        public Form1()
        {
            InitializeComponent();
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
    }
}