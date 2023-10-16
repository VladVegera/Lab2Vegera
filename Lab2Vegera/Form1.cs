namespace OOP_Lab2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //экземпляр класса CLock
        Clock clock = new Clock();
        public Form()
        {
            InitializeComponent();
            clock.secondT = Tick;
            KeyPreview = true;
        }
        //Метод для запуска часов
        private void StartClock()
        {
            clock.StartClock();
        }
        //Метод для остановки часов
        private void StopClock()
        {
            clock.StopClock();
            //обнуление значения textBox
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        //Метод для обновления значений времени в textBox
        private void Tick()
        {
            textBox1.Text = clock.getTime("Moscow").ToString("HH:mm:ss");
            textBox2.Text = clock.getTime("London").ToString("HH:mm:ss");
            textBox3.Text = clock.getTime("Vladivostok").ToString("HH:mm:ss");
        }
        //Запуск часов через меню
        private void StarClick(object sender, EventArgs e)
        {
            StartClock();
        }
        //Остановка часов через меню
        private void StopClick(object sender, EventArgs e)
        {
            StopClock();
        }
        //Выход из программы через меню
        private void ExitClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Обработка нажатия клавиш для запуска программы
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