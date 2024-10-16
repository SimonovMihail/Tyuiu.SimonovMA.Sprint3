using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimonovMA.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            double big_repeatable_thing = 0;
            while (k <= stopValue)
            {
                double cosValue = Math.Cos(k);
                big_repeatable_thing = Math.Pow(value, k) + 1.0 / 2;
                sum = sum + big_repeatable_thing * cosValue;
                k++;
            }
            return Math.Round(sum, 3);
        }
    }
}
