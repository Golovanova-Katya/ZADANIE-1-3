using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нужную сумму");
            int[] banknotes = new int[] { 5000, 1000, 500, 100, 50, 10, 5, 2, 1 };// массив достоинств купюр
            int sum;// сумма от которой отталкиваемся
            while (true)
            {
                try
                {
                    sum = Convert.ToInt32(Console.ReadLine()); // вводим нужную сумму
                }
                catch
                {
                    Console.WriteLine("Вводите только цифры");
                    continue;
                }
                break;
            }
            Console.WriteLine("Были использованы следующие купюры:");
            for (int i = 0; i < banknotes.Length; i++)
            {
                int count = sum / banknotes[i];
                sum = sum % banknotes[i];
                Console.WriteLine("Достоинсвтом {0} \t {1} раз", banknotes[i], count);
            }
            Console.ReadLine();

        }
    }
}
