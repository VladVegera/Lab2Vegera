namespace OOP_Lab2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //��������� ������ CLock
        Clock clock = new Clock();
        public Form()
        {
            InitializeComponent();
            clock.secondT = Tick;
            KeyPreview = true;
        }
        //����� ��� ������� �����
        private void StartClock()
        {
            clock.StartClock();
        }
        //����� ��� ��������� �����
        private void StopClock()
        {
            clock.StopClock();
            //��������� �������� textBox
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        //����� ��� ���������� �������� ������� � textBox
        private void Tick()
        {
            textBox1.Text = clock.getTime("Moscow").ToString("HH:mm:ss");
            textBox2.Text = clock.getTime("London").ToString("HH:mm:ss");
            textBox3.Text = clock.getTime("Vladivostok").ToString("HH:mm:ss");
        }
        //������ ����� ����� ����
        private void StarClick(object sender, EventArgs e)
        {
            StartClock();
        }
        //��������� ����� ����� ����
        private void StopClick(object sender, EventArgs e)
        {
            StopClock();
        }
        //����� �� ��������� ����� ����
        private void ExitClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //��������� ������� ������ ��� ������� ���������
        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Alt)
            {
                StartClock();
            }
            if (e.KeyCode == Keys.C && e.Alt)
            {
                StopClock();
            }
        }
    }
}