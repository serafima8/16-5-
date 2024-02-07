using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //Console.Write("Введите кол-во посещений страницы: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Website[] websites = new Website[n];
            //for (int i = 0; i < websites.Length; i++)
            //{
            //    Console.Write("Введите адрес страницы: ");
            //    string webPage = Console.ReadLine();
            //    Console.Write("Введите IP адрес: ");
            //    string ip = Console.ReadLine();
            //    Console.Write("Введите Web браузер: ");
            //    string webBrowser = Console.ReadLine();
            //    Console.Write("Введите дату посещения страницы: ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());
            //    Console.Write($"День недели: {date.DayOfWeek}\n");
            //    Console.Write("Введите время посещения страницы: ");
            //    DateTime time = DateTime.Parse(Console.ReadLine());
            //    websites[i] = new Website(webPage, ip,webBrowser, date, time);
            //}
            //foreach (var elem in websites)
            //{
            //    elem.ShowInfo();
            //}


            //2

            //Console.Write("Введите кол-во включений кондиционера: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //SmartHome[] smartHomes = new SmartHome[n];
            //for (int i = 0; i < smartHomes.Length; i++)
            //{
            //    Console.Write("Дата включения кондиционера: ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Время включения кондиционера: ");
            //    DateTime time = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Температурный режим: ");
            //    string regim = Console.ReadLine();
            //    Console.Write("Температура воздуха:");
            //    double temperature = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($"Кол-во оставшихся минут до начала включения кондиционера: {(time - DateTime.Now).TotalMinutes}");
            //        smartHomes[i] = new SmartHome(date, time, regim, temperature);
            //}
            //foreach(var elem in smartHomes)
            //{
            //    elem.ShowInfo();
            //}

            Console.ReadKey();
        }
    }
}
