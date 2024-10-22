using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SimonovMA.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string finish = "";
            foreach(char symbol in value)
            {
                if (symbol != item) {
                    finish = finish + symbol;
                }
            }
            return finish;
        }
    }
}
