using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0.0;

            for (var i = startValue; i <= stopValue; i++)
            {
                res += Math.Sin(1) * Math.Pow(1 / 2, 2);
            }

            return res;
        }
    }
}
