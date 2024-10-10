﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            var res = 0.0;
            var i = startValue;
            do
            {
                res += 1 / Math.Pow(Math.Cos(5) + 1, 2);
                i++;
            }
            while (i <= stopValue);

            return Math.Round(res, 3);
        }
    }
}
