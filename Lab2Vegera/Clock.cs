﻿namespace OOP_Lab2
{
    class Clock
    {
        private static Dictionary<string, TimeSpan> TimeCity = new Dictionary<string, TimeSpan>();
        public delegate void SecondTick();
        public SecondTick secondT;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private DateTime TimeNow = DateTime.Now;

        //конструктор класса Clock
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
        //Каждую секунду обновляет время
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


        //Метод запуска таймера для часов
        public void StartClock()
        {
            timer.Start();
        }
        //Метод остановки таймера для часов
        public void StopClock() 
        {
            timer.Stop();
        }
    }
}
