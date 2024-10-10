using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            var res = 0.0;
            for (var i = startValue2; i <= stopValue2; i++)
            {
                for (var j = startValue1; j <= stopValue1; j++)
                {
                    res += (x / j) + Math.Sin(x);
                }
            }

            return Math.Round(res, 3);
        }
    }
}
