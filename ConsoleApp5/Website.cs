using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Website
    {
        /// <summary>
        /// Создание поля адреса
        /// </summary>
        private string webPage;
        /// <summary>
        /// Создание поля ip адреса 
        /// </summary>
        private string ip;
        /// <summary>
        /// Создание поля web браузера
        /// </summary>
        private string webBrowser;
        /// <summary>
        /// Создание поля даты посещения страницы
        /// </summary>
        private DateTime date;
        /// <summary>
        /// Создание поля времени посещения страницы
        /// </summary>
        private DateTime time;
        /// <summary>
        /// Свойство поля адреса
        /// </summary>
        public string WebPage { get { return webPage; } set { webPage = value; } }
        /// <summary>
        /// Свойство поля ip адреса
        /// </summary>
        public string Ip { get { return ip; } set { ip = value; } }
        /// <summary>
        /// Свойство поля web браузера
        /// </summary>
        public string WebBrowser { get { return webBrowser; } set { webBrowser = value; } }
        /// <summary>
        /// Свойство поля даты посещения страницы
        /// </summary>
        public DateTime Date { get { return date; } set { date = value; } }
        /// <summary>
        /// Свойство поля времени посещения страницы
        /// </summary>
        public DateTime Time { get { return time; } set { time = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Website() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="webPage"></param>
        /// <param name="ip"></param>
        /// <param name="webBrowser"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Website(string webPage, string ip, string webBrowser, DateTime date, DateTime time)
        {
            this.WebPage = webPage;
            this.Ip = ip;
            this.WebBrowser = webBrowser;
            this.Date = date;
            this.Time = time;
        }
        /// <summary>
        /// Метод, который выводит всю информацию
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Адрес: {WebPage}\nIP адрес: {Ip}\nWeb браузер: {WebBrowser}\nДата посещения страницы: {Date.ToShortDateString()}\nВремя посещения страницы: {Time.ToShortTimeString()}");
        }
    }
}
