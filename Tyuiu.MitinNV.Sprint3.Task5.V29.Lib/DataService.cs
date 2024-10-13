using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            var res = 0.0;
            for (var i = startValue1; i <= stopValue1; i++)
            {
                for (var j = startValue2; j <= stopValue2; j++)
                {
                    res += (x / j) + Math.Sin(x);
                }
            }

            return Math.Round(res, 3);
        }
    }
}
