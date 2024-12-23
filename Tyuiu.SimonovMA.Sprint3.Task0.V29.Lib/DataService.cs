﻿using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimonovMA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double cosValue = Math.Cos(value);  //вычисляем cos(t) один раз, так как он не меняется в цикле

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow(value, 2*k) + (1.0 / (k + 1)); // В ТОЙ ДРОБИ ОБЯЗАТЕЛЬНО ПИШИ 1.0, А НЕ 1
                sum = sum + (term * cosValue);
            }

            return Math.Round(sum, 3);
        }
    }
}
