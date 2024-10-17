using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimonovMA.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int k = startValue;
            double sum = 0;
            double piece = 0;

            do
            {
                piece = 1.0 / (Math.Cos(k) + 2);
                sum = sum + Math.Pow(piece, 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
