namespace karcioszki
{
    public partial class MainWindow : Form
    {
        MemoryWindow memory; 
        liczba_os uczestnicy;
        public string osoby;
        playersNick PlayersNick;
        public bool button4WasClicked = false;
        public bool button2WasClicked = false;
        public MainWindow()
        public bool button1WasClicked = false;
        public Form1()
        {
            InitializeComponent();
            //wojna2 = new Wojna2();
            Console.SetOut(new DebugTextWriter());
        }

        //piotrus
        

        public void button4_Click(object sender, EventArgs e)
        {
           
            button4WasClicked = true;
            if (this.uczestnicy == null || uczestnicy.IsDisposed)
            {
                this.uczestnicy = new liczba_os(this, this.PlayersNick);
                this.uczestnicy.Show();
                this.uczestnicy.Focus();
                return;
            }
            this.uczestnicy.Focus();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            if (this.uczestnicy == null || uczestnicy.IsDisposed)
            {
                this.uczestnicy = new liczba_os(this, this.PlayersNick);
                this.uczestnicy.Show();
                this.uczestnicy.Focus();
                return;
            }
            this.uczestnicy.Focus();
        }
        public void MemoryButton_Click(object sender, EventArgs e)
        {
            this.memory = new MemoryWindow();
            this.memory.Show();
            this.memory.Focus();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
			if (this.uczestnicy == null || uczestnicy.IsDisposed)
			{
				this.uczestnicy = new liczba_os(this, this.PlayersNick);
				this.uczestnicy.Show();
				this.uczestnicy.Focus();
				return;
			}
			this.uczestnicy.Focus();
		}
    }
}