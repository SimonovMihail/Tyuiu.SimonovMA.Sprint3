using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimonovMA.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for(int i = startValue; i <= stopValue; i++)
            {
                double result = 0;

                if (i == 0)
                {
                    break;
                }

                result = i / (Math.Cos(i) + Math.Sin(i));
                sum = sum + result;
            }

            return Math.Round(sum, 3);
        }
    }
}
