using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SmartHome
    {
        /// <summary>
        /// Создание поля даты включения кондиционера
        /// </summary>
        private DateTime date;
        /// <summary>
        /// Создание поля время включения кондиционера
        /// </summary>
        private DateTime time;
        /// <summary>
        /// Создание поля режим кондиционера
        /// </summary>
        private string regime;
        /// <summary>
        /// Создание поля температура воздуха
        /// </summary>
        private double temperature;
        /// <summary>
        /// Свойство поля даты включения кондиционера
        /// </summary>
        public DateTime Date { get { return date; } set { date = value; } }
        /// <summary>
        /// Свойство  поля время включения кондиционера
        /// </summary>
        public DateTime Time { get { return time; } set { time = value; } }
        /// <summary>
        /// Свойство поля режим кондиционера
        /// </summary>
        public string Regime { get { return regime; } set { regime = value; } }
        /// <summary>
        /// Свойство поля температуры воздуха
        /// </summary>
        public double Temperature { get { return temperature; } set { temperature = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SmartHome() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="regime"></param>
        /// <param name="temperature"></param>
        public SmartHome(DateTime date, DateTime time, string regime, double temperature)
        {
            this.Date = date;
            this.Time = time;
            this.Regime = regime;
            this.Temperature = temperature;
        }
        /// <summary>
        /// Метод, который выводит всю информацию
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Дата включения: {Date.ToShortDateString()}\nВремя включения: {Time.ToLongTimeString()}\nРежим работы кондиционера: {Regime}\nТемпература: {Temperature}");
        }
  
    }
}
