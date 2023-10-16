namespace Lab2Vegera
{
    public partial class Form1 : Form
    {
        Clock clock = new Clock();
        public Form1()
        {
            InitializeComponent();
            clock.secondT = Tick;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clock.timer.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clock.timer.Stop();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Tick()
        {
            textBox1.Text = clock.getTime("Moscow").ToString("HH:mm:ss");
            textBox2.Text = clock.getTime("London").ToString("HH:mm:ss");
            textBox3.Text = clock.getTime("Vladivostok").ToString("HH:mm:ss");
        }
    }
}