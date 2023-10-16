namespace Lab2Vegera
{
    class Clock
    {
        private static Dictionary<string, TimeSpan> TimeCity = new Dictionary<string, TimeSpan>();
        public delegate void SecondTick();
        public SecondTick secondT;
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private DateTime TimeNow = DateTime.Now;

        //шаблон класса Clock
        public Clock()
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Tick);
            City();

        }

        //Метод возращаюший время взависимости от переданного значения
        public DateTime getTime(string city)
        {
            return TimeNow + TimeCity[city];
        }
        //
        private void Tick(object sender, EventArgs e)
        {
            TimeNow = DateTime.Now;
            secondT();
        }
        //метод для заполнения коллекции TimeCity
        private static void City()
        {
            TimeCity.Add("Moscow", TimeSpan.FromHours(0));
            TimeCity.Add("London", TimeSpan.FromHours(-2));
            TimeCity.Add("Vladivostok", TimeSpan.FromHours(7));
        }
        
    }
}
