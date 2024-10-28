using System;
using Tyuiu.SimonovMA.Sprint3.Task7.V17.Lib;

namespace Tyuiu.SimonovMA.Sprint3.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов к спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции на заданном*");
            Console.WriteLine("* диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При   *");
            Console.WriteLine("* делении на ноль вернуть значение 0. Значение округлить до двух знаков   *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("------------------");
            Console.WriteLine("- X         f(x) -");
            Console.WriteLine("------------------");

            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("- {0,5:d}   {1, 6:f2} -", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("------------------");
            Console.ReadKey();
        }
    }
}
